using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Load();

                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pictureBox1.Size);

                if (!Directory.Exists("..//..//img"))
                    Directory.CreateDirectory("..//..//img");

                pictureBox1.Image = bmp2;
                string nome = textBox1.Text;
                pictureBox1.Image.Save("..//..//img//"+nome+".jpg", ImageFormat.Jpeg);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
