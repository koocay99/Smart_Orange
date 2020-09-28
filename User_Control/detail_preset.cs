using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.ComponentModel.Design;

namespace Serial_Communication.User_Control
{
    public partial class detail_preset : UserControl
    {
        public static detail_preset detail;
        public event prebtn Prebtn;
        string inevent;
        String[] Preset_decoding;
        string userid;
        List<String> Color_list = new List<String>();
        List<string> numlist = new List<string>();
        List<string> userlist = new List<string>();
        List<string> postnumlist = new List<string>();
        List<string> typelist = new List<string>();
        int postnum;
        static string savePath = Application.StartupPath + @"\PRESET.txt";
        MySqlConnection con = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
        MySqlConnection connect1 = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");
        MySqlConnection connect2 = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");
        MySqlConnection connect3 = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");
        MySqlConnection connect4 = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");
        public detail_preset()
        {

            InitializeComponent();
        }
        public string lbnum
        {
            get { return lbNum.Text; }
            set { lbNum.Text = value; }
        }
        public string lbtitle
        {
            get { return lbTitle.Text; }
            set { lbTitle.Text = value; }
        }

        public string lbauthor
        {
            get { return lbAuthor.Text; }
            set { lbAuthor.Text = value; }
        }

        public string lbcategory
        {
            get { return lbCategory.Text; }
            set { lbCategory.Text = value; }
        }

        public string lbjoin
        {
            get { return lbJoin.Text; }
            set { lbJoin.Text = value; }
        }

        public string lbrate
        {
            get { return lbRate.Text; }
            set { lbRate.Text = value; }
        }

