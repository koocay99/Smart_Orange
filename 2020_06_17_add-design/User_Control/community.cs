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
    public partial class community : UserControl
    {
        public event loadbtn Loadbtn;
        private List<user_preset> UC_preset = new List<user_preset>();
        detail_preset UC_detail = new detail_preset();
        //preset 생성 갯수
        private int presetnum;
        private int presetlocation;

        MySqlConnection connect1 = new MySqlConnection("Server=1.236.44.88;Database=cummunitydb;Uid=gun;Pwd=1234");
        StringBuilder sb = new StringBuilder();
        List<string> namelist = new List<string>();
        List<string> eventlist = new List<string>();
        List<string> joinlist = new List<string>();
        List<string> ratelist = new List<string>();
        List<string> authorlist = new List<string>();
        List<string> categorylist = new List<string>();
        List<string> contentlist = new List<string>();

        string readtitle1 = "";
        string readevent1 = "";
        string readjoin1 = "";
        string readrate1 = "";
        string readauthor1 = "";
        string readcategory1 = "";
        string readcontent1 = "";

        
        public community()
        {
            InitializeComponent();
        }

        private void community_Load(object sender, EventArgs e)
        {
            UC_detail.Prebtn += new prebtn(previous);
            int dbread_tag = 0;
            string readon = "select * from cummunitytb";
            connect1.Open();
            MySqlCommand command1 = new MySqlCommand(readon, connect1);
            MySqlDataReader rdr = command1.ExecuteReader();
            while (rdr.Read())
            {

                namelist.Add(rdr.GetString("title"));
                readtitle1 += namelist[dbread_tag] + " ";
                eventlist.Add(rdr.GetString("preset"));
                readevent1 += eventlist[dbread_tag] + " ";
                joinlist.Add(rdr.GetString("joinner"));
                readjoin1 += joinlist[dbread_tag] + " ";
                ratelist.Add(rdr.GetString("rate"));
                readrate1 += ratelist[dbread_tag] + " ";
                authorlist.Add(rdr.GetString("author"));
                readauthor1 += authorlist[dbread_tag] + " ";
                categorylist.Add(rdr.GetString("category"));
                readcategory1 += categorylist[dbread_tag] + " ";
                contentlist.Add(rdr.GetString("content"));
                readcontent1 += contentlist[dbread_tag] + " ";

                dbread_tag++;
            }

            presetnum = 5;
            
            for(int i = 0; i < presetnum; i++)
            {
                UC_preset.Add(new user_preset());
                presetlocation = UC_preset[0].Size.Height;
                UC_preset[i].lbtitle = "제목 : " + namelist[i];
                UC_preset[i].lbauthor = "저자 : " + authorlist[i];
                UC_preset[i].lbcategory = "카테고리 : ";
                UC_preset[i].lbjoin = "조회수 : " + joinlist[i];
                UC_preset[i].lbrate = "추천수 : " + ratelist[i];
                UC_preset[i].Location = new Point(0, 49 + (presetlocation * i));
                UC_preset[i].Tag = i;
                UC_preset[i].MouseClick += new MouseEventHandler(preset_load_event);
                panel1.Controls.Add(UC_preset[i]);
            }
        }
        
        public void previous()
        {
            panel1.AutoScroll = true;
            Form5.frm5.blinder_pb.Visible = true;
            Form5.frm5.search_btn.Visible = true;
            Form5.frm5.write_btn.Visible = true;
        }
        public void preset_load_event(object sender , MouseEventArgs e)
        {
            if(Loadbtn != null)
            {
                Loadbtn();
            }
            UC_detail.Visible = true;
            int data;
            int detailkey = 0;
            user_preset UC_preset = sender as user_preset;
            data = (int)UC_preset.Tag;
            UC_detail.Dock = DockStyle.Fill;
            UC_detail.lbtitle = "제목 : " + namelist[data];
            UC_detail.lbauthor = "저자 : " + authorlist[data];
            UC_detail.lbcategory = "카테고리 : ";
            UC_detail.lbjoin = "조회수 : " + joinlist[data];
            UC_detail.lbrate = "추천수 : " + ratelist[data];
            if (detailkey == 0)
            {
                panel1.Controls.Add(UC_detail);
                UC_detail.BringToFront();
                detailkey = 1;
            }
            panel1.AutoScroll = false;
        }

    }
}
