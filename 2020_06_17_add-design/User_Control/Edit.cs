using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.IO;
using Guna.UI.WinForms;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography.X509Certificates;

namespace Serial_Communication.User_Control
{

    public partial class Edit : UserControl
    {
        public Edit()
        {
            InitializeComponent();
            
        }
        
        MySqlConnection con = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
        public Point mMyPoint;
        public static int split_pi = 0;
        static int now_click_btn;
        String preset;
        String preset_make;
        //List<String> Key_Event_name_list = new List<String>();
        List<String> Arrow_Key_Event_name_list = new List<String>();
        List<String> Run_Event_name_list = new List<String>();
        

        private List<GunaAdvenceButton> myButtons = new List<GunaAdvenceButton>();  // 버튼을 담을 리스트 생성
        private List<GunaAdvenceButton> event_Buttons = new List<GunaAdvenceButton>();
        private List<GunaComboBox> Custom_ComboBox = new List<GunaComboBox>();
        List<String> Color_list = new List<String>();
        List<int> Preset_1_Event_list = new List<int>();
        public static Dictionary<int, String> Custom_Event = new Dictionary<int, string>();
        static string savePath = Application.StartupPath + @"\PRESET.txt";

        static public String[] Preset_Data;
        //파일 있는지 확인 있을때(true), 없으면(false)

        static public List<String> data_Event_list = new List<String>();

        private int cntBtn = 0;  // 현재 화면에 동적 생성한 버튼 수 초기화 

        private void Edit_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            const int MARGIN = 10;
            const int WIDTH = 250;

            Graphics graphics = e.Graphics;
            using (Pen ellipsePen = new Pen(Color.Blue))
            {
                ellipsePen.DashPattern = new float[] { 5, 5 };


                Color customColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");//red
                Pen outlinePen = Pens.Black;
                Brush fillBrush = Brushes.GreenYellow;

                fillBrush = new SolidBrush(customColor);

                Rectangle rectangle = new Rectangle(MARGIN + 30, 10, WIDTH, WIDTH);
                if (split_pi != 0)
                {
                    int split_angle = (360 / split_pi);

                    //label1.Text = split_angle.ToString();
                    for (int i = 0; i < split_pi; i++)
                    {

                        try
                        {
                            customColor = System.Drawing.ColorTranslator.FromHtml(Color_list[i]);
                        }
                        catch
                        {
                            customColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        }
                        fillBrush = new SolidBrush(customColor);

                        graphics.DrawEllipse(ellipsePen, rectangle);

                        graphics.FillPie(fillBrush, rectangle, 0 + ((split_angle * -1) * i), (split_angle * -1));

                        graphics.DrawPie(outlinePen, rectangle, 0 + ((split_angle * -1) * i), (split_angle * -1));


                    }

                }
            }
        }
        
        private void delListBtn()
        {
            // 등록된 컨트롤 정보 삭제


            for (int i = 0; i < myButtons.Count; i++)
            {
                this.Controls.Remove(myButtons[i]);
                this.Controls.Remove(event_Buttons[i]);
            }

            // 버튼 리스트에 있는 객체 삭제
            for (int i = 0; i < myButtons.Count; i++)
            {
                myButtons.RemoveAt(i);
                event_Buttons.RemoveAt(i);
            }

            for (int i = 0; i < myButtons.Count; i++)
            {
                // 색 리스트 제거
            }
            myButtons.Clear();
            Custom_ComboBox.Clear();
            Color_list.Clear();
            data_Event_list.Clear();
            cntBtn = 0;
            //Key_Event_name_list.Clear();
            Run_Event_name_list.Clear();


        }

