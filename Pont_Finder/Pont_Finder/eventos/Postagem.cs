using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class Postagem : Form
    {
        public Postagem()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagem = new OpenFileDialog();

            if (Imagem.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = Imagem.FileName;
            }
    }
}
