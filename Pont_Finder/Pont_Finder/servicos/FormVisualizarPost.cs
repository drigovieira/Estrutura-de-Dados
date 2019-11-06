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

        public FormVisualizarPost(int postId)
        {
            classes.Post p = new classes.Post();
            post = classes.PostList.SelectId(postId);
           
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
                lb_endereco.Text = "";
                lb_telefone.Text = "";
                lb_cpf.Text = "";
                lb_cep.Text = "";

            }
            else
            {

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
    }
}