        public string tbcontext
        {
            get { return tbContext.Text; }
            set { tbContext.Text = value; }
        }
        public string lbpreset
        {
            get { return lbEvent.Text; }
            set { lbEvent.Text = value; }
        }
        private void Edit_Paint(object sender, PaintEventArgs e)
        {
            Color_list.Clear();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            lbpreset = lbpreset.Replace("preset: ", "");
            Preset_decoding = lbpreset.Split(' ');

            int split_pi = Convert.ToInt32(Preset_decoding[0]);


            const int MARGIN = 10;
            const int WIDTH = 80;

            Graphics graphics = e.Graphics;
            using (Pen ellipsePen = new Pen(Color.Blue))
            {
                ellipsePen.DashPattern = new float[] { 5, 5 };


                Color customColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");//red
                Pen outlinePen = Pens.Black;
                Brush fillBrush = Brushes.GreenYellow;

                fillBrush = new SolidBrush(customColor);

                Rectangle rectangle = new Rectangle(MARGIN + 150, 50, WIDTH, WIDTH);
                if (split_pi != 0)
                {
                    int split_angle = (360 / split_pi);

                    //label1.Text = split_angle.ToString();
                    for (int i = 0; i < split_pi; i++)
                    {
                        Color_list.Add(Preset_decoding[i + 1]);
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

        private void previousbtn_Click(object sender, EventArgs e)
        {
            if (Prebtn != null)
                Prebtn();
            this.Visible = false;
            community.comm.write_btn.PerformClick();
            community.comm.BT_search.Visible = true;
            community.comm.searchlist.Visible = true;
            community.comm.TB_search.Visible = true;
            DBLoad();
        }

        private void detail_preset_Load(object sender, EventArgs e)
        {
            inevent = lbEvent.Text;
            detail = this;
            this.Visible = true;
            userid = Form3.userid;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Form3.userlogin == 1)
            {
                string checkQuery = "select * from recommandtb where user ='" + userid + "' AND " + "postnum = '" + lbnum + "'";
                connect1.Open();
                //MessageBox.Show(checkQuery);
                MySqlCommand Checkcommand = new MySqlCommand(checkQuery, connect1);
                MySqlDataReader chek = Checkcommand.ExecuteReader();
                if (chek.Read())
                {
                    MessageBox.Show("이미 추천을 했습니다.");
                    connect1.Close();
                }
                else
                {
                    connect2.Open();
                    connect3.Open();
                    string insertQuery = "INSERT INTO recommandtb(user, postnum, type) VALUES('" + userid + "','" + lbnum + "','" + 1 + "')";
                    MySqlCommand cummunitycommand = new MySqlCommand(insertQuery, connect2);
                    if (cummunitycommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("추천되었습니다.");
                        insertQuery = "UPDATE cummunitytb set rate = rate + 1 where num = '" + lbnum + "'";
                        MySqlCommand rateupdate = new MySqlCommand(insertQuery, connect2);
                        MySqlDataReader Rate_update = rateupdate.ExecuteReader();
                        insertQuery = "SELECT * FROM cummunitytb where num = '" + lbnum + "'";
                        MySqlCommand update_rate = new MySqlCommand(insertQuery, connect3);
                        MySqlDataReader Update_rate = update_rate.ExecuteReader();
                        if (Update_rate.Read())
                        {
                            lbRate.Text =  Update_rate.GetString("rate");
                        }

                        connect2.Close();
                        connect3.Close();

                    }
                    connect1.Close();

                }

            }

        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (Form3.userlogin == 1)
            {
                connect4.Open();

                String insertQuery = "SELECT * FROM cummunitytb where num = '" + lbnum + "'";
                MySqlCommand check_zero = new MySqlCommand(insertQuery, connect4);
                MySqlDataReader Check_zero = check_zero.ExecuteReader();
                if (Check_zero.Read())
                {
                    if (Convert.ToInt32(Check_zero.GetString("rate")) != 0)
                    {
                        string checkQuery = "select * from recommandtb where user ='" + userid + "' AND " + "postnum = '" + lbnum + "'";
                        connect1.Open();
                        //MessageBox.Show(checkQuery);
                        MySqlCommand Checkcommand = new MySqlCommand(checkQuery, connect1);
                        MySqlDataReader chek = Checkcommand.ExecuteReader();
                        if (chek.Read())
                        {
                            MessageBox.Show("이미 추천을 했습니다.");
                            connect1.Close();
                        }
                        else
                        {
                            connect2.Open();
                            insertQuery = "INSERT INTO recommandtb(user, postnum, type) VALUES('" + userid + "','" + lbnum + "','" + 0 + "')";
                            MySqlCommand cummunitycommand = new MySqlCommand(insertQuery, connect2);
                            if (cummunitycommand.ExecuteNonQuery() == 1)
                            {
                                connect3.Open();



                                MessageBox.Show("비 추천되었습니다.");
                                insertQuery = "UPDATE cummunitytb set rate = rate - 1 where num = '" + lbnum + "'";
                                MySqlCommand rateupdate = new MySqlCommand(insertQuery, connect2);
                                MySqlDataReader Rate_update = rateupdate.ExecuteReader();

                                insertQuery = "SELECT * FROM cummunitytb where num = '" + lbnum + "'";
                                MySqlCommand update_rate = new MySqlCommand(insertQuery, connect3);
                                MySqlDataReader Update_rate = update_rate.ExecuteReader();
                                if (Update_rate.Read())
                                {
                                    lbRate.Text =  Update_rate.GetString("rate");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("비추천 할 수 없습니다.");
                    }
                    connect1.Close();
                    connect2.Close();
                    connect3.Close();
                    connect4.Close();
                }
                DBLoad();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }
        void DBLoad()
        {
            community.comm.numlist.Clear();
            community.comm.namelist.Clear();
            community.comm.authorlist.Clear();
            community.comm.ratelist.Clear();
            community.comm.joinlist.Clear();
            community.comm.eventlist.Clear();
            community.comm.contentlist.Clear();
            community.comm.categorylist.Clear();
            string readon = "select * from cummunitytb order by num desc";
            connect1.Open();
            MySqlCommand command1 = new MySqlCommand(readon, connect1);
            MySqlDataReader rdr = command1.ExecuteReader();
            while (rdr.Read())
            {
                community.comm.numlist.Add(rdr.GetString("num"));
                community.comm.namelist.Add(rdr.GetString("title"));
                community.comm.eventlist.Add(rdr.GetString("preset"));
                community.comm.joinlist.Add(rdr.GetString("joinner"));
                community.comm.ratelist.Add(rdr.GetString("rate"));
                community.comm.authorlist.Add(rdr.GetString("author"));
                community.comm.categorylist.Add(rdr.GetString("category"));
                community.comm.contentlist.Add(rdr.GetString("content"));
            }
            rdr.Close();
            connect1.Close();
        }

        void BT_delete_Click(object sender, EventArgs e)
        {
            community.comm.readon = "delete from cummunitytb where num = " + lbNum.Text;
            community.comm.write_btn.PerformClick();
            community.comm.최신순ToolStripMenuItem.PerformClick();
            string checkQuery = "delete from recommandtb where postnum ='" + lbnum + "'";
            connect1.Open();
            //MessageBox.Show(checkQuery);
            MySqlCommand Checkcommand = new MySqlCommand(checkQuery, connect1);
            MySqlDataReader chek = Checkcommand.ExecuteReader();
            connect1.Close();
            previousbtn.PerformClick();
        }

        private void BT_download_Click(object sender, EventArgs e)
        {
            string data = lbEvent.Text+= "\n";
            data = data.Trim();
            System.IO.File.AppendAllText(savePath, data);

            DBsave();
        }

        private void DBsave()
        {
            string data = inevent;
            string inname1 = "";
            int insplit = 0;
            string incolor = "";
            string inevent1 = "";
            if (data != null)
            {
                String[] preset_1;
                preset_1 = data.Split(' ');
                int split_p = Convert.ToInt32(preset_1[0]);
                insplit = split_p;
                for (int k = 1; k < split_p + 1; k++)
                {
                    incolor += preset_1[k] + " ";
                }
                for (int h = split_p + 1; h < split_p * 2 + 1; h++)
                {
                    inevent1 += preset_1[h] + " ";
                }
                if (preset_1.Length > ((split_p) * 2) + 1)
                {
                    string teset1 = "";
                    int test1 = preset_1.Length - (((split_p) * 2) + 1);
                    for (int j = 0; j < test1; j++)
                    {

                        teset1 += preset_1[(((split_p * 2) + 1) + j)] += " ";

                    }
                    inname1 = teset1.Trim();
                    //MessageBox.Show(teset1); 

                }
                else
                {
                    inname1 = preset_1[(split_p * 2) + 1];

                }
                con.Open();
                string indata = "insert into " + Form3.userid + "tb(id,split,color,event,name) VALUES('" + Form3.userid + "','" + insplit + "','" + incolor + "','" + inevent1 + "','" + inname1 + "')";
                MySqlCommand command = new MySqlCommand(indata, con);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("다운로드 완료");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void detail_preset_Enter(object sender, EventArgs e)
        {
            inevent = lbEvent.Text;
            detail = this;
            this.Visible = true;
            userid = Form3.userid;
        }
    }
}