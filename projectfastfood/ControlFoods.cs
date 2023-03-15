using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.Http.Headers;

namespace projectfastfood
{
    public partial class ControlFoods : UserControl
    {
        public ControlFoods()
        {
            InitializeComponent();
        }

        public string Pnumber
        {
            get { return lblnumber.Text; }
            set { lblnumber.Text = value; }
        }
        public string Pname
        {
            get { return lblname.Text; }
            set { lblname.Text = value; }
        }
        public string Pbalance
        {
            get { return lblbalance.Text; }
            set { lblbalance.Text = value; }
        }
        public Image PImage
        {
            get { return roundImage.Image; }
            set { roundImage.Image = value; }
        }

        public Button Btnpick
        {
            get { return btnpick; }
            set { btnpick = value; }
        }
    }
}
