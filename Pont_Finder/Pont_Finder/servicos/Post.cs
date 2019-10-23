using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Publicar_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.Id = classes.ServiceList.Tam;
            s.Tipo = textBox3.Text;
            s.Valor = double.Parse(textBox1.Text);
            s.Detalhes = textBox2.Text ;
            s.Sugestoes = 0;
            s.Visualizacoes = 0;
            s.Like = 0;
            s.Avaliacao = 0;
            s.Ativo = true;
         
            classes.ServiceList.Add(s);     
            this.Close();
        }
    }
}
