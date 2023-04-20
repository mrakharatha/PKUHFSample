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
            this.CheckBox_TID = new System.Windows.Forms.CheckBox();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ComboBox_IntervalTime = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Timer_Test_ = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox41.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox33.SuspendLayout();
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
            this.label63.Location = new System.Drawing.Point(7, 94);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(35, 13);
            this.label63.TabIndex = 4;
            this.label63.Text = "Addr：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(33, 47);
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
            this.textBox7.Location = new System.Drawing.Point(40, 17);
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
            this.groupBox12.Controls.Add(this.CheckBox_TID);
            this.groupBox12.Controls.Add(this.groupBox33);
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.Controls.Add(this.ComboBox_IntervalTime);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(151, 16);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(269, 176);
            this.groupBox12.TabIndex = 53;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Query Tag";
            // 
            // CheckBox_TID
            // 
            this.CheckBox_TID.AutoSize = true;
            this.CheckBox_TID.Location = new System.Drawing.Point(226, 65);
            this.CheckBox_TID.Name = "CheckBox_TID";
            this.CheckBox_TID.Size = new System.Drawing.Size(44, 17);
            this.CheckBox_TID.TabIndex = 6;
            this.CheckBox_TID.Text = "TID";
            this.CheckBox_TID.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.textBox5);
            this.groupBox33.Controls.Add(this.label55);
            this.groupBox33.Controls.Add(this.textBox4);
            this.groupBox33.Controls.Add(this.label54);
            this.groupBox33.Location = new System.Drawing.Point(6, 43);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(209, 52);
            this.groupBox33.TabIndex = 5;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Query TID Parameter";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 15);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(37, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "04";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(126, 25);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(31, 13);
            this.label55.TabIndex = 2;
            this.label55.Text = "Len：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(71, 16);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "02";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(4, 26);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(57, 13);
            this.label54.TabIndex = 0;
            this.label54.Text = "StartAddr：";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(9, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Query Tag";
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
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(423, 251);
            this.listBox1.TabIndex = 54;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
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
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox41;
        private System.Windows.Forms.Button CloseNetPort;
        private System.Windows.Forms.Button OpenNetPort;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox CheckBox_TID;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboBox_IntervalTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer Timer_Test_;
        private System.Windows.Forms.ListBox listBox1;
    }
}

