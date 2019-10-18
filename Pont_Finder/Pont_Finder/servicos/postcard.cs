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
        string yTipo;
        string yDetalhes;
        double yValor;
        public postcard(string xTipo, string xDetalhes, double xValor)
        {
            yTipo = xTipo;
            yDetalhes = xDetalhes;
            yValor = xValor;
            InitializeComponent();
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
            tipo.Text = yTipo;
            descricao.Text = yDetalhes;
            valor.Text = yValor + "";
        }
    }
}
