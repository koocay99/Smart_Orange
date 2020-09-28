using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Serial_Communication.User_Control;
using System.Web.UI.Design;
using System.Runtime.InteropServices;
using System.IO.Ports;  //시리얼통신을 위해 추가해줘야 함
using System.IO;
using AutoIt;
using Microsoft.Win32;


namespace Serial_Communication
{
    public delegate void loadbtn();
    public partial class Form5 : Form
    {
        private int image = 0;
        private int connectkey = 0;
        private int editkey = 0;
        private int communitykey = 0;
        public static Form5 frm5;
        Connect_Control UC_connect = new Connect_Control();
        Edit UC_edit = new Edit();
        community UC_community = new community();
        detail_preset UC_detail = new detail_preset();

        MySqlConnection datareadconnect = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
        List<String> data_list = new List<String>();
        public Form5()
        {
            InitializeComponent();
            frm5 = this;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            UC_community.Loadbtn += new loadbtn(detail_load);
            UC_edit.MouseDown += new MouseEventHandler(edit_Down_event);
            UC_edit.MouseMove += new MouseEventHandler(edit_Move_event);
            UC_connect.MouseDown += new MouseEventHandler(connect_Down_event);
            UC_connect.MouseMove += new MouseEventHandler(connect_Move_event);
        }

        public Point mMyPoint;
        private void moveImageBox(object sender)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            image_slide.Location = new Point(b.Location.X + 40, b.Location.Y);
            if (image == 0)
            {
                image_slide.Visible = true;
                image = 1;
            }
            image_slide.SendToBack();
            
        }
        //usercontrol change
        private void gunaAdvenceButton1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
            if (editkey == 0)
            {
                UC_connect.Dock = DockStyle.Fill;
                panel2.Controls.Add(UC_edit);
                editkey = 1;
            }
            UC_edit.BringToFront();
            exit_button.BringToFront();
            minimize_button.BringToFront();
        }

        private void gunaAdvenceButton2_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
            if (connectkey == 0)
            {
                UC_connect.Dock = DockStyle.Fill;
                panel2.Controls.Add(UC_connect);
                connectkey = 1;
            }
            UC_connect.BringToFront();
            exit_button.BringToFront();
            minimize_button.BringToFront();
        }

        private void gunaAdvenceButton3_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
            if (communitykey == 0)
            {
                UC_community.Dock = DockStyle.Fill;
                panel2.Controls.Add(UC_community);
                communitykey = 1;
            }
            search_btn.Visible = true;
            write_btn.Visible = true;
            UC_community.BringToFront();
            blinder_pb.BringToFront();
            exit_button.BringToFront();
            minimize_button.BringToFront();
            search_btn.BringToFront();
            write_btn.BringToFront();

        }
        //login
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Form3.userlogin == 1)
            {
                Form1 showForm1 = new Form1();
                showForm1.ShowDialog();
            }
            else
            {
                Form3 showForm3 = new Form3();
                showForm3.ShowDialog();

            }
        }

        //tray
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Notification.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //exit , minimize
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Notification.Visible = true;
            Notification.ContextMenuStrip = contextMenuStrip1;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //program move
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)
                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }

        private void edit_Down_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void edit_Move_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)
                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }

        private void connect_Down_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void connect_Move_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)
                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }

        void detail_load()
        {
            search_btn.Visible = false;
            write_btn.Visible = false;
            blinder_pb.Visible = false;
        }
    }
}
