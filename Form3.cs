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
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace Serial_Communication
{
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=1.236.44.88;Database=logindb;Uid=gun;Pwd=1234");
        MySqlConnection connection1 = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
        private int btn1 = 0;
        private int btn2 = 0;
        private int userID = 0;
        private int check = 0;
        public static int userlogin = 0;
        public static string userid = "";
        public static string userpassword = "";
        private Point mMyPoint;
        RegistryKey rkey1 = Registry.CurrentUser.OpenSubKey("C# rkey").OpenSubKey("infokey", true);
        public Form3()
        {
            InitializeComponent();
            this.regist_button.Enabled = false;
            this.login_button.Enabled = false;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            string strSelect = "select * from info where id='" + ID_TB.Text + "'";
            MySqlCommand cmd = new MySqlCommand(strSelect, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            try
            {
                if (rdr.Read())
                {
                    if (rdr["password"].ToString() == PW_TB.Text)
                    {
                        if(check == 1)
                        {
                            rkey1.SetValue("id", ID_TB.Text);
                            rkey1.SetValue("password", PW_TB.Text);
                            userlogin = 1;
                            string strlog = userlogin.ToString();
                            rkey1.SetValue("log", strlog);
                        }
                        MessageBox.Show("로그인 되었습니다.");

                        userlogin = 1;
                        userid = ID_TB.Text;
                        userpassword = PW_TB.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 틀렸습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void regist_button_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO info(id,password) VALUES('" + ID_TB.Text + "','" + PW_TB.Text + "')";
            string insertQuery1 = "CREATE TABLE " + ID_TB.Text + "tb(" + "\n" + "num int not null auto_increment," + "\n" + "id varchar(30) not null," + "\n" + "split int (1)," + "\n" + "color varchar(100)," + "\n" + "event varchar(100)," + "\n" + "name varchar(100)," + "\n" + "primary key(num));";

            string pwwht = PW_TB.Text;
            string idwht = ID_TB.Text;

            connection.Open();
            connection1.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            MySqlCommand command1 = new MySqlCommand(insertQuery1, connection1);



            if (userID == 0)
            {

                MessageBox.Show("중복확인 버튼을 눌러주세요");

            }
            else if (Regex.IsMatch(idwht, @"\s") == true)
            {
                MessageBox.Show("ID는 문자 사이에 공백을 넣을 수 없습니다.");
            }
            else if (pwwht.Length < 8)
            {
                MessageBox.Show("8자리 이상의 비밀번호를 입력하세요");
            }
            else if (Regex.IsMatch(pwwht, @"[a-zA-Z]{1,}") == false)
            {
                MessageBox.Show("비밀번호는 숫자,영문,특수문자가 최소 하나씩 기입해야 합니다.");
            }
            else if (Regex.IsMatch(pwwht, @"[0-9]{1,}") == false)
            {
                MessageBox.Show("비밀번호는 숫자,영문,특수문자가 최소 하나씩 기입해야 합니다.");
            }
            else if (Regex.IsMatch(pwwht, @"[~`!@#$%^&*()_\-+={}[\]|\\;:'""<>,.?/]{1,}") == false)
            {
                MessageBox.Show("비밀번호는 숫자,영문,특수문자가 최소 하나씩 기입해야 합니다.");
            }
            else
            {
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        if (command1.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("등록완료");
                            userID = 0;
                        }
                        else
                        {
                            MessageBox.Show("등록 실패");
                        }


                    }
                    else
                    {
                        MessageBox.Show("등록 실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            connection.Close();
            connection1.Close();
        }

        private void overlap_button_Click(object sender, EventArgs e)
        {
            string strSelect = "select * from info where id='" + ID_TB.Text + "'";
            connection.Open();
            MySqlCommand command2 = new MySqlCommand(strSelect, connection);
            MySqlDataReader rdr1 = command2.ExecuteReader();

            if (!rdr1.Read())
            {
                userID = 1;
                MessageBox.Show("사용가능한 ID 입니다.");
            }
            else
            {
                MessageBox.Show("ID중복!! 다른 아이디를 사용하세요");
            }
            connection.Close();
        }

        private void ID_TB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ID_TB.Text))
            {
                btn1 = 1;
            }
            else
            {
                btn1 = 0;
            }
            if (btn1 == 1 && btn2 == 1)
            {
                this.regist_button.Enabled = true;
                this.login_button.Enabled = true;
            }
            else
            {
                this.regist_button.Enabled = false;
                this.login_button.Enabled = false;
            }
        }

        private void PW_TB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PW_TB.Text))
            {
                btn2 = 1;
            }
            else
            {
                btn2 = 0;
            }
            if (btn1 == 1 && btn2 == 1)
            {
                this.regist_button.Enabled = true;
                this.login_button.Enabled = true;
            }
            if (btn1 == 1 && btn2 == 1)
            {
                this.regist_button.Enabled = true;
                this.login_button.Enabled = true;
            }
            else
            {
                this.regist_button.Enabled = false;
                this.login_button.Enabled = false;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(check == 0)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)

                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
