using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  //시리얼통신을 위해 추가해줘야 함
using System.IO;
using AutoIt;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;

namespace Serial_Communication.User_Control
{
    public partial class Connect_Control : UserControl
    {
        public static String global_preset = null;
        public static List<String> Event_list = new List<String>();
        static string savePath = Application.StartupPath + @"\PRESET.txt";
        static int split_pi;
        RegistryKey ckey1 = Registry.CurrentUser.CreateSubKey("C# rkey");
        RegistryKey rkey = Registry.CurrentUser.OpenSubKey("C# rkey").OpenSubKey("infokey", true);
        public Connect_Control()
        {
            InitializeComponent();
            if (rkey != null)
            {
                try
                {
                    Form3.userid = rkey.GetValue("id").ToString();
                    Form3.userpassword = rkey.GetValue("password").ToString();
                    string strlog = rkey.GetValue("log").ToString();
                    Form3.userlogin = int.Parse(strlog);

                    //MessageBox.Show(Form3.userid + " " + strlog);
                }
                catch
                {
                    RegistryKey ckey = Registry.CurrentUser.CreateSubKey("C# rkey").CreateSubKey("infokey");
                }

            }
            else
            {
                RegistryKey ckey = Registry.CurrentUser.CreateSubKey("C# rkey").CreateSubKey("infokey");

            }
        }
        private void Connect_Control_Load(object sender, EventArgs e)  //폼이 로드되면
        {
            richTextBox_received.ScrollToCaret();
            comboBox_port.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 
            //RPI.Text= Convert.ToString(System.IO.Ports.SerialPort.GetPortNames().Where(x => !x.Contains("raspberrypi")).Count());

            FileInfo fileInfo = new FileInfo(savePath);
            if (fileInfo.Exists && System.IO.File.ReadAllText(savePath).Length != 0)
            {
                //comboBox1_preset.SelectedItem = 1;
                ComboBox_Load();
                //String[] preset_1;
                //preset_1 = Preset_Data[0].Split(' ');
                //MessageBox.Show(preset_1[0]);


                //MessageBox.Show(data);

            }
        }
        private void Button_connect_Click(object sender, EventArgs e)  //통신 연결하기 버튼
        {
            if (!serialPort1.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                serialPort1.PortName = comboBox_port.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort1.BaudRate = 9600;  //보레이트 변경이 필요하면 숫자 변경하기
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다

                serialPort1.Open();  //시리얼포트 열기

                label_status.Text = "포트가 열렸습니다.";
                comboBox_port.Enabled = false;  //COM포트설정 콤보박스 비활성화
                richTextBox_received.Text = "";

                // this.WindowState = FormWindowState.Minimized;
                //this.ShowInTaskbar = false;
                /* this.Hide();
                 this.notifyIcon1.Visible = true;
                 notifyIcon1.ContextMenuStrip = contextMenuStrip1;*/
            }
            else  //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived));  //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }

        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            if (serialPort1.BytesToRead > 0)
            {
                try
                {
                    string ReceiveData = serialPort1.ReadExisting();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
                    richTextBox_received.Text = richTextBox_received.Text + ReceiveData;

                    String RCVData = ReceiveData;
                    //String RCVData;
                    //RCVData = serialPort1.ReadExisting();
                    //SendKeys.Send(RCVData.ToString());
                    String[] Preset_Data = System.IO.File.ReadAllLines(savePath);
                    string data = Preset_Data[comboBox_preset.SelectedIndex];

                    String[] Event_lisr_handle = (Event_list[Convert.ToInt32(RCVData)].Split('_'));
                    if (Event_lisr_handle[0] == "Send")
                    {
                        try
                        {
                            AutoItX.Send(Event_list[Convert.ToInt32(RCVData)].Replace("Send_", ""));
                            //richTextBox_received.Text+=Event_list[Convert.ToInt32(RCVData)].Replace("Send_", "");
                        }
                        catch
                        {

                        }
                    }
                    else if (Event_lisr_handle[0] == "Run")
                    {
                        try
                        {
                            AutoItX.Run(Event_list[Convert.ToInt32(RCVData)].Replace("Run_", ""), "");
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        try
                        {
                            AutoItX.Send(Event_list[Convert.ToInt32(RCVData)], 1);
                        }
                        catch
                        {

                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void Button_send_Click(object sender, EventArgs e)  //보내기 버튼을 클릭하면
        {
            serialPort1.Write(textBox_send.Text);  //텍스트박스의 텍스트를 시리얼통신으로 송신
        }

        private void Button_disconnect_Click(object sender, EventArgs e)  //통신 연결끊기 버튼
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                serialPort1.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true;  //COM포트설정 콤보박스 활성화
            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preset_1_Click(object sender, EventArgs e)
        {
            Event_list.Clear();
            global_preset = null;
            List<String> color_list = new List<String>();
            String[] Preset_Data = System.IO.File.ReadAllLines(savePath);
            string data = Preset_Data[comboBox_preset.SelectedIndex];
            if (data != null)
            {
                String[] preset_1;
                preset_1 = data.Split(' ');
                global_preset += preset_1[0] + " ";
                split_pi = Convert.ToInt32(preset_1[0]);
                for (int i = 0; i < Convert.ToInt32(preset_1[0]); i++)
                {

                    global_preset += (preset_1[i + 1]) + " ";

                }
                richTextBox_received.Text += global_preset;
                for (int i = 0; i < Convert.ToInt32(preset_1[0]) + 1; i++)
                {
                    if (preset_1[(i + Convert.ToInt32(preset_1[0]))].Equals("NONE"))
                    {
                        Event_list.Add("");
                    }
                    else
                    {
                        Event_list.Add(preset_1[(i + Convert.ToInt32(preset_1[0]))]);
                    }
                    //MessageBox.Show(preset_1[i + Convert.ToInt32(preset_1[0])]);
                    //richTextBox_received.Text += preset_1[(i + Convert.ToInt32(preset_1[0]))];
                    //Event_list.Add(preset_1[(i + Convert.ToInt32(preset_1[0]))]);
                }

                serialPort1.Write(global_preset);
                //MessageBox.Show(global_preset);
            }
        }


        private void Connect_Control_Enter(object sender, EventArgs e)
        {
            ComboBox_Load();
        }
        private void ComboBox_Load()
        {
            comboBox_preset.Items.Clear();
            FileInfo fileInfo = new FileInfo(savePath);
            if (fileInfo.Exists && System.IO.File.ReadAllText(savePath).Length != 0)
            {
                //comboBox1_preset.SelectedItem = 1;
                String[] Preset_Data = System.IO.File.ReadAllLines(savePath);
                //String data = Preset_Data[0];

                //String[] preset_1;
                //preset_1 = data.Split(' ');


                for (int i = 0; i < Preset_Data.Length; i++)
                {

                    String data = Preset_Data[i];

                    String[] preset_1;
                    preset_1 = data.Split(' ');
                    if (preset_1.Length > (Convert.ToInt32(preset_1[0]) * 2) + 2)
                    {
                        string teset = "";
                        int test = preset_1.Length - ((Convert.ToInt32(preset_1[0]) * 2) + 1);
                        for (int j = 0; j < test; j++)
                        {

                            teset += preset_1[(((Convert.ToInt32(preset_1[0]) * 2) + 1) + j)] += " ";

                        }
                        //MessageBox.Show(teset); 
                        comboBox_preset.Items.Add(teset);
                    }
                    else
                    {
                        comboBox_preset.Items.Add(preset_1[((Convert.ToInt32(preset_1[0]) * 2) + 1)]);
                    }



                }

                if (comboBox_preset.Items.Count > 0)
                {
                    comboBox_preset.SelectedIndex = 0;
                }
                //String[] preset_1;
                //preset_1 = Preset_Data[0].Split(' ');
                //MessageBox.Show(preset_1[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoItX.Send("{VOLUME_DOWN}");
            AutoItX.Run("Notepad.exe", "");
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3.userlogin = 0;
            Form3.userid = "";
            Form3.userpassword = "";
            string strlog = Form3.userlogin.ToString();
            rkey.SetValue("id", "");
            rkey.SetValue("password", "");
            rkey.SetValue("log", strlog);
            MessageBox.Show("로그아웃되었습니다.");
        }
    }
}
