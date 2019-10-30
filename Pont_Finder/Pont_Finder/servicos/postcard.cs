using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class postcard : UserControl
    {
        private string yTipo;
        private string yDetalhes;
        private double yValor;
        private int yId;
        private int ySugestoes;
        private int yVisualizacoes;
        private int yLike;
        private short yAvaliacao;
        private bool yAtivo;
        private string yImage;

        Bitmap up = Properties.Resources.upgrey;
        Bitmap down = Properties.Resources.downgrey;
        Bitmap upv = Properties.Resources.upblue;
        Bitmap downv = Properties.Resources.downred;


        public postcard(string yTipo, string yDetalhes, double yValor, int yId, int ySugestoes, int yVisualizacoes, int yLike, short yAvaliacao, bool yAtivo, string yImage)
        {
            this.yTipo = yTipo;
            this.yDetalhes = yDetalhes;
            this.yValor = yValor;
            this.yId = yId;
            this.ySugestoes = ySugestoes;
            this.yVisualizacoes = yVisualizacoes;
            this.yLike = yLike;
            this.yAvaliacao = yAvaliacao;
            this.yAtivo = yAtivo;
            this.yImage = yImage;
            InitializeComponent();
            if (yImage != null)
                pictureBox1.ImageLocation = yImage;
            else
                pictureBox1.ImageLocation = "..//..//servicos//data//images//posts//offImage.png";



            pictureBox1.Load();


            pictureBox3.Image = up;
            pictureBox4.Image = down;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Visualizacoes_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //botao de likes
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            tipo.Text = this.yTipo;
            label3.Text = this.yDetalhes;
            valor.Text = this.yValor + "";
            label1.Text = this.yLike+"";
            visualizacoes.Text = this.yVisualizacoes + "";
            username.Text = "none";
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tiposervico_Click(object sender, EventArgs e)
        {

        }

        private void like_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(pictureBox3.Image == up)
            {
                pictureBox3.Image = upv;
                pictureBox4.Image = down;
                label1.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == down)
            {
                pictureBox3.Image = up;
                pictureBox4.Image = downv;
                label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void valor_Click(object sender, EventArgs e)
        {

        }

        private void visualizacoes_Click_1(object sender, EventArgs e)
        {

        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
