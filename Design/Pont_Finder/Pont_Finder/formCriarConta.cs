using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class formCriarConta : Form
    {
        public formCriarConta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string cad_Name = textB_nome.Text;
            string cad_CPF = textB_cpf.Text;
            string cad_email = textB_email.Text;
            string cad_senha = textB_senha.Text;
        }
    }
}
