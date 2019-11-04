using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus
{
    public partial class Form1 : Form
    {
        #region MB_FUNCTION_CODE
        Byte MB_READ_DISCRETE  = 0x02;          //读离散输入寄存器
        Byte MB_READ_HOLD_REG  = 0x03;          //读保持寄存器
        Byte MB_READ_INPUT_REG = 0x04;          //读输入寄存器
        #endregion

        #region MB_FUNCTION_CODE_ADDBTE
        Byte[] MB_READ_DISCRETE_ADDBTE  = { 0x00, 0x00, 0x00, 0x15 };          //读离散输入寄存器起始结束地址
        Byte[] MB_READ_HOLD_REG_ADDBTE  = { 0x00, 0x00, 0x00, 0x1A };          //读保持寄存器起始结束地址
        Byte[] MB_READ_INPUT_REG_ADDBTE = { 0x00, 0x00, 0x00, 0x06 };          //读输入寄存器起始结束地址
        #endregion

        SerialPort sp = null;           //声明串口类
        bool isOpen = false;            //打开串口标志
        bool isLive = false;            //实时数据标志
        bool isSetProperty = false;     //属性设置标志
        Byte devAddr;                   //设备地址类
        Byte funCode;                   //功能码类
        Byte[] addrBtE = new Byte[4];   //起始结束地址类
        Byte[] crcCode = new Byte[2];   //CRC校验码类
        Byte ucCRCHi = 0xFF;
        Byte ucCRCLo = 0xFF;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            for (int i = 0; i < 10; i++)
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            }
        }

        private void BtnCheckCOM_Click(object sender, EventArgs e)
        {
            bool comExistence = false;  //是否有可用的串口
            cbxCOMPort.Items.Clear();   //清除当前串口号中的所有串口名称
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0;//使ListBox显示第一个添加的索引
            }
            else
            {
                MessageBox.Show("没有找到可用串口！", "错误提示");
            }
        }

        private void BtnCleanData_Click(object sender, EventArgs e)
        {
            tbxRecvData.Text = "";
            tbxSendData.Text = "";
        }

        private bool CheckPortSetting()     //串口是否设置
        {
            if (cbxCOMPort.Text.Trim() == "") return false;
            if (cbxBaudRate.Text.Trim() == "") return false;
            if (cbxDataBits.Text.Trim() == "") return false;
            if (cbxParitv.Text.Trim() == "") return false;
            if (cbxStopBits.Text.Trim() == "") return false;
            return true;
        }

        private void SetPortProPerty()      //设置串口属性
        {
            sp = new SerialPort();

            sp.PortName = cbxCOMPort.Text.Trim();       //串口名

            sp.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());//波特率

            float f = Convert.ToSingle(cbxStopBits.Text.Trim());//停止位
            if (f == 0)
            {
                sp.StopBits = StopBits.None;
            }
            else if (f == 1)
            {
                sp.StopBits = StopBits.One;
            }
            else if (f == 2)
            {
                sp.StopBits = StopBits.Two;
            }
            else
            {
                sp.StopBits = StopBits.One;
            }

            sp.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim());//数据位

            string s = cbxParitv.Text.Trim();       //校验位
            if (s.CompareTo("无") == 0)
            {
                sp.Parity = Parity.None;
            }
            else if (s.CompareTo("奇校验") == 0)
            {
                sp.Parity = Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }

            sp.ReadTimeout = -1;         //设置超时读取时间
            sp.RtsEnable = true;

            /*
            //定义DataReceived事件，当串口收到数据后触发事件
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

            void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
            {
                System.Threading.Thread.Sleep(1000);     //延时100ms等待接收数据

                //this.Invoke  跨线程访问ui的方法
                this.Invoke((EventHandler)(delegate
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];
                    sp.Read(ReceivedData, 0, ReceivedData.Length);
                    String RecvDataText = null;
                    for (int i = 0; i < ReceivedData.Length; i++)
                    {
                        RecvDataText += (ReceivedData[i].ToString("X2") + " ");
                    }
                    tbxRecvData.Text += RecvDataText;
                    sp.DiscardInBuffer();       //丢弃接收缓冲区数据
                }));
            }
            */
        }

        private bool CheckSendData()
        {
            if (tbxSendData.Text.Trim() == "") return false;
            return true;
        }

        private bool CheckData(char flag)
        {
            if (flag == '1')
            {
                return true;
            }
            return false;
        }

        private void LiveDataReceived()
        {
            System.Threading.Thread.Sleep(100);     //延时100ms等待接收数据

            //this.Invoke  跨线程访问ui的方法
            this.Invoke((EventHandler)(delegate
            {
                Byte[] ReceivedData = new Byte[sp.BytesToRead];
                sp.Read(ReceivedData, 0, ReceivedData.Length);
                /*
                String RecvDataText = null;
                for (int i = 0; i < ReceivedData.Length; i++)
                {
                    RecvDataText += ReceivedData[i].ToString("X2");
                }
                */
                sp.DiscardInBuffer();       //丢弃接收缓冲区数据
            }));
        }

        private void BtnOpenCom_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())        //检测串口设置
                {
                    MessageBox.Show("串口未设置！", "错误提示");
                    return;
                }
                if (!isSetProperty)             //串口未设置则设置串口
                {
                    SetPortProPerty();
                    isSetProperty = true;
                }
                try
                {
                    sp.Open();
                    isOpen = true;
                    btnOpenCom.Text = "关闭串口";
                    //串口打开后则相关串口设置按钮便不可再用
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxParitv.Enabled = false;
                    cbxStopBits.Enabled = false;
                }
                catch (Exception)
                {
                    //打开串口失败后，相应标志位取消
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用！", "错误提示");
                }
            }
            else
            {
                try       //关闭串口       
                {
                    sp.Close();
                    isOpen = false;
                    btnOpenCom.Text = "打开串口";
                    //关闭串口后，串口设置选项可以继续使用
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxParitv.Enabled = true;
                    cbxStopBits.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误！", "错误提示");
                }
            }
            if (isLive)
            {
                ckbLiveData.Checked = false;
            }
        }

        private void InitCrc() {
            ucCRCHi = 0xFF;
            ucCRCLo = 0xFF;
        }

        #region
        private static readonly Byte[] aucCRCHi = {
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
             0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
             0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
             0x00, 0xC1, 0x81, 0x40
         };
        private static readonly Byte[] aucCRCLo = {
             0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2, 0xC6, 0x06, 0x07, 0xC7,
             0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD, 0x0F, 0xCF, 0xCE, 0x0E,
             0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09, 0x08, 0xC8, 0xD8, 0x18, 0x19, 0xD9,
             0x1B, 0xDB, 0xDA, 0x1A, 0x1E, 0xDE, 0xDF, 0x1F, 0xDD, 0x1D, 0x1C, 0xDC,
             0x14, 0xD4, 0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6, 0xD2, 0x12, 0x13, 0xD3,
             0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1, 0x33, 0xF3, 0xF2, 0x32,
             0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4, 0x3C, 0xFC, 0xFD, 0x3D,
             0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A, 0x3B, 0xFB, 0x39, 0xF9, 0xF8, 0x38,
             0x28, 0xE8, 0xE9, 0x29, 0xEB, 0x2B, 0x2A, 0xEA, 0xEE, 0x2E, 0x2F, 0xEF,
             0x2D, 0xED, 0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5, 0x27, 0xE7, 0xE6, 0x26,
             0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0, 0xA0, 0x60, 0x61, 0xA1,
             0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67, 0xA5, 0x65, 0x64, 0xA4,
             0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F, 0x6E, 0xAE, 0xAA, 0x6A, 0x6B, 0xAB,
             0x69, 0xA9, 0xA8, 0x68, 0x78, 0xB8, 0xB9, 0x79, 0xBB, 0x7B, 0x7A, 0xBA,
             0xBE, 0x7E, 0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C, 0xB4, 0x74, 0x75, 0xB5,
             0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73, 0xB1, 0x71, 0x70, 0xB0,
             0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92, 0x96, 0x56, 0x57, 0x97,
             0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C, 0x5D, 0x9D, 0x5F, 0x9F, 0x9E, 0x5E,
             0x5A, 0x9A, 0x9B, 0x5B, 0x99, 0x59, 0x58, 0x98, 0x88, 0x48, 0x49, 0x89,
             0x4B, 0x8B, 0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F, 0x8D, 0x4D, 0x4C, 0x8C,
             0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86, 0x82, 0x42, 0x43, 0x83,
             0x41, 0x81, 0x80, 0x40
         };
        #endregion

        private void CrcCalc(Byte cmd_Addr, Byte cmd_Code, Byte[] cmd_BtE)
        {
            int usLen = 6, i = 0;
            UInt16 iIndex = 0x0000;
            Byte[] pucFrame = { cmd_Addr, cmd_Code, cmd_BtE[0], cmd_BtE[1], cmd_BtE[2], cmd_BtE[3] };

            InitCrc();
            while (usLen-- > 0)
            {
                iIndex = (UInt16)(ucCRCLo ^ pucFrame[i++]);
                ucCRCLo = (Byte)(ucCRCHi ^ aucCRCHi[iIndex]);
                ucCRCHi = aucCRCLo[iIndex];
            }
        }

        private void LiveDataProc(int fnCode)
        {
            if (fnCode == 2)
            {
                System.Threading.Thread.Sleep(100);     //延时100ms等待接收数据

                //this.Invoke  跨线程访问ui的方法
                this.Invoke((EventHandler)(delegate
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];
                    sp.Read(ReceivedData, 0, ReceivedData.Length);
                    sp.DiscardInBuffer();       //丢弃接收缓冲区数据

                    String tempStr = null;
                    String tempStatCode = null;
                    for (int i = 3; i < ReceivedData.Length - 2; i++)
                    {
                        tempStr = null;
                        tempStr +=  (Convert.ToString(ReceivedData[i], 2).PadLeft(8, '0'));
                        char[] tempArr = tempStr.ToCharArray();
                        Array.Reverse(tempArr);
                        tempStatCode = String.Concat(tempStatCode, new String(tempArr));
                    }
                    char[] StatCode = tempStatCode.ToCharArray();
                    /*
                    Array.Reverse(StatCode);
                    for (int i = 0; i < StatCode.Length - 3; i++)
                    {
                        tbxRecvData.Text += StatCode[i];
                    }
                    */
                    Check_0200.Text = StatCode[0].ToString();
                    Check_0201.Text = StatCode[1].ToString();
                    Check_0202.Text = StatCode[2].ToString();
                    Check_0203.Text = StatCode[3].ToString();
                    Check_0204.Text = StatCode[4].ToString();
                    Check_0205.Text = StatCode[5].ToString();
                    Check_0206.Text = StatCode[6].ToString();
                    Check_0207.Text = StatCode[7].ToString();
                    Check_0208.Text = StatCode[8].ToString();
                    Check_0209.Text = StatCode[9].ToString();
                    Check_0210.Text = StatCode[10].ToString();
                    Check_0211.Text = StatCode[11].ToString();
                    Check_0212.Text = StatCode[12].ToString();
                    Check_0213.Text = StatCode[13].ToString();
                    Check_0214.Text = StatCode[14].ToString();
                    Check_0215.Text = StatCode[15].ToString();
                    Check_0216.Text = StatCode[16].ToString();
                    Check_0217.Text = StatCode[17].ToString();
                    Check_0218.Text = StatCode[18].ToString();
                    Check_0219.Text = StatCode[19].ToString();
                    Check_0220.Text = StatCode[20].ToString();
                }));
            }

            if (fnCode == 3)
            {
                System.Threading.Thread.Sleep(150);     //延时150ms等待接收数据

                //this.Invoke  跨线程访问ui的方法
                this.Invoke((EventHandler)(delegate
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];
                    sp.Read(ReceivedData, 0, ReceivedData.Length);
                    sp.DiscardInBuffer();       //丢弃接收缓冲区数据
                    
                    short[] tempLiveData_03 = new short[(ReceivedData.Length - 5) / 2];
                    for (int i = 0, j = 3; j < ReceivedData.Length - 2; i++, j+=2)
                    {
                        tempLiveData_03[i] = 0;
                        tempLiveData_03[i] = (short)(tempLiveData_03[i] ^ ReceivedData[j]);
                        tempLiveData_03[i] = (short)(tempLiveData_03[i] << 8);
                        tempLiveData_03[i] = (short)(tempLiveData_03[i] ^ ReceivedData[j + 1]);
                    }
                    double[] LiveData_03 = new double[tempLiveData_03.Length];
                    for (int i = 0; i < 3; i++)
                    {
                        LiveData_03[i] = (double)tempLiveData_03[i] / 10.0;
                    }
                    for (int i = 3; i < 5; i++)
                    {
                        LiveData_03[i] = (double)tempLiveData_03[i];
                    }
                    for (int i = 5; i < 13; i++)
                    {
                        LiveData_03[i] = (double)tempLiveData_03[i] / 10.0;
                    }
                    for (int i = 13; i < tempLiveData_03.Length; i++)
                    {
                        LiveData_03[i] = (double)tempLiveData_03[i];
                    }
                    /*
                    for (int i = 0; i < LiveData_03.Length; i++)
                    {
                        tbxRecvData.Text += (LiveData_03[i] + " ");
                    }
                    for (int i = 0; i < LiveData_03.Length; i++)
                    {
                        tbxRecvData.Text += (tempLiveData_03[i] + " ");
                    }
                    for (int i = 0; i < ReceivedData.Length; i++)
                    {
                        tbxRecvData.Text += (ReceivedData[i].ToString("X2") + " ");
                    }
                    */
                    Check_0300.Text = LiveData_03[0] + "%";
                    Check_0301.Text = LiveData_03[1] + "℃";
                    Check_0302.Text = LiveData_03[2] + "℃";
                    Check_0303.Text = LiveData_03[3] + "mm";
                    Check_0304.Text = LiveData_03[4] + "mm";
                    Check_0305.Text = LiveData_03[5] + "%";
                    Check_0306.Text = LiveData_03[6] + "%";
                    Check_0307.Text = LiveData_03[7] + "℃";
                    Check_0308.Text = LiveData_03[8] + "℃";
                    Check_0309.Text = LiveData_03[9] + "%";
                    Check_0310.Text = LiveData_03[10] + "%";
                    Check_0311.Text = LiveData_03[11] + "%";
                    Check_0312.Text = LiveData_03[12] + "%";
                    Check_0313.Text = LiveData_03[13] + "mm";
                    Check_0314.Text = LiveData_03[14] + "mm";
                    Check_0315.Text = LiveData_03[15].ToString();
                    Check_0316.Text = LiveData_03[16].ToString();
                    Check_0317.Text = LiveData_03[17].ToString();
                    Check_0318.Text = LiveData_03[18].ToString();
                    Check_0319.Text = LiveData_03[19].ToString();
                    Check_0320.Text = LiveData_03[20].ToString();
                    Check_0321.Text = LiveData_03[21].ToString();
                    Check_0322.Text = LiveData_03[22].ToString();
                    Check_0323.Text = LiveData_03[23].ToString();
                    Check_0324.Text = LiveData_03[24].ToString();
                    Check_0325.Text = LiveData_03[25].ToString();

                }));
            }

            if (fnCode == 4)
            {
                System.Threading.Thread.Sleep(150);     //延时150ms等待接收数据

                //this.Invoke  跨线程访问ui的方法
                this.Invoke((EventHandler)(delegate
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];
                    sp.Read(ReceivedData, 0, ReceivedData.Length);
                    sp.DiscardInBuffer();       //丢弃接收缓冲区数据

                    short[] tempLiveData_04 = new short[(ReceivedData.Length - 5) / 2];
                    for (int i = 0, j = 3; j < ReceivedData.Length - 2; i++, j += 2)
                    {
                        tempLiveData_04[i] = 0;
                        tempLiveData_04[i] = (short)(tempLiveData_04[i] ^ ReceivedData[j]);
                        tempLiveData_04[i] = (short)(tempLiveData_04[i] << 8);
                        tempLiveData_04[i] = (short)(tempLiveData_04[i] ^ ReceivedData[j + 1]);
                    }
                    double[] LiveData_04 = new double[tempLiveData_04.Length];
                    LiveData_04[0] = (double)tempLiveData_04[0];
                    LiveData_04[tempLiveData_04.Length - 1] = (double)tempLiveData_04[tempLiveData_04.Length - 1];
                    for (int i = 1; i < tempLiveData_04.Length - 1; i++)
                    {
                        LiveData_04[i] = (double)tempLiveData_04[i] / 10.0;
                    }
                    /*                    
                    for (int i = 0; i < LiveData_04.Length; i++)
                    {
                        tbxRecvData.Text += (LiveData_04[i] + " ");
                    }
                    for (int i = 0; i < LiveData_03.Length; i++)
                    {
                        tbxRecvData.Text += (tempLiveData_03[i] + " ");
                    }
                    for (int i = 0; i < ReceivedData.Length; i++)
                    {
                        tbxRecvData.Text += (ReceivedData[i].ToString("X2") + " ");
                    }
                    */
                    if (LiveData_04[0] < 0)
                    {
                        Check_0400.Text = "无信号";
                    }
                    else
                    {
                        Check_0400.Text = LiveData_04[0].ToString();
                    }
                    Check_0401.Text = LiveData_04[1] + "%";
                    Check_0402.Text = LiveData_04[2] + "%";
                    Check_0403.Text = LiveData_04[3] + "℃";
                    Check_0404.Text = LiveData_04[4] + "%";
                    Check_0405.Text = LiveData_04[5] + "mm";
                }));
            }
        }

        private void LiveSendCmd_02 ()
        {
            devAddr = Convert.ToByte(cbxDevAdd.Text.Trim());
            funCode = MB_READ_DISCRETE;
            for (int i = 0; i < 4; i++)
            {
                addrBtE[i] = MB_READ_DISCRETE_ADDBTE[i];
            }
            CrcCalc(devAddr, funCode, addrBtE);
            Byte[] sendCmd_0x02 = { devAddr, funCode, addrBtE[0], addrBtE[1], addrBtE[2], addrBtE[3], ucCRCLo, ucCRCHi };
            sp.Write(sendCmd_0x02.ToArray(), 0, 8);
            //LiveDataReceived();
            LiveDataProc(2);
            /*
            funCode = MB_READ_HOLD_REG;
            for (int i = 0; i < 4; i++)
            {
                addrBtE[i] = MB_READ_HOLD_REG_ADDBTE[i];
            }
            CrcCalc(devAddr, funCode, addrBtE);
            Byte[] sendCmd_0x03 = { devAddr, funCode, addrBtE[0], addrBtE[1], addrBtE[2], addrBtE[3], ucCRCLo, ucCRCHi };
            //sp.Write(sendCmd_0x03.ToArray(), 0, 8);
            // LiveDataReceived();

            funCode = MB_READ_INPUT_REG;
            for (int i = 0; i < 4; i++)
            {
                addrBtE[i] = MB_READ_INPUT_REG_ADDBTE[i];
            }
            CrcCalc(devAddr, funCode, addrBtE);
            Byte[] sendCmd_0x04 = { devAddr, funCode, addrBtE[0], addrBtE[1], addrBtE[2], addrBtE[3], ucCRCLo, ucCRCHi };
            //sp.Write(sendCmd_0x04.ToArray(), 0, 8);
            //LiveDataReceived();
            */
        }

        private void LiveSendCmd_03()
        {
            devAddr = Convert.ToByte(cbxDevAdd.Text.Trim());
            funCode = MB_READ_HOLD_REG;
            for (int i = 0; i < 4; i++)
            {
                addrBtE[i] = MB_READ_HOLD_REG_ADDBTE[i];
            }
            CrcCalc(devAddr, funCode, addrBtE);
            Byte[] sendCmd_0x03 = { devAddr, funCode, addrBtE[0], addrBtE[1], addrBtE[2], addrBtE[3], ucCRCLo, ucCRCHi };
            sp.Write(sendCmd_0x03.ToArray(), 0, 8);
            // LiveDataReceived();
            LiveDataProc(3);
        }

        private void LiveSendCmd_04()
        {
            devAddr = Convert.ToByte(cbxDevAdd.Text.Trim());
            funCode = MB_READ_INPUT_REG;
            for (int i = 0; i < 4; i++)
            {
                addrBtE[i] = MB_READ_INPUT_REG_ADDBTE[i];
            }
            CrcCalc(devAddr, funCode, addrBtE);
            Byte[] sendCmd_0x04 = { devAddr, funCode, addrBtE[0], addrBtE[1], addrBtE[2], addrBtE[3], ucCRCLo, ucCRCHi };
            //tbxRecvData.Text += sendCmd_0x04.ToString();
            sp.Write(sendCmd_0x04.ToArray(), 0, 8);
            //LiveDataReceived();
            LiveDataProc(4);
        }

        private void CkbLiveData_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLiveData.Checked)
            {
                isLive = true;
                btnSend.Enabled = false;
            }
            else
            {
                isLive = false;
                btnSend.Enabled = true;
            }
            if (isLive)
            {
                if (isOpen)
                {
                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("串口未打开", "错误提示");
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private Byte[] HexStrTobyte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            Byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            return returnBytes;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {
                try
                {
                    Byte[] sendData = HexStrTobyte(tbxSendData.Text.Trim());
                    sp.Write(sendData.ToArray(), 0, sendData.Length);
                }
                catch (Exception)
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误提示");
                return;
            }
            if (!CheckSendData())
            {
                MessageBox.Show("请输入要发送的数据!", "错误提示");
                return;
            }

            System.Threading.Thread.Sleep(1000);     //延时1000ms等待接收数据

            //this.Invoke  跨线程访问ui的方法
            this.Invoke((EventHandler)(delegate
            {
                Byte[] ReceivedData = new Byte[sp.BytesToRead];
                sp.Read(ReceivedData, 0, ReceivedData.Length);
                String RecvDataText = null;
                for (int i = 0; i < ReceivedData.Length; i++)
                {
                    RecvDataText += (ReceivedData[i].ToString("X2") + " ");
                }
                tbxRecvData.Text = "";
                tbxRecvData.Text += RecvDataText;
                sp.DiscardInBuffer();       //丢弃接收缓冲区数据
            }));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LiveSendCmd_04();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LiveSendCmd_02();
            LiveSendCmd_03();
            LiveSendCmd_04();
        }

    }
}
