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
        private byte _fComAdr = 0xff; //当前操作的ComAdr
        private int _frmComportIndex;
        private int _fOpenComIndex; //打开的串口索引号
        private bool _comOpen = false;
        private int _fCmdRet = 30; //所有执行指令的返回值
        private bool fIsInventoryScan;
        private bool fAppClosed;
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
                _comOpen = false;
                return;
            }
            if (_fOpenComIndex != -1 && (openResult != 0X35) && (openResult != 0X30))
            {
                button2.Enabled = true;
                _comOpen = true;
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
            if (CheckBox_TID.Checked)
            {
                if ((textBox4.Text.Length) != 2 || ((textBox5.Text.Length) != 2))
                {
                    MessageBox.Show("TID Parameter Error！", "Information");
                    return;
                }
            }
            Timer_Test_.Enabled = !Timer_Test_.Enabled;
            if (!Timer_Test_.Enabled)
            {
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                CheckBox_TID.Enabled = true;
                button2.Text = "Query Tag";

            }
            else
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                CheckBox_TID.Enabled = false;
                button2.Text = "Stop";

                listBox1.Items.Clear();
            }
        }

        private void Timer_Test__Tick(object sender, EventArgs e)
        {
            if (fIsInventoryScan)
                return;
            Inventory();
        }

        private void Inventory()
        {
            int cardNum = 0;
            int totalLen = 0;
            int m;
            byte[] epc = new byte[5000];
            string s;
            fIsInventoryScan = true;
            byte adrTid = 0;
            byte lenTid = 0;
            byte tidFlag = 0;
            if (CheckBox_TID.Checked)
            {
                adrTid = Convert.ToByte(textBox4.Text, 16);
                lenTid = Convert.ToByte(textBox5.Text, 16);
                tidFlag = 1;
            }
            else
            {
                adrTid = 0;
                lenTid = 0;
                tidFlag = 0;
            }
            ListViewItem aListItem = new ListViewItem();
            _fCmdRet = StaticClassReaderB.Inventory_G2(ref _fComAdr, adrTid, lenTid, tidFlag, epc, ref totalLen, ref cardNum, _frmComportIndex);
            if ((_fCmdRet == 1) | (_fCmdRet == 2) | (_fCmdRet == 3) | (_fCmdRet == 4) | (_fCmdRet == 0xFB))//代表已查找结束，
            {
                byte[] daw = new byte[totalLen];
                Array.Copy(epc, daw, totalLen);
                var temps = ByteArrayToHexString(daw);
                m = 0;

                if (cardNum == 0)
                {
                    fIsInventoryScan = false;
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

                }
            }
            
            fIsInventoryScan = false;
            if (fAppClosed)
                Close();
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
                i = i + 10;
            }
            ComboBox_IntervalTime.SelectedIndex = 1;
        }
    }
}
