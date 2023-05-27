using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaderB;

namespace PKUHFSample
{
    public partial class Home : Form
    {
        private byte _fComAdr = 0xff;
        private int _frmComportIndex;
        private int _fOpenComIndex;
        private int _fCmdRet = 30;
        private bool _fIsInventoryScan;
        private byte[] _fPassWord = new byte[4];
        private int _fErrorCode;

        public Home()
        {
            InitializeComponent();
        }

        private void OpenNetPort_Click(object sender, EventArgs e)
        {
            _fComAdr = Convert.ToByte(textBox9.Text, 16); // $FF;
            if ((textBox7.Text == "") || (textBox8.Text == ""))
                MessageBox.Show("Config error!", "information");
            var port = Convert.ToInt32(textBox7.Text);
            var ipAddress = textBox8.Text;
            var openResult = StaticClassReaderB.OpenNetPort(port, ipAddress, ref _fComAdr, ref _frmComportIndex);
            _fOpenComIndex = _frmComportIndex;
            if ((openResult == 0x35) || (openResult == 0x30))
            {
                MessageBox.Show("TCPIP error", "Information");
                StaticClassReaderB.CloseNetPort(_frmComportIndex);
                return;
            }
            if (_fOpenComIndex != -1 && (openResult != 0X35) && (openResult != 0X30))
            {
                button2.Enabled = true;
            }
            if ((_fOpenComIndex == -1) && (openResult == 0x30))
                MessageBox.Show("TCPIP Communication Error", "Information");
        }

        private void CloseNetPort_Click(object sender, EventArgs e)
        {
            _fCmdRet = StaticClassReaderB.CloseNetPort(_frmComportIndex);
            if (_fCmdRet == 0)
            {
                button2.Enabled = false;
                listBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Timer_Test_.Enabled = !Timer_Test_.Enabled;
            if (!Timer_Test_.Enabled)
                button2.Text = "Query ,  Read Tag";
            else
            {
                button2.Text = "Stop";
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }

        private void Timer_Test__Tick(object sender, EventArgs e)
        {
            if (_fIsInventoryScan)
                return;
            Inventory();
        }

        private void Inventory()
        {
            int cardNum = 0;
            int totalLen = 0;
            int m;
            byte[] epc = new byte[5000];
            _fIsInventoryScan = true;
            byte adrTid = 0;
            byte lenTid = 0;
            byte tidFlag = 0;

            _fCmdRet = StaticClassReaderB.Inventory_G2(ref _fComAdr, adrTid, lenTid, tidFlag, epc, ref totalLen, ref cardNum, _frmComportIndex);
            if ((_fCmdRet == 1) | (_fCmdRet == 2) | (_fCmdRet == 3) | (_fCmdRet == 4) | (_fCmdRet == 0xFB))
            {
                byte[] daw = new byte[totalLen];
                Array.Copy(epc, daw, totalLen);
                var temps = ByteArrayToHexString(daw);
                m = 0;

                if (cardNum == 0)
                {
                    _fIsInventoryScan = false;
                    return;
                }

                int cardIndex;
                for (cardIndex = 0; cardIndex < cardNum; cardIndex++)
                {
                    int epClean = daw[m];
                    var sEpc = temps.Substring(m * 2 + 2, epClean * 2);
                    m = m + epClean + 1;
                    if (sEpc.Length != epClean * 2)
                        return;


                    listBox1.Items.Add(sEpc);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;

                    //Read User
                    ReadUser(sEpc);
                }
            }

            _fIsInventoryScan = false;
        }

        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }

        private void ComboBox_IntervalTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_IntervalTime.SelectedIndex < 6)
                Timer_Test_.Interval = 100;
            else
                Timer_Test_.Interval = (ComboBox_IntervalTime.SelectedIndex + 4) * 10;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            int i = 40;

            while (i <= 300)
            {
                ComboBox_IntervalTime.Items.Add(Convert.ToString(i) + "ms");
                i += 10;
            }
            ComboBox_IntervalTime.SelectedIndex = 1;
        }


        private void ReadUser(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return;

            byte[] cardData = new byte[320];


            byte maskAddress = Convert.ToByte("00", 16);
            byte maskLength = Convert.ToByte("00", 16);


            var eNum = Convert.ToByte(str.Length / 4);
            byte epcLength = Convert.ToByte(str.Length / 2);
            byte[] epc = new byte[eNum];
            epc = HexStringToByteArray(str);


            var wordPtr = Convert.ToByte("00", 16);
            var num = Convert.ToByte("02");

            _fPassWord = HexStringToByteArray("00000000");
            _fCmdRet = StaticClassReaderB.ReadCard_G2(ref _fComAdr, epc, 3, wordPtr, num, _fPassWord, maskAddress, maskLength, 0, cardData, epcLength, ref _fErrorCode, _frmComportIndex);
            if (_fCmdRet == 0)
            {
                byte[] daw = new byte[num * 2];
                Array.Copy(cardData, daw, num * 2);
                var user = ByteArrayToHexString(daw);

                user = user.Remove(6, 2);


                listBox2.Items.Add(user);
                listBox2.SelectedIndex = listBox2.Items.Count - 1;
            }



        }

        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private void Button_DataWrite_Click(object sender, EventArgs e)
        {
            string value = Edit_WriteData.Text;

            if (value.Length != 6)
            {
                MessageBox.Show("The Number must be 6", "Wtite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            value += "AA";


            byte maskAddress = Convert.ToByte("00", 16);
            byte maskLength = Convert.ToByte("00", 16);



            string str = GetEpc();
            if (string.IsNullOrWhiteSpace(str))
            {
                MessageBox.Show("not found tag", "tracking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var eNum = Convert.ToByte(str.Length / 4);
            byte epcLength = Convert.ToByte(eNum * 2);
            byte[] epc = new byte[eNum];
            epc = HexStringToByteArray(str);


            var wordPtr = Convert.ToByte("00", 16);

            _fPassWord = HexStringToByteArray("00000000");

            byte wNum = Convert.ToByte(value.Length / 4);
            byte[] writeData = new byte[wNum * 2];
            writeData = HexStringToByteArray(value);
            byte writeDataLen = Convert.ToByte(wNum * 2);

            _fCmdRet = StaticClassReaderB.WriteCard_G2(ref _fComAdr, epc, 3, wordPtr, writeDataLen, writeData, _fPassWord, maskAddress, maskLength, 0, 0, epcLength, ref _fErrorCode, _frmComportIndex);

            if (_fCmdRet == 0)
                MessageBox.Show("completely write Data successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(" write Data filed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private string GetEpc()
        {
            int cardNum = 0;
            int totalLen = 0;
            byte[] epc = new byte[5000];
            byte adrTid = 0;
            byte lenTid = 0;
            byte tidFlag = 0;

            _fCmdRet = StaticClassReaderB.Inventory_G2(ref _fComAdr, adrTid, lenTid, tidFlag, epc, ref totalLen, ref cardNum, _frmComportIndex);
            if ((_fCmdRet == 1) | (_fCmdRet == 2) | (_fCmdRet == 3) | (_fCmdRet == 4) | (_fCmdRet == 0xFB))
            {
                byte[] daw = new byte[totalLen];
                Array.Copy(epc, daw, totalLen);
                var temps = ByteArrayToHexString(daw);

                if (cardNum == 0)
                    return "";
                int epClean = daw[0];
                var sEpc = temps.Substring(0 * 2 + 2, epClean * 2);
                if (sEpc.Length != epClean * 2)
                    return "";

                return sEpc;
            }

            return "";

        }

    }
}
