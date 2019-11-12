using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormVisualizarPost : Form
    {
        classes.Post post = new classes.Post();
        Form anterior;

        public FormVisualizarPost(int postId, Form anterior)
        {
            classes.Post p = new classes.Post();
            post = classes.PostList.SelectId(postId);
            this.anterior = anterior;
            InitializeComponent();


            
        }

        private void FormVisualizarPost_Load(object sender, EventArgs e)
        {
            lb_titulo.Text = post.Titulo;
            lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", post.Valor); ;
            pb_icone.ImageLocation = post.Image;
            lb_descricao.Text = post.Descricao;

            if (post.Cnpj == -1)
            {
                User user = UserList.selectCpf(post.Cpf);

                lb_fantasia.Text = "Nome: " + user.Nome;
                lb_email.Text = "E-mail: " + user.Email;
                pb_empresa.ImageLocation = user.Image;
                lb_endereco.Text = "";
                lb_telefone.Text = "";
                lb_cpf.Text = "";
               


            }
            else
            {
               
                classes.Empresa emp = classes.ListaEmpresa.selectCpf(post.Cpf);

                lb_fantasia.Text = "Nome: " + emp.NomeFantasia;
                lb_email.Text = "E-mail: " + emp.Email;
                lb_endereco.Text = "Endereco:" + emp.Endereco;
                lb_telefone.Text = "Telefone: " + emp.Telefone;
                lb_cpf.Text = "Cnpj: "+ emp.Cnpj;
                pb_empresa.ImageLocation = emp.Image;


            }

        }

        private void pb_icon_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_Endereco_Click(object sender, EventArgs e)
        {

        }

        private void Bt_voltar_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", anterior);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", anterior);
        }

        private void Btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }

        private void Btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }
    }
}
