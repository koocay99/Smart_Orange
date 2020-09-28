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

namespace Serial_Communication.User_Control
{
    public partial class user_preset : UserControl
    {
        String[] Preset_decoding;
        List<String> Color_list = new List<String>();
        public static user_preset up;
        public user_preset()
        {
            InitializeComponent();
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
        public string lbpreset
        {
            get { return lbPreset.Text; }
            set { lbPreset.Text = value; }
        }
        private void Edit_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            lbpreset = lbpreset.Replace("preset: ", "");
            Preset_decoding = lbpreset.Split(' ');

            int split_pi = Convert.ToInt32(Preset_decoding[0]);


            const int MARGIN = 10;
            const int WIDTH = 130;

            Graphics graphics = e.Graphics;
            using (Pen ellipsePen = new Pen(Color.Blue))
            {
                ellipsePen.DashPattern = new float[] { 5, 5 };


                Color customColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");//red
                Pen outlinePen = Pens.Black;
                Brush fillBrush = Brushes.GreenYellow;

                fillBrush = new SolidBrush(customColor);

                Rectangle rectangle = new Rectangle(MARGIN , 7, WIDTH, WIDTH);
                if (split_pi != 0)
                {
                    int split_angle = (360 / split_pi);

                    //label1.Text = split_angle.ToString();
                    for (int i = 0; i < split_pi; i++)
                    {
                        Color_list.Add(Preset_decoding[i + 1]);
                        try
                        {
                            customColor = System.Drawing.ColorTranslator.FromHtml(Preset_decoding[i+1]);
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

        private void user_preset_Load(object sender, EventArgs e)
        {
            up = this;
        }

        public void paint()
        {

        }
    }

}
