namespace Modbus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.btnCheckCOM = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbLiveData = new System.Windows.Forms.CheckBox();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.cbxParitv = new System.Windows.Forms.ComboBox();
            this.cbxDevAdd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCleanData = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxRecvData = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Check_0220 = new System.Windows.Forms.Label();
            this.Check_0219 = new System.Windows.Forms.Label();
            this.Check_0218 = new System.Windows.Forms.Label();
            this.Check_0217 = new System.Windows.Forms.Label();
            this.Check_0216 = new System.Windows.Forms.Label();
            this.Check_0215 = new System.Windows.Forms.Label();
            this.Check_0214 = new System.Windows.Forms.Label();
            this.Check_0213 = new System.Windows.Forms.Label();
            this.Check_0212 = new System.Windows.Forms.Label();
            this.Check_0211 = new System.Windows.Forms.Label();
            this.Check_0210 = new System.Windows.Forms.Label();
            this.Check_0209 = new System.Windows.Forms.Label();
            this.Check_0208 = new System.Windows.Forms.Label();
            this.Check_0207 = new System.Windows.Forms.Label();
            this.Check_0206 = new System.Windows.Forms.Label();
            this.Check_0205 = new System.Windows.Forms.Label();
            this.Check_0204 = new System.Windows.Forms.Label();
            this.Check_0203 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Check_0202 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Check_0201 = new System.Windows.Forms.Label();
            this.Check_0200 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Check_0325 = new System.Windows.Forms.Label();
            this.Check_0324 = new System.Windows.Forms.Label();
            this.Check_0323 = new System.Windows.Forms.Label();
            this.Check_0322 = new System.Windows.Forms.Label();
            this.Check_0321 = new System.Windows.Forms.Label();
            this.Check_0320 = new System.Windows.Forms.Label();
            this.Check_0319 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.Check_0314 = new System.Windows.Forms.Label();
            this.Check_0313 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.Check_0318 = new System.Windows.Forms.Label();
            this.Check_0317 = new System.Windows.Forms.Label();
            this.Check_0316 = new System.Windows.Forms.Label();
            this.Check_0315 = new System.Windows.Forms.Label();
            this.Check_0312 = new System.Windows.Forms.Label();
            this.Check_0311 = new System.Windows.Forms.Label();
            this.Check_0310 = new System.Windows.Forms.Label();
            this.Check_0309 = new System.Windows.Forms.Label();
            this.Check_0308 = new System.Windows.Forms.Label();
            this.Check_0307 = new System.Windows.Forms.Label();
            this.Check_0306 = new System.Windows.Forms.Label();
            this.Check_0305 = new System.Windows.Forms.Label();
            this.Check_0304 = new System.Windows.Forms.Label();
            this.Check_0303 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.Check_0302 = new System.Windows.Forms.Label();
            this.Check_0301 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Check_0300 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Check_0405 = new System.Windows.Forms.Label();
            this.Check_0404 = new System.Windows.Forms.Label();
            this.Check_0403 = new System.Windows.Forms.Label();
            this.Check_0402 = new System.Windows.Forms.Label();
            this.Check_0401 = new System.Windows.Forms.Label();
            this.Check_0400 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            resources.ApplyResources(this.cbxCOMPort, "cbxCOMPort");
            this.cbxCOMPort.Name = "cbxCOMPort";
            // 
            // btnCheckCOM
            // 
            resources.ApplyResources(this.btnCheckCOM, "btnCheckCOM");
            this.btnCheckCOM.Name = "btnCheckCOM";
            this.btnCheckCOM.UseVisualStyleBackColor = true;
            this.btnCheckCOM.Click += new System.EventHandler(this.BtnCheckCOM_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ckbLiveData);
            this.groupBox1.Controls.Add(this.btnOpenCom);
            this.groupBox1.Controls.Add(this.btnCheckCOM);
            this.groupBox1.Controls.Add(this.cbxParitv);
            this.groupBox1.Controls.Add(this.cbxDevAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.cbxCOMPort);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // ckbLiveData
            // 
            resources.ApplyResources(this.ckbLiveData, "ckbLiveData");
            this.ckbLiveData.Name = "ckbLiveData";
            this.ckbLiveData.UseVisualStyleBackColor = true;
            this.ckbLiveData.CheckedChanged += new System.EventHandler(this.CkbLiveData_CheckedChanged);
            // 
            // btnOpenCom
            // 
            resources.ApplyResources(this.btnOpenCom, "btnOpenCom");
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.BtnOpenCom_Click);
            // 
            // cbxParitv
            // 
            this.cbxParitv.FormattingEnabled = true;
            this.cbxParitv.Items.AddRange(new object[] {
            resources.GetString("cbxParitv.Items"),
            resources.GetString("cbxParitv.Items1"),
            resources.GetString("cbxParitv.Items2")});
            resources.ApplyResources(this.cbxParitv, "cbxParitv");
            this.cbxParitv.Name = "cbxParitv";
            // 
            // cbxDevAdd
            // 
            this.cbxDevAdd.FormattingEnabled = true;
            resources.ApplyResources(this.cbxDevAdd, "cbxDevAdd");
            this.cbxDevAdd.Name = "cbxDevAdd";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            resources.GetString("cbxBaudRate.Items"),
            resources.GetString("cbxBaudRate.Items1"),
            resources.GetString("cbxBaudRate.Items2"),
            resources.GetString("cbxBaudRate.Items3"),
            resources.GetString("cbxBaudRate.Items4"),
            resources.GetString("cbxBaudRate.Items5"),
            resources.GetString("cbxBaudRate.Items6"),
            resources.GetString("cbxBaudRate.Items7"),
            resources.GetString("cbxBaudRate.Items8"),
            resources.GetString("cbxBaudRate.Items9")});
            resources.ApplyResources(this.cbxBaudRate, "cbxBaudRate");
            this.cbxBaudRate.Name = "cbxBaudRate";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Items.AddRange(new object[] {
            resources.GetString("cbxDataBits.Items"),
            resources.GetString("cbxDataBits.Items1"),
            resources.GetString("cbxDataBits.Items2"),
            resources.GetString("cbxDataBits.Items3")});
            resources.ApplyResources(this.cbxDataBits, "cbxDataBits");
            this.cbxDataBits.Name = "cbxDataBits";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Items.AddRange(new object[] {
            resources.GetString("cbxStopBits.Items"),
            resources.GetString("cbxStopBits.Items1"),
            resources.GetString("cbxStopBits.Items2")});
            resources.ApplyResources(this.cbxStopBits, "cbxStopBits");
            this.cbxStopBits.Name = "cbxStopBits";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCleanData);
            this.groupBox5.Controls.Add(this.btnSend);
            this.groupBox5.Controls.Add(this.tbxSendData);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btnCleanData
            // 
            resources.ApplyResources(this.btnCleanData, "btnCleanData");
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.UseVisualStyleBackColor = true;
            this.btnCleanData.Click += new System.EventHandler(this.BtnCleanData_Click);
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tbxSendData
            // 
            resources.ApplyResources(this.tbxSendData, "tbxSendData");
            this.tbxSendData.Name = "tbxSendData";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxRecvData);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // tbxRecvData
            // 
            resources.ApplyResources(this.tbxRecvData, "tbxRecvData");
            this.tbxRecvData.Name = "tbxRecvData";
            this.tbxRecvData.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Check_0220);
            this.tabPage1.Controls.Add(this.Check_0219);
            this.tabPage1.Controls.Add(this.Check_0218);
            this.tabPage1.Controls.Add(this.Check_0217);
            this.tabPage1.Controls.Add(this.Check_0216);
            this.tabPage1.Controls.Add(this.Check_0215);
            this.tabPage1.Controls.Add(this.Check_0214);
            this.tabPage1.Controls.Add(this.Check_0213);
            this.tabPage1.Controls.Add(this.Check_0212);
            this.tabPage1.Controls.Add(this.Check_0211);
            this.tabPage1.Controls.Add(this.Check_0210);
            this.tabPage1.Controls.Add(this.Check_0209);
            this.tabPage1.Controls.Add(this.Check_0208);
            this.tabPage1.Controls.Add(this.Check_0207);
            this.tabPage1.Controls.Add(this.Check_0206);
            this.tabPage1.Controls.Add(this.Check_0205);
            this.tabPage1.Controls.Add(this.Check_0204);
            this.tabPage1.Controls.Add(this.Check_0203);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Check_0202);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Check_0201);
            this.tabPage1.Controls.Add(this.Check_0200);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Check_0220
            // 
            resources.ApplyResources(this.Check_0220, "Check_0220");
            this.Check_0220.Name = "Check_0220";
            // 
            // Check_0219
            // 
            resources.ApplyResources(this.Check_0219, "Check_0219");
            this.Check_0219.Name = "Check_0219";
            // 
            // Check_0218
            // 
            resources.ApplyResources(this.Check_0218, "Check_0218");
            this.Check_0218.Name = "Check_0218";
            // 
            // Check_0217
            // 
            resources.ApplyResources(this.Check_0217, "Check_0217");
            this.Check_0217.Name = "Check_0217";
            // 
            // Check_0216
            // 
            resources.ApplyResources(this.Check_0216, "Check_0216");
            this.Check_0216.Name = "Check_0216";
            // 
            // Check_0215
            // 
            resources.ApplyResources(this.Check_0215, "Check_0215");
            this.Check_0215.Name = "Check_0215";
            // 
            // Check_0214
            // 
            resources.ApplyResources(this.Check_0214, "Check_0214");
            this.Check_0214.Name = "Check_0214";
            // 
            // Check_0213
            // 
            resources.ApplyResources(this.Check_0213, "Check_0213");
            this.Check_0213.Name = "Check_0213";
            // 
            // Check_0212
            // 
            resources.ApplyResources(this.Check_0212, "Check_0212");
            this.Check_0212.Name = "Check_0212";
            // 
            // Check_0211
            // 
            resources.ApplyResources(this.Check_0211, "Check_0211");
            this.Check_0211.Name = "Check_0211";
            // 
            // Check_0210
            // 
            resources.ApplyResources(this.Check_0210, "Check_0210");
            this.Check_0210.Name = "Check_0210";
            // 
            // Check_0209
            // 
            resources.ApplyResources(this.Check_0209, "Check_0209");
            this.Check_0209.Name = "Check_0209";
            // 
            // Check_0208
            // 
            resources.ApplyResources(this.Check_0208, "Check_0208");
            this.Check_0208.Name = "Check_0208";
            // 
            // Check_0207
            // 
            resources.ApplyResources(this.Check_0207, "Check_0207");
            this.Check_0207.Name = "Check_0207";
            // 
            // Check_0206
            // 
            resources.ApplyResources(this.Check_0206, "Check_0206");
            this.Check_0206.Name = "Check_0206";
            // 
            // Check_0205
            // 
            resources.ApplyResources(this.Check_0205, "Check_0205");
            this.Check_0205.Name = "Check_0205";
            // 
            // Check_0204
            // 
            resources.ApplyResources(this.Check_0204, "Check_0204");
            this.Check_0204.Name = "Check_0204";
            // 
            // Check_0203
            // 
            resources.ApplyResources(this.Check_0203, "Check_0203");
            this.Check_0203.Name = "Check_0203";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Name = "label22";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // Check_0202
            // 
            resources.ApplyResources(this.Check_0202, "Check_0202");
            this.Check_0202.Name = "Check_0202";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Check_0201
            // 
            resources.ApplyResources(this.Check_0201, "Check_0201");
            this.Check_0201.Name = "Check_0201";
            // 
            // Check_0200
            // 
            resources.ApplyResources(this.Check_0200, "Check_0200");
            this.Check_0200.Name = "Check_0200";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Check_0325);
            this.tabPage2.Controls.Add(this.Check_0324);
            this.tabPage2.Controls.Add(this.Check_0323);
            this.tabPage2.Controls.Add(this.Check_0322);
            this.tabPage2.Controls.Add(this.Check_0321);
            this.tabPage2.Controls.Add(this.Check_0320);
            this.tabPage2.Controls.Add(this.Check_0319);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.label52);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.label50);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.Check_0314);
            this.tabPage2.Controls.Add(this.Check_0313);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.label45);
            this.tabPage2.Controls.Add(this.Check_0318);
            this.tabPage2.Controls.Add(this.Check_0317);
            this.tabPage2.Controls.Add(this.Check_0316);
            this.tabPage2.Controls.Add(this.Check_0315);
            this.tabPage2.Controls.Add(this.Check_0312);
            this.tabPage2.Controls.Add(this.Check_0311);
            this.tabPage2.Controls.Add(this.Check_0310);
            this.tabPage2.Controls.Add(this.Check_0309);
            this.tabPage2.Controls.Add(this.Check_0308);
            this.tabPage2.Controls.Add(this.Check_0307);
            this.tabPage2.Controls.Add(this.Check_0306);
            this.tabPage2.Controls.Add(this.Check_0305);
            this.tabPage2.Controls.Add(this.Check_0304);
            this.tabPage2.Controls.Add(this.Check_0303);
            this.tabPage2.Controls.Add(this.label44);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.label42);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.Check_0302);
            this.tabPage2.Controls.Add(this.Check_0301);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.Check_0300);
            this.tabPage2.Controls.Add(this.label28);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Check_0325
            // 
            resources.ApplyResources(this.Check_0325, "Check_0325");
            this.Check_0325.Name = "Check_0325";
            // 
            // Check_0324
            // 
            resources.ApplyResources(this.Check_0324, "Check_0324");
            this.Check_0324.Name = "Check_0324";
            // 
            // Check_0323
            // 
            resources.ApplyResources(this.Check_0323, "Check_0323");
            this.Check_0323.Name = "Check_0323";
            // 
            // Check_0322
            // 
            resources.ApplyResources(this.Check_0322, "Check_0322");
            this.Check_0322.Name = "Check_0322";
            // 
            // Check_0321
            // 
            resources.ApplyResources(this.Check_0321, "Check_0321");
            this.Check_0321.Name = "Check_0321";
            // 
            // Check_0320
            // 
            resources.ApplyResources(this.Check_0320, "Check_0320");
            this.Check_0320.Name = "Check_0320";
            // 
            // Check_0319
            // 
            resources.ApplyResources(this.Check_0319, "Check_0319");
            this.Check_0319.Name = "Check_0319";
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.Name = "label53";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.Name = "label52";
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.Name = "label51";
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // Check_0314
            // 
            resources.ApplyResources(this.Check_0314, "Check_0314");
            this.Check_0314.Name = "Check_0314";
            // 
            // Check_0313
            // 
            resources.ApplyResources(this.Check_0313, "Check_0313");
            this.Check_0313.Name = "Check_0313";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // Check_0318
            // 
            resources.ApplyResources(this.Check_0318, "Check_0318");
            this.Check_0318.Name = "Check_0318";
            // 
            // Check_0317
            // 
            resources.ApplyResources(this.Check_0317, "Check_0317");
            this.Check_0317.Name = "Check_0317";
            // 
            // Check_0316
            // 
            resources.ApplyResources(this.Check_0316, "Check_0316");
            this.Check_0316.Name = "Check_0316";
            // 
            // Check_0315
            // 
            resources.ApplyResources(this.Check_0315, "Check_0315");
            this.Check_0315.Name = "Check_0315";
            // 
            // Check_0312
            // 
            resources.ApplyResources(this.Check_0312, "Check_0312");
            this.Check_0312.Name = "Check_0312";
            // 
            // Check_0311
            // 
            resources.ApplyResources(this.Check_0311, "Check_0311");
            this.Check_0311.Name = "Check_0311";
            // 
            // Check_0310
            // 
            resources.ApplyResources(this.Check_0310, "Check_0310");
            this.Check_0310.Name = "Check_0310";
            // 
            // Check_0309
            // 
            resources.ApplyResources(this.Check_0309, "Check_0309");
            this.Check_0309.Name = "Check_0309";
            // 
            // Check_0308
            // 
            resources.ApplyResources(this.Check_0308, "Check_0308");
            this.Check_0308.Name = "Check_0308";
            // 
            // Check_0307
            // 
            resources.ApplyResources(this.Check_0307, "Check_0307");
            this.Check_0307.Name = "Check_0307";
            // 
            // Check_0306
            // 
            resources.ApplyResources(this.Check_0306, "Check_0306");
            this.Check_0306.Name = "Check_0306";
            // 
            // Check_0305
            // 
            resources.ApplyResources(this.Check_0305, "Check_0305");
            this.Check_0305.Name = "Check_0305";
            // 
            // Check_0304
            // 
            resources.ApplyResources(this.Check_0304, "Check_0304");
            this.Check_0304.Name = "Check_0304";
            // 
            // Check_0303
            // 
            resources.ApplyResources(this.Check_0303, "Check_0303");
            this.Check_0303.Name = "Check_0303";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // Check_0302
            // 
            resources.ApplyResources(this.Check_0302, "Check_0302");
            this.Check_0302.Name = "Check_0302";
            // 
            // Check_0301
            // 
            resources.ApplyResources(this.Check_0301, "Check_0301");
            this.Check_0301.Name = "Check_0301";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // Check_0300
            // 
            resources.ApplyResources(this.Check_0300, "Check_0300");
            this.Check_0300.Name = "Check_0300";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Check_0405);
            this.tabPage3.Controls.Add(this.Check_0404);
            this.tabPage3.Controls.Add(this.Check_0403);
            this.tabPage3.Controls.Add(this.Check_0402);
            this.tabPage3.Controls.Add(this.Check_0401);
            this.tabPage3.Controls.Add(this.Check_0400);
            this.tabPage3.Controls.Add(this.label59);
            this.tabPage3.Controls.Add(this.label58);
            this.tabPage3.Controls.Add(this.label57);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.label55);
            this.tabPage3.Controls.Add(this.label54);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Check_0405
            // 
            resources.ApplyResources(this.Check_0405, "Check_0405");
            this.Check_0405.Name = "Check_0405";
            // 
            // Check_0404
            // 
            resources.ApplyResources(this.Check_0404, "Check_0404");
            this.Check_0404.Name = "Check_0404";
            // 
            // Check_0403
            // 
            resources.ApplyResources(this.Check_0403, "Check_0403");
            this.Check_0403.Name = "Check_0403";
            // 
            // Check_0402
            // 
            resources.ApplyResources(this.Check_0402, "Check_0402");
            this.Check_0402.Name = "Check_0402";
            // 
            // Check_0401
            // 
            resources.ApplyResources(this.Check_0401, "Check_0401");
            this.Check_0401.Name = "Check_0401";
            // 
            // Check_0400
            // 
            resources.ApplyResources(this.Check_0400, "Check_0400");
            this.Check_0400.Name = "Check_0400";
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.Name = "label59";
            // 
            // label58
            // 
            resources.ApplyResources(this.label58, "label58");
            this.label58.Name = "label58";
            // 
            // label57
            // 
            resources.ApplyResources(this.label57, "label57");
            this.label57.Name = "label57";
            // 
            // label56
            // 
            resources.ApplyResources(this.label56, "label56");
            this.label56.Name = "label56";
            // 
            // label55
            // 
            resources.ApplyResources(this.label55, "label55");
            this.label55.Name = "label55";
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.Name = "label54";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.Button btnCheckCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.ComboBox cbxParitv;
        private System.Windows.Forms.ComboBox cbxDevAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCleanData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxSendData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxRecvData;
        private System.Windows.Forms.CheckBox ckbLiveData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Check_0217;
        private System.Windows.Forms.Label Check_0216;
        private System.Windows.Forms.Label Check_0215;
        private System.Windows.Forms.Label Check_0214;
        private System.Windows.Forms.Label Check_0213;
        private System.Windows.Forms.Label Check_0212;
        private System.Windows.Forms.Label Check_0211;
        private System.Windows.Forms.Label Check_0210;
        private System.Windows.Forms.Label Check_0209;
        private System.Windows.Forms.Label Check_0208;
        private System.Windows.Forms.Label Check_0207;
        private System.Windows.Forms.Label Check_0206;
        private System.Windows.Forms.Label Check_0205;
        private System.Windows.Forms.Label Check_0204;
        private System.Windows.Forms.Label Check_0203;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Check_0202;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Check_0201;
        private System.Windows.Forms.Label Check_0200;
        private System.Windows.Forms.Label Check_0220;
        private System.Windows.Forms.Label Check_0219;
        private System.Windows.Forms.Label Check_0218;
        private System.Windows.Forms.Label Check_0310;
        private System.Windows.Forms.Label Check_0309;
        private System.Windows.Forms.Label Check_0308;
        private System.Windows.Forms.Label Check_0307;
        private System.Windows.Forms.Label Check_0306;
        private System.Windows.Forms.Label Check_0305;
        private System.Windows.Forms.Label Check_0304;
        private System.Windows.Forms.Label Check_0303;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label Check_0302;
        private System.Windows.Forms.Label Check_0301;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label Check_0300;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label Check_0318;
        private System.Windows.Forms.Label Check_0317;
        private System.Windows.Forms.Label Check_0316;
        private System.Windows.Forms.Label Check_0315;
        private System.Windows.Forms.Label Check_0312;
        private System.Windows.Forms.Label Check_0311;
        private System.Windows.Forms.Label Check_0325;
        private System.Windows.Forms.Label Check_0324;
        private System.Windows.Forms.Label Check_0323;
        private System.Windows.Forms.Label Check_0322;
        private System.Windows.Forms.Label Check_0321;
        private System.Windows.Forms.Label Check_0320;
        private System.Windows.Forms.Label Check_0319;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label Check_0314;
        private System.Windows.Forms.Label Check_0313;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label Check_0405;
        private System.Windows.Forms.Label Check_0404;
        private System.Windows.Forms.Label Check_0403;
        private System.Windows.Forms.Label Check_0402;
        private System.Windows.Forms.Label Check_0401;
        private System.Windows.Forms.Label Check_0400;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
    }
}

