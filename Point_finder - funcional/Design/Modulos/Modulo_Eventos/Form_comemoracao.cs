using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Eventos
{
    public partial class Form_fim_de_ano : Form
    {
        public Form_fim_de_ano()
        {
            InitializeComponent();
        }

        private void Form_fim_de_ano_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_compra OutroForm = new Form_compra();
            OutroForm.Show();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }
    }
}