        private void splitbtn_Click(object sender, EventArgs e)
        {
            guna_preset_1_save.Enabled = true;

            /*if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                splitbtn.BackColor = colorDialog1.Color;
            }*/

            split_pi = Convert.ToInt32(guna_pie_split_cb.SelectedItem);
            //MessageBox.Show(split_pi.ToString());


            if (split_pi < 2 || split_pi > 7) // 1보다 작거나 현재와 같은 숫자면 무시하고 돌아감
                return;

            if (cntBtn > 0)  // 현재 존재하는 버튼이 있으면 화면과 리스트에서 삭제함
                delListBtn();
            guna_preset_name.Text = "";
            for (int i = 0; i < split_pi; i++)
            {
                myButtons.Add(new GunaAdvenceButton());
                myButtons[i].Location = new Point(30 + 10, 300 + 25 * i);
                myButtons[i].Name = "myButton" + i.ToString();
                myButtons[i].Text = "Button" + i.ToString();
                //myButtons[i].UseVisualStyleBackColor = true;
                myButtons[i].Tag = i;
                myButtons[i].Text = (i + 1).ToString();
                myButtons[i].Size = new Size(91, 23);
                myButtons[i].BaseColor = System.Drawing.ColorTranslator.FromHtml("#FC9649");
                myButtons[i].OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml("#FC9649");
                // 버튼을 클릭할 때 처리할 이벤트 처리기 등록
                myButtons[i].Click += new EventHandler(btnClick);
                // 생성한 버튼을 화면 컨트롤에 추가해서 보이게 함
                this.Controls.Add(myButtons[i]);
                Color_list.Add("#ffffff");
                event_Buttons.Add(new GunaAdvenceButton());
                event_Buttons[i].Location = new Point(30 + 150, 300 + 25 * i);
                event_Buttons[i].Name = "ComboBox" + i.ToString();
                event_Buttons[i].Tag = i;
                this.Controls.Add(event_Buttons[i]);
                event_Buttons[i].Click += new EventHandler(event_Buttons_click);
                event_Buttons[i].Size = new Size(150, 23);
                event_Buttons[i].Text = "NONE";
                event_Buttons[i].BaseColor = System.Drawing.ColorTranslator.FromHtml("#FC9649");
                event_Buttons[i].OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml("#FC9649");
                try
                {
                    event_Buttons[i].Text = data_Event_list[i];
                }
                catch
                {

                }

            }

            Invalidate();
            cntBtn = split_pi;  // 현재 화면에 새로 생성한 버튼 수를 저장
        }

        void btnClick(object sender, EventArgs e)
        {
            int n;
            GunaAdvenceButton btn = sender as GunaAdvenceButton;  // 현재 버튼 객체
            n = (int)btn.Tag;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color_list[n] = (HexConverter(colorDialog1.Color));
                myButtons[n].BaseColor = (colorDialog1.Color);
                myButtons[n].CheckedBaseColor = (colorDialog1.Color);
                myButtons[n].OnHoverBaseColor = (colorDialog1.Color);
                // btn.Text = HexConverter(colorDialog1.Color);
            }

            //n = (int)btn.Tag;  // 버튼의 태그 번호 (초기값 0)
            //btn.Text = "눌림: " + n.ToString(); // "눌림 " + 버튼 태그 번호를 버튼에 출력
            //btn.Tag = n + 1;   // 버튼 태그 번호 증가

            Invalidate();
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            String rtn = String.Empty;
            try
            {
                rtn = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception ex)
            {
                //doing nothing
            }

