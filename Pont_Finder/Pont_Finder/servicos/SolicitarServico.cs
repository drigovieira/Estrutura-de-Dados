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
    public partial class SolicitarServico : Form
    {
        public SolicitarServico()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 300;
        }

        private void Solicitar_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 40;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 40;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 25;
        }
    }
}
