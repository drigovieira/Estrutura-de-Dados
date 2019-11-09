using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider_img
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        
        private void LoadNextImg() 
        {
            if (imageNumber == 6) 
            {
                imageNumber = 1;
            }
            pc_slider.ImageLocation = string.Format(@"images\{0}.jpg",imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }
    }
}
