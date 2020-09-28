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
using System.IO;

namespace Serial_Communication.User_Control
{
    public partial class write : UserControl
    {
        
        public event regbtn Regbtn;
        public event wprebtn Wprebtn;
        public static write wr;
        string savePath1 = Application.StartupPath + @"\PRESET.txt";
        string inname2 = "";
        int insplit1 = 0;
        string incolor1 = "";
        string inevent1 = "";
        string inname3 = "";
        int insplit2 = 0;
        string incolor2 = "";
        string inevent2 = "";
        string[] category = { "회사", "일상" };
        string incategory = "";
        int injoin = 0;
        int inrate = 0;
        MySqlConnection connect1 = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");

        StringBuilder sb = new StringBuilder();
        List<string> namelist = new List<string>();
        List<string> eventlist = new List<string>();
        List<string> joinlist = new List<string>();
        List<string> ratelist = new List<string>();
        List<string> authorlist = new List<string>();
        List<string> categorylist = new List<string>();
        List<string> contentlist = new List<string>();



        MySqlConnection cummunityconnect = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");
        public write()
        {
            InitializeComponent();
        }

        private void ComboBox_Load()
        {
            comboBox1_preset.Items.Clear();
            FileInfo fileInfo = new FileInfo(savePath1);
            if (fileInfo.Exists && System.IO.File.ReadAllText(savePath1).Length != 0)
            {
                //comboBox1_preset.SelectedItem = 1;
                String[] Preset_Data = System.IO.File.ReadAllLines(savePath1);
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
                        comboBox1_preset.Items.Add(teset);
                    }
                    else
                    {
                        comboBox1_preset.Items.Add(preset_1[((Convert.ToInt32(preset_1[0]) * 2) + 1)]);
                    }



                }
                for (int i = 0; i < 2; i++)
                {
                    CB_category.Items.Add(category[i]);
                }
                if (comboBox1_preset.Items.Count > 0)
                {
                    comboBox1_preset.SelectedIndex = 0;
                }
                if (CB_category.Items.Count > 0)
                {
                    CB_category.SelectedIndex = 0;
                }
                //String[] preset_1;
                //preset_1 = Preset_Data[0].Split(' ');
                //MessageBox.Show(preset_1[0]);
            }
        }

        private void preset_1_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(savePath1);
            if (fileInfo.Exists)
            {
                string[] Preset_Data = System.IO.File.ReadAllLines(savePath1);

                string data = Preset_Data[comboBox1_preset.SelectedIndex];
                if (data != null)
                {
                    String[] preset_1;
                    preset_1 = data.Split(' ');
                    insplit1 = Convert.ToInt32(preset_1[0]);
                    for (int k = 1; k < insplit1 + 1; k++)
                    {
                        incolor1 += preset_1[k] + " ";
                    }
                    for (int h = insplit1 + 1; h < insplit1 * 2 + 1; h++)
                    {
                        inevent1 += preset_1[h] + " ";
                    }
                    if (preset_1.Length > ((insplit1) * 2) + 2)
                    {
                        string teset1 = "";
                        int test1 = preset_1.Length - (((insplit1) * 2) + 1);
                        for (int j = 0; j < test1; j++)
                        {

                            teset1 += preset_1[(((insplit1 * 2) + 1) + j)] += " ";

                        }
                        inname2 = teset1;
                        //MessageBox.Show(teset1); 

                    }
                    else
                    {
                        inname2 = preset_1[(insplit1 * 2) + 1];
                    }
                    string t = insplit1.ToString();
                    MessageBox.Show(inname2 + " " + t + " " + incolor1 + " " + inevent1);
                    preset_save();
                    preset_clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            community.comm.flag_set = 0;
            community.comm.page_cehck = 0;
            string sinsplit = insplit2.ToString();
            string inpreset = sinsplit + " " + incolor2 + " " + inevent2 + " " + inname3;
            string[] Preset_Data = System.IO.File.ReadAllLines(savePath1);
            inpreset = Preset_Data[comboBox1_preset.SelectedIndex];
            string insertQuery = "INSERT INTO cummunitytb(title,author,content,preset,joinner,rate,category) VALUES('" + TB_title.Text + "','" + Form3.userid + "','" + TB_context.Text + "','" + inpreset + "','" + injoin + "','" + inrate + "','" + incategory + "')";
            cummunityconnect.Open();
            MySqlCommand cummunitycommand = new MySqlCommand(insertQuery, cummunityconnect);
            try
            {
                if (TB_context.Text != "" && TB_title.Text != "")
                {
                    if (cummunitycommand.ExecuteNonQuery() == 1)
                    {
                        DialogResult result = MessageBox.Show("등록 되었습니다" , "확인", MessageBoxButtons.OK);
                        if(result == DialogResult.OK)
                        {
                            community.comm.write_btn.PerformClick();
                            TB_context.Text = "";
                            TB_title.Text = "";
                            community.comm.panel1.AutoScroll = true;
                            community.comm.Topgroup_true();
                            community.comm.Searchgroup_true();
                            community.comm.Pagegroup_true();
                            Form5.frm5.BtnGroup_true();
                            if (Wprebtn != null)
                                Wprebtn();
                            if (Regbtn != null)
                                Regbtn();

                        }

                    }
                    else
                    {
                        MessageBox.Show("등록에 실패했습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("제목과 내용을 기입하십시오.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cummunityconnect.Close();
        }

        private void comboBox1_preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            preset_1.PerformClick();
        }
        private void preset_clear()
        {
            inname2 = "";
            incolor1 = "";
            insplit1 = 0;
            inevent1 = "";
        }
        private void preset_save()
        {
            inevent2 = inevent1;
            incolor2 = incolor1;
            insplit2 = insplit1;
            inname3 = inname2;
        }

        private void comboBox1_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            incategory = category[CB_category.SelectedIndex];
            //MessageBox.Show(incategory);
        }

        private void TB_context_Load(object sender, EventArgs e)
        {
        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            if (Wprebtn != null)
                Wprebtn();
            TB_context.Text = "";
            TB_title.Text = "";
            community.comm.Searchgroup_true();
            community.comm.Pagegroup_true();
            community.comm.Topgroup_true();
            community.comm.panel1.AutoScroll = true;
            Form5.frm5.write_btn.Visible = true;
            Form5.frm5.search_btn.Visible = true;
        }

        private void write_Load(object sender, EventArgs e)
        {
            wr = this;
            ComboBox_Load();
        }

        private void TB_context_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBLoad()
        {
            namelist.Clear();
            authorlist.Clear();
            ratelist.Clear();
            joinlist.Clear();
            eventlist.Clear();
            contentlist.Clear();
            categorylist.Clear();
            string readon = "select * from cummunitytb order by num desc";
            connect1.Open();
            MySqlCommand command1 = new MySqlCommand(readon, connect1);
            MySqlDataReader rdr = command1.ExecuteReader();
            while (rdr.Read())
            {
                namelist.Add(rdr.GetString("title"));
                eventlist.Add(rdr.GetString("preset"));
                joinlist.Add(rdr.GetString("joinner"));
                ratelist.Add(rdr.GetString("rate"));
                authorlist.Add(rdr.GetString("author"));
                categorylist.Add(rdr.GetString("category"));
                contentlist.Add(rdr.GetString("content"));
            }
        }

        private void TB_title_VisibleChanged(object sender, EventArgs e)
        {
            TB_context.Text = "";
            TB_title.Text = "";
        }

        private void write_Enter(object sender, EventArgs e)
        {
            wr = this;
            ComboBox_Load();
        }
    }
}
