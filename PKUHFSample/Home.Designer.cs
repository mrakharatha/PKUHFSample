namespace PKUHFSample
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.CloseNetPort = new System.Windows.Forms.Button();
            this.OpenNetPort = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ComboBox_IntervalTime = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Timer_Test_ = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_DataWrite = new System.Windows.Forms.Button();
            this.Edit_WriteData = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox41.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.CloseNetPort);
            this.groupBox41.Controls.Add(this.OpenNetPort);
            this.groupBox41.Controls.Add(this.textBox9);
            this.groupBox41.Controls.Add(this.label63);
            this.groupBox41.Controls.Add(this.textBox8);
            this.groupBox41.Controls.Add(this.label64);
            this.groupBox41.Controls.Add(this.textBox7);
            this.groupBox41.Controls.Add(this.label65);
            this.groupBox41.Location = new System.Drawing.Point(12, 12);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Size = new System.Drawing.Size(133, 180);
            this.groupBox41.TabIndex = 52;
            this.groupBox41.TabStop = false;
            this.groupBox41.Text = "TCPIP";
            // 
            // CloseNetPort
            // 
            this.CloseNetPort.Location = new System.Drawing.Point(9, 147);
            this.CloseNetPort.Name = "CloseNetPort";
            this.CloseNetPort.Size = new System.Drawing.Size(113, 25);
            this.CloseNetPort.TabIndex = 7;
            this.CloseNetPort.Text = "CloseNetPort";
            this.CloseNetPort.UseVisualStyleBackColor = true;
            this.CloseNetPort.Click += new System.EventHandler(this.CloseNetPort_Click);
            // 
            // OpenNetPort
            // 
            this.OpenNetPort.Location = new System.Drawing.Point(9, 114);
            this.OpenNetPort.Name = "OpenNetPort";
            this.OpenNetPort.Size = new System.Drawing.Size(113, 25);
            this.OpenNetPort.TabIndex = 6;
            this.OpenNetPort.Text = "OpenNetPort";
            this.OpenNetPort.UseVisualStyleBackColor = true;
            this.OpenNetPort.Click += new System.EventHandler(this.OpenNetPort_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(43, 85);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(78, 20);
            this.textBox9.TabIndex = 5;
            this.textBox9.Text = "FF";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(7, 88);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(35, 13);
            this.label63.TabIndex = 4;
            this.label63.Text = "Addr：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(33, 53);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(88, 20);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "192.168.1.190";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(7, 56);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(23, 13);
            this.label64.TabIndex = 2;
            this.label64.Text = "IP：";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(40, 23);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 20);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "6000";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 27);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(29, 13);
            this.label65.TabIndex = 0;
            this.label65.Text = "Port:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.Controls.Add(this.ComboBox_IntervalTime);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(151, 16);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(269, 79);
            this.groupBox12.TabIndex = 53;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Query Tag";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(101, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Query ,  Read Tag";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComboBox_IntervalTime
            // 
            this.ComboBox_IntervalTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_IntervalTime.FormattingEnabled = true;
            this.ComboBox_IntervalTime.Location = new System.Drawing.Point(101, 22);
            this.ComboBox_IntervalTime.Name = "ComboBox_IntervalTime";
            this.ComboBox_IntervalTime.Size = new System.Drawing.Size(162, 21);
            this.ComboBox_IntervalTime.TabIndex = 1;
            this.ComboBox_IntervalTime.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IntervalTime_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Read Interval:";
            // 
            // Timer_Test_
            // 
            this.Timer_Test_.Tick += new System.EventHandler(this.Timer_Test__Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 238);
            this.listBox1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "TID";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(211, 207);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(209, 238);
            this.listBox2.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_DataWrite);
            this.groupBox1.Controls.Add(this.Edit_WriteData);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Location = new System.Drawing.Point(151, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 92);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write Data (Hex)";
            // 
            // Button_DataWrite
            // 
            this.Button_DataWrite.Location = new System.Drawing.Point(101, 47);
            this.Button_DataWrite.Name = "Button_DataWrite";
            this.Button_DataWrite.Size = new System.Drawing.Size(162, 25);
            this.Button_DataWrite.TabIndex = 63;
            this.Button_DataWrite.Text = "Write";
            this.Button_DataWrite.UseVisualStyleBackColor = true;
            this.Button_DataWrite.Click += new System.EventHandler(this.Button_DataWrite_Click);
            // 
            // Edit_WriteData
            // 
            this.Edit_WriteData.Location = new System.Drawing.Point(101, 21);
            this.Edit_WriteData.Name = "Edit_WriteData";
            this.Edit_WriteData.Size = new System.Drawing.Size(162, 20);
            this.Edit_WriteData.TabIndex = 62;
            this.Edit_WriteData.Text = "000000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 61;
            this.label21.Text = "Write Data:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox41);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PKUHF Reader";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox41;
        private System.Windows.Forms.Button CloseNetPort;
        private System.Windows.Forms.Button OpenNetPort;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboBox_IntervalTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer Timer_Test_;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_DataWrite;
        private System.Windows.Forms.TextBox Edit_WriteData;
        private System.Windows.Forms.Label label21;
    }
}

