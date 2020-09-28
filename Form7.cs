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
    public partial class Form7 : Form
    {
        int page = 1;
        
        public Form7()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.orange_maual1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = page.ToString();
            if(page == 1)
            {
                gunaButton3.Enabled = false;
            }
            else
            {
                gunaButton3.Enabled = true;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            page++;
            switch (page)
            {
                case 2:
                    pictureBox1.Image = Properties.Resources.orange_maual2;
                    label3.Text = page.ToString();
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.orange_maual3;
                    label3.Text = page.ToString();
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.orange_maual4;
                    label3.Text = page.ToString();
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.orange_maual5;
                    label3.Text = page.ToString();
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.orange_maual6;
                    label3.Text = page.ToString();
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.orange_maual7;
                    label3.Text = page.ToString();
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.orange_maual8;
                    label3.Text = page.ToString();
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.orange_maual9;
                    label3.Text = page.ToString();
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.orange_maual10;
                    label3.Text = page.ToString();
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.orange_maual11;
                    label3.Text = page.ToString();
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.orange_maual12;
                    label3.Text = page.ToString();
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.orange_maual13;
                    label3.Text = page.ToString();
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources.orange_maual14;
                    label3.Text = page.ToString();
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.orange_maual15;
                    label3.Text = page.ToString();
                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources.orange_maual16;
                    label3.Text = page.ToString();
                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources.orange_maual17;
                    label3.Text = page.ToString();
                    break;
            }
            if(page == 17)
            {
                gunaButton2.Enabled = false;
            }
            else
            {
                gunaButton2.Enabled = true;
            }
            if (page == 1)
            {
                gunaButton3.Enabled = false;
            }
            else
            {
                gunaButton3.Enabled = true;
            }
            if(page<4 && page > 0)
            {
                label2.Text = "디바이스-PC";
            }
            else if (page<8 && page>3)
            {
                label2.Text = "프리셋 제작방법";
            }
            else if(page<10 && page > 7)
            {
                label2.Text = "로그인 및 회원가입";
            }
            else if (page < 18 && page > 9)
            {
                label2.Text = "커뮤니티 활용법";
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            page--;
            switch (page)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.orange_maual1;
                    label3.Text = page.ToString();
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.orange_maual2;
                    label3.Text = page.ToString();
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.orange_maual3;
                    label3.Text = page.ToString();
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.orange_maual4;
                    label3.Text = page.ToString();
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.orange_maual5;
                    label3.Text = page.ToString();
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.orange_maual6;
                    label3.Text = page.ToString();
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.orange_maual7;
                    label3.Text = page.ToString();
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.orange_maual8;
                    label3.Text = page.ToString();
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.orange_maual9;
                    label3.Text = page.ToString();
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.orange_maual10;
                    label3.Text = page.ToString();
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.orange_maual11;
                    label3.Text = page.ToString();
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.orange_maual12;
                    label3.Text = page.ToString();
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.orange_maual13;
                    label3.Text = page.ToString();
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources.orange_maual14;
                    label3.Text = page.ToString();
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.orange_maual15;
                    label3.Text = page.ToString();
                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources.orange_maual16;
                    label3.Text = page.ToString();
                    break;
            }
            if (page == 1)
            {
                gunaButton3.Enabled = false;
            }
            else
            {
                gunaButton3.Enabled = true;
            }
            if (page == 17)
            {
                gunaButton2.Enabled = false;
            }
            else
            {
                gunaButton2.Enabled = true;
            }
        }
    }
}
