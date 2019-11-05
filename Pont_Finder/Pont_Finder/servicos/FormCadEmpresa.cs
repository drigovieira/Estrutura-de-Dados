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
    public partial class FormCadEmpresa : Form
    {
        public FormCadEmpresa()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string fatasia = tb_fantasia.Text;
            long cnpj = long.Parse(tb_cep.Text);
            string endereco = tb_endereco.Text;
            string telefone = tb_telefone.Text;
            string email = tb_email.Text;

            classes.Empresa tmp = new classes.Empresa();
            tmp.Nome = nome;
            tmp.NomeFantasia = fatasia;
            tmp.Email = email;
            tmp.Cnpj = cnpj;
            tmp.Endereco = endereco;
            tmp.Telefone = telefone;
            tmp.Cpf = Session.Cpf;
            tmp.Status = true;
            classes.ListaEmpresa.Add(tmp);
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }
    }
}
