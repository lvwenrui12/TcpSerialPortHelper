﻿namespace WifiTestTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.txtNetServerPort = new System.Windows.Forms.TextBox();
            this.txtNetServerIp = new System.Windows.Forms.TextBox();
            this.btnNetConnect = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtLocalServerPort = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnNetServerStart = new System.Windows.Forms.Button();
            this.btnBrodcast = new System.Windows.Forms.Button();
            this.btnTcpClearRece = new System.Windows.Forms.Button();
            this.txtTcpRece = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTcpSend = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnTcpClearSend = new System.Windows.Forms.Button();
            this.txtSendCmd = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comportName = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtComRead = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComWrite = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl3.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Location = new System.Drawing.Point(425, 231);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(439, 221);
            this.tabControl3.TabIndex = 16;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Controls.Add(this.label31);
            this.tabPage9.Controls.Add(this.txtNetServerPort);
            this.tabPage9.Controls.Add(this.txtNetServerIp);
            this.tabPage9.Controls.Add(this.btnNetConnect);
            this.tabPage9.Controls.Add(this.label32);
            this.tabPage9.Controls.Add(this.label33);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(431, 195);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Client";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "断开连接";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Maroon;
            this.label31.Location = new System.Drawing.Point(44, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(233, 12);
            this.label31.TabIndex = 9;
            this.label31.Text = "连接前检查自身ip是否和Server端同一网段";
            // 
            // txtNetServerPort
            // 
            this.txtNetServerPort.Location = new System.Drawing.Point(141, 67);
            this.txtNetServerPort.Name = "txtNetServerPort";
            this.txtNetServerPort.Size = new System.Drawing.Size(148, 21);
            this.txtNetServerPort.TabIndex = 8;
            // 
            // txtNetServerIp
            // 
            this.txtNetServerIp.Location = new System.Drawing.Point(141, 12);
            this.txtNetServerIp.Name = "txtNetServerIp";
            this.txtNetServerIp.Size = new System.Drawing.Size(148, 21);
            this.txtNetServerIp.TabIndex = 6;
            // 
            // btnNetConnect
            // 
            this.btnNetConnect.Location = new System.Drawing.Point(224, 141);
            this.btnNetConnect.Name = "btnNetConnect";
            this.btnNetConnect.Size = new System.Drawing.Size(80, 31);
            this.btnNetConnect.TabIndex = 5;
            this.btnNetConnect.Text = "连接";
            this.btnNetConnect.UseVisualStyleBackColor = true;
            this.btnNetConnect.Click += new System.EventHandler(this.btnNetConnect_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(22, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(113, 12);
            this.label32.TabIndex = 7;
            this.label32.Text = "TCP Server的端口号";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(22, 20);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(113, 12);
            this.label33.TabIndex = 1;
            this.label33.Text = "TCP Server的IP地址";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.btnServerStop);
            this.tabPage10.Controls.Add(this.checkBox1);
            this.tabPage10.Controls.Add(this.listBoxClient);
            this.tabPage10.Controls.Add(this.label34);
            this.tabPage10.Controls.Add(this.txtLocalServerPort);
            this.tabPage10.Controls.Add(this.label35);
            this.tabPage10.Controls.Add(this.btnNetServerStart);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(431, 195);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Server";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // btnServerStop
            // 
            this.btnServerStop.Location = new System.Drawing.Point(355, 56);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(70, 31);
            this.btnServerStop.TabIndex = 29;
            this.btnServerStop.Text = "停止";
            this.btnServerStop.UseVisualStyleBackColor = true;
            this.btnServerStop.Click += new System.EventHandler(this.btnServerStop_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(270, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "记录数据";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBoxClient
            // 
            this.listBoxClient.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 16;
            this.listBoxClient.Location = new System.Drawing.Point(106, 56);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(236, 132);
            this.listBoxClient.TabIndex = 27;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(23, 56);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(77, 12);
            this.label34.TabIndex = 26;
            this.label34.Text = "连接的客户端";
            // 
            // txtLocalServerPort
            // 
            this.txtLocalServerPort.Location = new System.Drawing.Point(142, 12);
            this.txtLocalServerPort.Name = "txtLocalServerPort";
            this.txtLocalServerPort.Size = new System.Drawing.Size(121, 21);
            this.txtLocalServerPort.TabIndex = 8;
            this.txtLocalServerPort.Text = "5000";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(23, 16);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(113, 12);
            this.label35.TabIndex = 7;
            this.label35.Text = "TCP Server的端口号";
            // 
            // btnNetServerStart
            // 
            this.btnNetServerStart.Location = new System.Drawing.Point(355, 16);
            this.btnNetServerStart.Name = "btnNetServerStart";
            this.btnNetServerStart.Size = new System.Drawing.Size(70, 31);
            this.btnNetServerStart.TabIndex = 5;
            this.btnNetServerStart.Text = "启动";
            this.btnNetServerStart.UseVisualStyleBackColor = true;
            this.btnNetServerStart.Click += new System.EventHandler(this.btnNetServerStart_Click);
            // 
            // btnBrodcast
            // 
            this.btnBrodcast.Location = new System.Drawing.Point(783, 469);
            this.btnBrodcast.Name = "btnBrodcast";
            this.btnBrodcast.Size = new System.Drawing.Size(67, 31);
            this.btnBrodcast.TabIndex = 40;
            this.btnBrodcast.Text = "广播";
            this.btnBrodcast.UseVisualStyleBackColor = true;
            this.btnBrodcast.Click += new System.EventHandler(this.btnBrodcast_Click);
            // 
            // btnTcpClearRece
            // 
            this.btnTcpClearRece.Location = new System.Drawing.Point(425, 469);
            this.btnTcpClearRece.Name = "btnTcpClearRece";
            this.btnTcpClearRece.Size = new System.Drawing.Size(76, 31);
            this.btnTcpClearRece.TabIndex = 39;
            this.btnTcpClearRece.Text = "清空接收";
            this.btnTcpClearRece.UseVisualStyleBackColor = true;
            this.btnTcpClearRece.Click += new System.EventHandler(this.btnTcpClearRece_Click);
            // 
            // txtTcpRece
            // 
            this.txtTcpRece.Location = new System.Drawing.Point(6, 43);
            this.txtTcpRece.Multiline = true;
            this.txtTcpRece.Name = "txtTcpRece";
            this.txtTcpRece.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTcpRece.Size = new System.Drawing.Size(399, 457);
            this.txtTcpRece.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 38;
            this.label20.Text = "接收数据";
            // 
            // txtTcpSend
            // 
            this.txtTcpSend.Location = new System.Drawing.Point(665, 469);
            this.txtTcpSend.Name = "txtTcpSend";
            this.txtTcpSend.Size = new System.Drawing.Size(67, 31);
            this.txtTcpSend.TabIndex = 35;
            this.txtTcpSend.Text = "发送";
            this.txtTcpSend.UseVisualStyleBackColor = true;
            this.txtTcpSend.Click += new System.EventHandler(this.txtTcpSend_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(427, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "发送数据";
            // 
            // btnTcpClearSend
            // 
            this.btnTcpClearSend.Location = new System.Drawing.Point(546, 469);
            this.btnTcpClearSend.Name = "btnTcpClearSend";
            this.btnTcpClearSend.Size = new System.Drawing.Size(76, 31);
            this.btnTcpClearSend.TabIndex = 36;
            this.btnTcpClearSend.Text = "清空发送";
            this.btnTcpClearSend.UseVisualStyleBackColor = true;
            this.btnTcpClearSend.Click += new System.EventHandler(this.btnTcpClearSend_Click);
            // 
            // txtSendCmd
            // 
            this.txtSendCmd.Location = new System.Drawing.Point(425, 43);
            this.txtSendCmd.Multiline = true;
            this.txtSendCmd.Name = "txtSendCmd";
            this.txtSendCmd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSendCmd.Size = new System.Drawing.Size(431, 173);
            this.txtSendCmd.TabIndex = 33;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 539);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTcpRece);
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Controls.Add(this.btnBrodcast);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.txtTcpSend);
            this.tabPage1.Controls.Add(this.btnTcpClearRece);
            this.tabPage1.Controls.Add(this.btnTcpClearSend);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtSendCmd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "网络调试";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.txtComRead);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtComWrite);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "串口调试";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comportName);
            this.groupBox1.Location = new System.Drawing.Point(465, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "奇偶校验";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口选择";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comboBox5.Location = new System.Drawing.Point(314, 54);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(57, 20);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.Text = "Even";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox4.Location = new System.Drawing.Point(241, 54);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(57, 20);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.Text = "1";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comboBox3.Location = new System.Drawing.Point(173, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(57, 20);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.Text = "8";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(103, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 20);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "9600";
            // 
            // comportName
            // 
            this.comportName.FormattingEnabled = true;
            this.comportName.Location = new System.Drawing.Point(25, 54);
            this.comportName.Name = "comportName";
            this.comportName.Size = new System.Drawing.Size(57, 20);
            this.comportName.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(779, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "打开端口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtComRead
            // 
            this.txtComRead.Location = new System.Drawing.Point(21, 43);
            this.txtComRead.Multiline = true;
            this.txtComRead.Name = "txtComRead";
            this.txtComRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComRead.Size = new System.Drawing.Size(427, 308);
            this.txtComRead.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "串口接收数据:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "串口发送数据:";
            // 
            // txtComWrite
            // 
            this.txtComWrite.Location = new System.Drawing.Point(21, 366);
            this.txtComWrite.Multiline = true;
            this.txtComWrite.Name = "txtComWrite";
            this.txtComWrite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComWrite.Size = new System.Drawing.Size(427, 93);
            this.txtComWrite.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(465, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 555);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Wifi网络测试工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl3.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtNetServerPort;
        private System.Windows.Forms.TextBox txtNetServerIp;
        private System.Windows.Forms.Button btnNetConnect;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtLocalServerPort;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnNetServerStart;
        private System.Windows.Forms.Button btnBrodcast;
        private System.Windows.Forms.Button btnTcpClearRece;
        private System.Windows.Forms.TextBox txtTcpRece;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button txtTcpSend;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnTcpClearSend;
        private System.Windows.Forms.TextBox txtSendCmd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnServerStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comportName;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtComRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComWrite;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