            return rtn;
        }

        private void Custom_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n;
            ComboBox cbbox = sender as ComboBox;
            n = (int)cbbox.Tag;
            int sel = Custom_ComboBox[n].SelectedIndex;
            String txt = Custom_ComboBox[n].SelectedValue.ToString();
            contextMenuStrip1.Show();

            if (sel > -1)
            {
                //String msg = String.Format("Selected Index= {0},{1},{2}", sel, Custom_ComboBox[n].Items[sel], txt);
                //MessageBox.Show(msg);
            }
        }

        private void event_Buttons_click(object sender, EventArgs e)
        {

            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            now_click_btn = (int)btn.Tag;
            contextMenuStrip1.Show(Control.MousePosition);
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            try
            {
                DBLoad();
            }
            catch
            {

            }
            Event_menu_list_make();
            guna_pie_split_cb.SelectedIndex = 0;
            //MessageBox.Show(savePath);
            System.Windows.Forms.Label Color_list_label;
            Color_list_label = new System.Windows.Forms.Label();
            Color_list_label.Text = "색깔";
            Color_list_label.Location = new Point(30 + 20, 275);

            this.Controls.Add(Color_list_label);

            System.Windows.Forms.Label Event_list_label;
            Event_list_label = new System.Windows.Forms.Label();
            Event_list_label.Text = "이벤트";
            Event_list_label.Location = new Point(30 + 150, 275);
            this.Controls.Add(Event_list_label);

            //preset_1_save.Enabled = false;
            guna_changebtn.Enabled = false;
            guna_Delbtn.Enabled = false;
            guna_preset_1_save.Enabled = false;

            if (guna_preset_name.Text != "이름")
            {
                guna_preset_name.ForeColor = Color.Black;
            }
            ComboBox_Load();
        }

        private void preset_1_Click(object sender, EventArgs e)
        {
            try
            {
                //preset_1_save.Enabled = true;
                
                FileInfo fileInfo = new FileInfo(savePath);
                if (fileInfo.Exists)
                {
                    guna_changebtn.Enabled = true;
                    guna_Delbtn.Enabled = true;
                    guna_preset_1_save.Enabled = true;
                    delListBtn();

                    string[] Preset_Data = System.IO.File.ReadAllLines(savePath);

                    string data = Preset_Data[guna_comboBox1_preset.SelectedIndex];
                    //MessageBox.Show(data);
                    if (data != null)
                    {
                        String[] preset_1;
                        preset_1 = data.Split(' ');
                        split_pi = Convert.ToInt32(preset_1[0]);


                        preset_1 = data.Split(' ');
                        if (preset_1.Length > ((split_pi) * 2) + 2)
                        {
                            string teset = "";
                            int test = preset_1.Length - (((split_pi) * 2) + 1);
                            for (int j = 0; j < test; j++)
                            {

                                teset += preset_1[(((split_pi * 2) + 1) + j)] += " ";

                            }
                            //MessageBox.Show(teset); 
                            guna_preset_name.Text = (teset);
                        }
                        else
                        {
                            guna_preset_name.Text = preset_1[(split_pi * 2) + 1];
                        }



                        for (int i = 0; i < Convert.ToInt32(preset_1[0]); i++)
                        {
                            Color_list.Add(preset_1[i + 1]);
                            data_Event_list.Add(preset_1[i + 1 + Convert.ToInt32(preset_1[0])]);

                        }

                        //파이 생성
                        for (int i = 0; i < split_pi; i++)
                        {
                            myButtons.Add(new GunaAdvenceButton());
                            myButtons[i].Location = new Point(30 + 10, 300 + 25 * i);
                            myButtons[i].Name = "myButton" + i.ToString();
                            myButtons[i].Size = new Size(75, 23);
                            myButtons[i].Text = "Button" + i.ToString();
                            //myButtons[i].UseVisualStyleBackColor = true;
                            myButtons[i].Tag = i;
                            myButtons[i].Text = (i + 1).ToString();
                            // 버튼을 클릭할 때 처리할 이벤트 처리기 등록
                            myButtons[i].Click += new EventHandler(btnClick);
                            myButtons[i].BaseColor = System.Drawing.ColorTranslator.FromHtml(Color_list[i]);
                            myButtons[i].OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml(Color_list[i]);
                            myButtons[i].CheckedBaseColor = System.Drawing.ColorTranslator.FromHtml(Color_list[i]);
                            myButtons[i].BorderSize = 2;
                            myButtons[i].BorderColor = Color.FromArgb(252, 150, 73);
                            myButtons[i].CheckedBorderColor = Color.FromArgb(252, 150, 73);
                            myButtons[i].OnHoverBorderColor = Color.FromArgb(252, 150, 73);
                            myButtons[i].Image = null;
                            myButtons[i].TextAlign = HorizontalAlignment.Center;
                            // 생성한 버튼을 화면 컨트롤에 추가해서 보이게 함
                            this.Controls.Add(myButtons[i]);

                            event_Buttons.Add(new GunaAdvenceButton());
                            event_Buttons[i].Location = new Point(30 + 150, 300 + 25 * i);
                            event_Buttons[i].Name = "ComboBox" + i.ToString();
                            event_Buttons[i].Size = new Size(150, 23);
                            event_Buttons[i].Tag = i;
                            event_Buttons[i].Image = null;
                            event_Buttons[i].BaseColor = Color.FromArgb(252, 150, 73);
                            event_Buttons[i].CheckedBaseColor = Color.FromArgb(252, 150, 73);
                            event_Buttons[i].OnHoverBaseColor = Color.FromArgb(252, 150, 73);
                            this.Controls.Add(event_Buttons[i]);
                            event_Buttons[i].Click += new EventHandler(event_Buttons_click);
                            //event_Buttons[i].Text = "NULL";
                            try
                            {
                                event_Buttons[i].Text = data_Event_list[i];
                            }
                            catch
                            {

                            }
                            Invalidate();
                        }

                        cntBtn = split_pi;  // 현재 화면에 새로 생성한 버튼 수를 저장
                                            //splitbtn.PerformClick();
                                            //MessageBox.Show(Form1.global_preset);
                    }
                }
            }
            catch
            {

            }
        }

        private void preset_1_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (split_pi != 0)
                {
                    preset = null;
                    string event_preset = null;
                    StringBuilder road_preset = new StringBuilder();
                    string preset_make = null;
                    preset += split_pi.ToString() + " ";
                    for (int i = 0; i < split_pi; i++)
                    {
                        try
                        {
                            preset += Color_list[i] + " ";
                        }
                        catch
                        {
                            preset += "#ffffff ";
                        }

                        try
                        {
                            //Preset_1_Event_list.Add(Custom_ComboBox[i].SelectedIndex);
                            event_preset += event_Buttons[i].Text + " ";
                            //MessageBox.Show(event_preset);

                        }
                        catch
                        {

                        }
                    }
                    preset_make += preset + event_preset;
                    if (guna_preset_name.Text.Equals(""))
                    {
                        preset_make += "이름없음";
                    }
                    else
                    {

                        preset_make += guna_preset_name.Text;
                    }
                    guna_preset_name.Text = "";

                    System.IO.File.AppendAllText(savePath, preset_make += "\n");
                    //MessageBox.Show(road_preset.ToString());

                }
                ComboBox_Load();
                MessageBox.Show("저장되었습니다");
                DBsave();
            }
            catch
            {
                MessageBox.Show("저장을 실패했습니다");
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string[] Preset_Data = System.IO.File.ReadAllLines(savePath);
            try
            {
                Preset_Data = Preset_Data.Where(condition => condition != Preset_Data[guna_comboBox1_preset.SelectedIndex]).ToArray();
                System.IO.File.WriteAllLines(savePath, Preset_Data);
            }
            catch
            {
                System.IO.File.WriteAllText(savePath, "");
            }

            guna_comboBox1_preset.SelectedItem = 0;
            guna_comboBox1_preset.Items.Remove(guna_comboBox1_preset.SelectedIndex);
            ComboBox_Load();
            guna_preset_name.Text = "";
            Invalidate();
            MessageBox.Show("삭제되었습니다");
            DBsave();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Preset_Data = System.IO.File.ReadAllLines(savePath);

                if (split_pi != 0)
                {
                    preset = null;
                    string event_preset = null;
                    StringBuilder road_preset = new StringBuilder();
                    string preset_make = null;
                    preset += split_pi.ToString() + " ";
                    for (int i = 0; i < split_pi; i++)
                    {
                        try
                        {
                            preset += Color_list[i] + " ";
                        }
                        catch
                        {
                            preset += "#ffffff ";
                        }

                        try
                        {
                            // Preset_1_Event_list.Add(Custom_ComboBox[i].SelectedIndex);
                            event_preset += event_Buttons[i].Text + " ";

                        }
                        catch
                        {

                        }
                    }

                    preset_make += preset + event_preset;
                    if (guna_preset_name.Text.Equals(""))
                    {
                        preset_make += "이름없음";
                    }
                    else
                    {
                        preset_make += guna_preset_name.Text;
                    }

                    guna_preset_name.Text = "";
                    //System.IO.File.AppendAllText(savePath, preset_make += "\n", Encoding.Default);
                    //MessageBox.Show(road_preset.ToString());
                    Preset_Data[guna_comboBox1_preset.SelectedIndex] = preset_make;
                    System.IO.File.WriteAllLines(savePath, Preset_Data);

                    MessageBox.Show("변경되었습니다");
                    ComboBox_Load();
                }
                DBsave();
            }
            catch
            {
                MessageBox.Show("프리셋을 선택하세요");
            }
        }

        private void comboBox1_preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna_preset_1.PerformClick();
        }

        private void ComboBox_Load()
        {
            guna_comboBox1_preset.Items.Clear();
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
                        guna_comboBox1_preset.Items.Add(teset);
                    }
                    else
                    {
                        guna_comboBox1_preset.Items.Add(preset_1[((Convert.ToInt32(preset_1[0]) * 2) + 1)]);
                    }



                }
                if (guna_comboBox1_preset.Items.Count > 0)
                {
                    guna_comboBox1_preset.SelectedIndex = 0;
                }
                //String[] preset_1;
                //preset_1 = Preset_Data[0].Split(' ');
                //MessageBox.Show(preset_1[0]);
            }
        }

        private void AddContextMenuChild(List<String> list, ToolStripMenuItem sender)
        {
            int childCount = list.Count;
            System.Windows.Forms.ToolStripMenuItem[] _toolStripMenuItem = null;
            _toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem[childCount];

            //sender.DropDownItems.Clear();

            for (int i = 0; i < childCount; i++)
            {
                _toolStripMenuItem[i] = new ToolStripMenuItem();
                _toolStripMenuItem[i].Name = "toolStripMenuItem" + list[i];
                _toolStripMenuItem[i].Size = new System.Drawing.Size(100, 22);
                _toolStripMenuItem[i].Text = list[i];
                _toolStripMenuItem[i].Click += new EventHandler(_toolStripMenuItem_Click);
                sender.DropDownItems.Add(_toolStripMenuItem[i]);
            }
        }
        private void Event_menu_list_make()
        {
            List<String> Key_Event_name_list = new List<String>();
            //Key_Event_name_list.Add("Send_{ESC}");

            Key_Event_name_list.Add("Send_{LEFT}");
            Key_Event_name_list.Add("Send_{RIGHT}");
            Key_Event_name_list.Add("Send_{UP}");
            Key_Event_name_list.Add("Send_{DOWN}");
            AddContextMenuChild(Key_Event_name_list, ArrowToolStripMenuItem);
            Key_Event_name_list.Clear();
            Key_Event_name_list.Add("Send_{VOLUME_UP}");
            Key_Event_name_list.Add("Send_{VOLUME_DOWN}");
            Key_Event_name_list.Add("Send_{VOLUME_MUTE}");
            AddContextMenuChild(Key_Event_name_list, VolumeToolStripMenuItem);
            Key_Event_name_list.Clear();
            Key_Event_name_list.Add("Send_{F1}");
            Key_Event_name_list.Add("Send_{F2}");
            Key_Event_name_list.Add("Send_{F3}");
            Key_Event_name_list.Add("Send_{F4}");
            Key_Event_name_list.Add("Send_{F5}");
            Key_Event_name_list.Add("Send_{F6}");
            Key_Event_name_list.Add("Send_{F7}");
            Key_Event_name_list.Add("Send_{F8}");
            Key_Event_name_list.Add("Send_{F9}");
            Key_Event_name_list.Add("Send_{F10}");
            Key_Event_name_list.Add("Send_{F11}");
            Key_Event_name_list.Add("Send_{F12}");
            AddContextMenuChild(Key_Event_name_list, FuncToolStripMenuItem);
            //AddContextMenuChild(Key_Event_name_list, keydownToolStripMenuItem);
            Key_Event_name_list.Clear();
            Key_Event_name_list.Add("원하는 내용입력");
            AddContextMenuChild(Key_Event_name_list, keydownToolStripMenuItem);

            Key_Event_name_list.Clear();
            Key_Event_name_list.Add("Send_{ENTER}");
            AddContextMenuChild(Key_Event_name_list, SubkeyToolStripMenuItem);

            Key_Event_name_list.Clear();
            Key_Event_name_list.Add("Run_Notepad.exe");
            Key_Event_name_list.Add("Run_PowerPoint.exe");
            AddContextMenuChild(Key_Event_name_list, RunToolStripMenuItem);
            Key_Event_name_list.Clear();
        }

        private void _toolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*foreach (ToolStripMenuItem item in toolStripMenuItem2.DropDownItems)
            {
                item.Checked = false;
            }
     ((ToolStripMenuItem)sender).Checked = true;*/
            //string s = string.Format("{0}\n{1}", sender.ToString(), e.ToString());
            //MessageBox.Show(s);
            String txt = event_Buttons[now_click_btn].Text;
            String value = "";
            if ((((ToolStripMenuItem)sender).Text.Split('_')[0]) == "Run")
            {
                event_Buttons[now_click_btn].Text = ((ToolStripMenuItem)sender).Text;
            }
            else if ((((ToolStripMenuItem)sender).Text.Split('_')[0]) == "Send")
            {
                event_Buttons[now_click_btn].Text = ((ToolStripMenuItem)sender).Text;
            }
            else if ((((ToolStripMenuItem)sender).Text).Equals("원하는 내용입력"))
            {
                if (Tmp.InputBox("입력", "입력하고 싶은 내용", ref value) == DialogResult.OK)
                {
                    if (value.Split('_')[0].Equals("Send") || value.Split('_')[0].Equals("Rund"))
                    {
                        MessageBox.Show("사용자 입력에서는 이벤트를 사용할 수 없습니다.");
                    }
                    else
                    {
                        if (value.Length > 100)
                        {
                            MessageBox.Show("사용자 입력내용이 너무 많습니다.");
                        }
                        else
                        {
                            event_Buttons[now_click_btn].Text = value;
                        }
                    }
                }

            }
        }

        private void DBsave()
        {
            if (Form3.userlogin == 1)
            {

                string insertQuerydelete = "delete from " + Form3.userid + "tb;";
                con.Open();
                MySqlCommand deletecon = new MySqlCommand(insertQuerydelete, con);
                deletecon.ExecuteNonQuery();
                con.Close();
                FileInfo fileInfo1 = new FileInfo(savePath);
                if (fileInfo1.Exists)
                {
                    // MessageBox.Show("등록됨");
                    string[] Preset_Data1 = System.IO.File.ReadAllLines(savePath);
                    for (int i = 0; i < Preset_Data1.Length; i++)
                    {
                        string inname1 = "";
                        int insplit = 0;
                        string incolor = "";
                        string inevent = "";
                        string preset_data = Preset_Data1[i];
                        if (preset_data != null)
                        {
                            String[] input1;
                            input1 = preset_data.Split(' ');
                            split_pi = Convert.ToInt32(input1[0]);
                            insplit = split_pi;

                            for (int k = 1; k < split_pi + 1; k++)
                            {
                                incolor += input1[k] + " ";
                            }
                            for (int h = split_pi + 1; h < split_pi * 2 + 1; h++)
                            {
                                inevent += input1[h] + " ";
                            }
                            if (input1.Length > ((split_pi) * 2) + 2)
                            {
                                string teset1 = "";
                                int test1 = input1.Length - (((split_pi) * 2) + 1);
                                for (int j = 0; j < test1; j++)
                                {

                                    teset1 += input1[(((split_pi * 2) + 1) + j)] += " ";

                                }
                                inname1 = teset1;
                                //MessageBox.Show(teset1); 

                            }
                            else
                            {
                                inname1 = input1[(split_pi * 2) + 1];
                            }
                        }
                        string insertQuerydata = "INSERT INTO " + Form3.userid + "tb(id,split,color,event,name) VALUES('" + Form3.userid + "','" + insplit + "','" + incolor + "','" + inevent + "','" + inname1 + "')";
                        con.Open();
                        MySqlCommand datacon = new MySqlCommand(insertQuerydata, con);
                        try
                        {
                            datacon.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        con.Close();
                    }
                }
            }
        }
        private void DBLoad()
        {
            //MySqlConnection datareadconnect = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
            List<String> data_list = new List<String>();
            try
            {
                string udr = "select * from " + Form3.userid + "tb";
                //string[] readtext;
                try
                {
                    con.Open();
                }
                catch
                {

                }
                MySqlCommand readcommand = new MySqlCommand(udr, con);
                MySqlDataReader urd = readcommand.ExecuteReader();
                System.IO.File.WriteAllText(savePath, "");
                for (int i = 0; urd.Read(); i++)
                {
                    data_list.Add(urd["split"] + " " + urd["color"] + " " + urd["event"] + " " + urd["name"]);
                    System.IO.File.AppendAllText(savePath, urd["split"] + " " + urd["color"] + urd["event"] + urd["name"] + "\n");
                }
                con.Close();
            }
            catch
            {

            }
        }

        private void Edit_Enter(object sender, EventArgs e)
        {
            DBLoad();

            ComboBox_Load();

        }

        private void guna_preset_name_Enter(object sender, EventArgs e)
        {
            if (guna_preset_name.Text == "이름")
            {
                guna_preset_name.Text = null;
            }
            guna_preset_name.ForeColor = Color.Black;
            Name_label.Visible = true;
        }

        private void guna_preset_name_Leave(object sender, EventArgs e)
        {
            if (guna_preset_name.Text == "")
            {
                guna_preset_name.Text = "이름";
                guna_preset_name.ForeColor = Color.LightGray;
            }
            
        }
    }
}
