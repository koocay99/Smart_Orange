using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Serial_Communication.User_Control
{
    public delegate void prebtn();
    public delegate void regbtn();
    public partial class community : UserControl
    {
        public static community comm; 
        public event loadbtn Loadbtn;
        private List<user_preset> UC_preset = new List<user_preset>();
        detail_preset UC_detail = new detail_preset();
        //preset 생성 갯수
        private string searchtag = "title";
        private int presetnum = 5;
        private int flag = 0;
        public int flag_set = 0;
        private Boolean last_page_flag;
        private int presetlocation;
        private int page_count = 0;
        public int page_cehck = 0;
        private int page_count_num = 0;

        public string readon = "select * from cummunitytb order by num desc";
        write UC_write = new write();
        MySqlConnection connect1 = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");
        StringBuilder sb = new StringBuilder();
        public List<string> numlist = new List<string>();
        public List<string> namelist = new List<string>();
        public List<string> eventlist = new List<string>();
        public List<string> joinlist = new List<string>();
        public List<string> ratelist = new List<string>();
        public List<string> authorlist = new List<string>();
        public List<string> categorylist = new List<string>();
        public List<string> contentlist = new List<string>();
        int existkey = 0;
        int dbread_tag = 0;


        public community()
        {
            InitializeComponent();
        }

        public void community_Load(object sender, EventArgs e)
        {
            lbPage.Text = (page_cehck + 1).ToString();
            blinder_pb.BringToFront();
            write_btn.BringToFront();
            comm = this;
            UC_write.Regbtn += new regbtn(regist);
            UC_detail.Prebtn += new prebtn(previous);
            string readon = "select * from cummunitytb order by num desc";
            connect1.Open();
            MySqlCommand command1 = new MySqlCommand(readon, connect1);
            MySqlDataReader rdr = command1.ExecuteReader();
            while (rdr.Read())
            {
                numlist.Add(rdr.GetString("num"));
                namelist.Add(rdr.GetString("title"));
                eventlist.Add(rdr.GetString("preset"));
                joinlist.Add(rdr.GetString("joinner"));
                ratelist.Add(rdr.GetString("rate"));
                authorlist.Add(rdr.GetString("author"));
                categorylist.Add(rdr.GetString("category"));
                contentlist.Add(rdr.GetString("content"));
                dbread_tag++;
            }
            //presetnum = dbread_tag;
            existkey = dbread_tag;
            rdr.Close();
            connect1.Close();


            for (int i = 0; i < presetnum; i++)
            {
                try
                {
                    UC_preset.Add(new user_preset());
                    presetlocation = UC_preset[0].Size.Height;
                    UC_preset[i].lbtitle = "제목 : " + namelist[i];
                    UC_preset[i].lbauthor = "작성자 : " + authorlist[i];
                    UC_preset[i].lbcategory = "카테고리 : " + categorylist[i];
                    UC_preset[i].lbjoin = "조회수 : " + joinlist[i];
                    UC_preset[i].lbrate = "추천수 : " + ratelist[i];
                    UC_preset[i].lbpreset = "preset: " + eventlist[i];
                    UC_preset[i].Location = new Point(0, 100 + (presetlocation * i) + (10 * i));
                    UC_preset[i].Tag = i;
                    UC_preset[i].MouseClick += new MouseEventHandler(preset_load_event);
                    panel1.Controls.Add(UC_preset[i]);
                }
                catch
                {

                }
            }
            lbPage.Location = new Point(168, 100 + (presetlocation * presetnum) + (10 * presetnum) + 8);
            gunaButton3.Location = new Point(27, 100 + (presetlocation * presetnum) + (10 * presetnum));
            gunaButton2.Location = new Point(207, 100 + (presetlocation * presetnum) + (10 * presetnum));
            write_btn.PerformClick();
        }
        
        public void previous()
        {
            Topgroup_true();
            Searchgroup_true();
            Pagegroup_true();
            Form5.frm5.BtnGroup_true();
            panel1.AutoScroll = true;
        }

        public void regist()
        {
            this.Visible = false;
        }

        public void preset_load_event(object sender, MouseEventArgs e)
        {
            if (Form3.userlogin == 1)
            {
                Form5.frm5.detailkey = 1;
                DBLoad();
                int data;
                int detailkey = 0;
                user_preset UC_preset = sender as user_preset;
                data = (int)UC_preset.Tag;
                UC_detail.Dock = DockStyle.Fill;
                UC_detail.lbnum = numlist[data];
                UC_detail.lbtitle = "제목 : " + namelist[data];
                UC_detail.lbauthor = "작성자 : " + authorlist[data];
                UC_detail.lbcategory = "카테고리 : " + categorylist[data];
                UC_detail.lbjoin = "조회수 : " + joinlist[data];
                UC_detail.lbrate = ratelist[data];
                UC_detail.lbpreset = "preset: " + eventlist[data];
                UC_detail.tbcontext = contentlist[data];
                if (detailkey == 0)
                {
                    panel1.Controls.Add(UC_detail);
                    UC_detail.BringToFront();
                    detailkey = 1;
                }
                if(Form3.userid == authorlist[data])
                {
                    detail_preset.detail.BT_delete.Visible = true;
                    detail_preset.detail.BT_download.Visible = true;
                    detail_preset.detail.BT_download.Size = detail_preset.detail.BT_delete.Size;
                    detail_preset.detail.BT_download.Location = new Point(detail_preset.detail.BT_delete.Location.X + 175, detail_preset.detail.BT_delete.Location.Y);
                }
                else
                {
                    detail_preset.detail.BT_delete.Visible = false;
                    detail_preset.detail.BT_download.Visible = true;
                    detail_preset.detail.BT_download.Size = new Size(324, 25);
                    detail_preset.detail.BT_download.Location = new Point(23,626);
                }
                Form5.frm5.BtnGroup_false();
                UC_detail.Visible = true;
                panel1.AutoScroll = false;
                Searchgroup_false();
                Topgroup_false();
                Pagegroup_false();
                string checkQuery = "UPDATE cummunitytb set joinner = joinner + 1 where num = '" + numlist[data] + "'";
                connect1.Open();
                //MessageBox.Show(checkQuery);
                MySqlCommand Checkcommand = new MySqlCommand(checkQuery, connect1);
                MySqlDataReader chek = Checkcommand.ExecuteReader();
                connect1.Close();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }

        private void DBLoad()
        {
            numlist.Clear();
            namelist.Clear();
            authorlist.Clear();
            ratelist.Clear();
            joinlist.Clear();
            eventlist.Clear();
            contentlist.Clear();
            categorylist.Clear();
            int t = 0;
            connect1.Open();
            MySqlCommand command1 = new MySqlCommand(readon, connect1);
            MySqlDataReader rdr = command1.ExecuteReader();
            while (rdr.Read())
            {
                numlist.Add(rdr.GetString("num"));
                namelist.Add(rdr.GetString("title"));
                eventlist.Add(rdr.GetString("preset"));
                joinlist.Add(rdr.GetString("joinner"));
                ratelist.Add(rdr.GetString("rate"));
                authorlist.Add(rdr.GetString("author"));
                categorylist.Add(rdr.GetString("category"));
                contentlist.Add(rdr.GetString("content"));
                t++;
            }
            //presetnum = t;
            existkey = t;
            rdr.Close();
            connect1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbPage.Text = (page_cehck + 1).ToString();
            DBLoad();
            flag = flag_set;
            panel1.AutoScrollPosition = new Point(0, 0);

            for (int i = 0; i < presetnum; i++)
            {
                try
                {
                    UC_preset[i].MouseClick -= new MouseEventHandler(preset_load_event);
                    panel1.Controls.Remove(UC_preset[i]);
                    UC_preset.Add(new user_preset());
                    presetlocation = UC_preset[0].Size.Height;
                    UC_preset[i].lbpreset = eventlist[flag];
                    UC_preset[i].lbtitle = "제목 : " + namelist[flag];
                    UC_preset[i].lbauthor = "작성자 : " + authorlist[flag];
                    UC_preset[i].lbcategory = "카테고리 : " + categorylist[flag];
                    UC_preset[i].lbjoin = "조회수 : " + joinlist[flag];
                    UC_preset[i].lbrate = "추천수 : " + ratelist[flag];
                    UC_preset[i].Location = new Point(0, 100 + (presetlocation * i) + (10 * i));
                    UC_preset[i].Tag = flag;
                    UC_preset[i].BringToFront();
                    flag++;
                    panel1.Controls.Add(UC_preset[i]);
                    UC_preset[i].MouseClick += new MouseEventHandler(preset_load_event);
                    last_page_flag = false;
                }
                catch
                {
                    panel1.Controls.Remove(UC_preset[i]);
                    UC_preset[i].MouseClick -= new MouseEventHandler(preset_load_event);
                    last_page_flag = true;
                }
            }
            page_count = namelist.Count / 5;
            page_count_num = namelist.Count % 5;

        }

        private void 추천수ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readon = "select * from cummunitytb order by rate desc,num desc";
            flag_set = 0; 
            page_cehck = 0;
            write_btn.PerformClick();
           

        }

        private void 조회수ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readon = "select * from cummunitytb order by joinner desc,num desc";
            flag_set = 0;
            page_cehck = 0;
            write_btn.PerformClick();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gunaContextMenuStrip1.Show(Control.MousePosition);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (page_count_num != 0)
            {
                if (page_cehck < page_count)
                {
                    flag_set += 5;
                    page_cehck++;
                    write_btn.PerformClick();
                }
            }
            else
            {
                if (page_cehck < page_count - 1)
                {
                    flag_set += 5;
                    page_cehck++; 
                    write_btn.PerformClick();
                }
            }

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

            if (flag_set > 0)
            {
                flag_set -= 5;
                page_cehck--;
                write_btn.PerformClick();
            }
        }

        private void BT_search_Click(object sender, EventArgs e)
        {
            
            if(TB_search.Text == "")
            {
                MessageBox.Show("검색어를 입력해 주세요");
            }
            else
            {
                string gsrch = TB_search.Text;
                readon = "select * from cummunitytb where " + searchtag + " like '%" + gsrch + "%'";
                write_btn.PerformClick();
            }
            TB_search.Text = "";
        }

        private void 최신순ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readon = "select * from cummunitytb order by num desc";
            flag_set = 0;
            page_cehck = 0;
            write_btn.PerformClick();
        }

        private void 제목ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchtag = "title";
        }

        private void 내용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchtag = "content";
        }

        private void 카테고리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchtag = "category";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            gunaContextMenuStrip2.Show(Control.MousePosition);
        }

        public void Searchgroup_false()
        {
            gunaPictureBox1.Visible = false;
            TB_search.Visible = false;
            BT_search.Visible = false;
            BT_sort.Visible = false;
            searchlist.Visible = false;
        }

        public void Searchgroup_true()
        {
            gunaPictureBox1.Visible = true;
            TB_search.Visible = true;
            BT_search.Visible = true;
            BT_sort.Visible = true;
            searchlist.Visible = true;
        }

        public void Pagegroup_false()
        {
            gunaButton2.Visible = false;
            gunaButton3.Visible = false;
            lbPage.Visible = false;
        }

        public void Pagegroup_true()
        {
            gunaButton2.Visible = true;
            gunaButton3.Visible = true;
            lbPage.Visible = true;
        }

        public void Topgroup_false()
        {
            write_btn.Visible = false;
            blinder_pb.Visible = false;
        }

        public void Topgroup_true()
        {
            write_btn.Visible = true;
            blinder_pb.Visible = true;
        }
    }
}
