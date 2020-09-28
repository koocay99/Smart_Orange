using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Communication
{
    public partial class Form1 : Form
    {
        RegistryKey ckey1 = Registry.CurrentUser.CreateSubKey("C# rkey");
        RegistryKey rkey = Registry.CurrentUser.OpenSubKey("C# rkey").OpenSubKey("infokey", true);
        private Point mMyPoint;
        MySqlConnection datareadconnect = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
        public Form1()
        {
            InitializeComponent();
            label1.Text = Form3.userid;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void logout_button_Click(object sender, EventArgs e)
        {
            Form3.userlogin = 0;
            Form3.userid = "";
            Form3.userpassword = "";
            string strlog = Form3.userlogin.ToString();
            rkey.SetValue("id", "");
            rkey.SetValue("password", "");
            rkey.SetValue("log", strlog);
            MessageBox.Show("로그아웃되었습니다.");
            this.Close();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)

                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }
    }
}
