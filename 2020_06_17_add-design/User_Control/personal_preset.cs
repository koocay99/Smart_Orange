using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Communication.User_Control
{
    public partial class personal_preset : UserControl
    {
        public personal_preset()
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
    }
}
