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
    public partial class FormEditarPerfil : Form
    {
        classes.Empresa empresa;
        public FormEditarPerfil()
        {
            empresa = classes.ListaEmpresa.ForCpf(Session.Cpf);
            InitializeComponent();

            pb_icone.ImageLocation = empresa.Image;
            lb_fantasia.Text = empresa.NomeFantasia;
            lb_categoria.Text = empresa.Categoria;
            lb_email.Text = empresa.Email;
            tb_endereco.Text = empresa.Endereco;
            tb_telefone.Text = empresa.Telefone;

    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NomeFantasia_Click(object sender, EventArgs e)
        {

        }

        private void FormEditarPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
