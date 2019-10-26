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
            pictureBox1.ImageLocation = yImage;
            pictureBox1.Load();

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
            descricao.Text = this.yDetalhes;
            valor.Text = this.yValor + "";
            label1.Text = yLike+"";
            visualizacoes.Text = this.yVisualizacoes + "";
            username.Text = "none";
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
