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
    public partial class PostCardEdit : UserControl
    {
        classes.Post post;
        public PostCardEdit(int postId)
        {
            post = classes.PostList.SelectId(postId);
            InitializeComponent();
            lb_titulo.Text = post.Titulo;
            lb_descricao.Text = post.Descricao;
            lb_like.Text = ""+post.Likes;
            lb_valor.Text = "" + post.Valor;
            lb_data.Text = "Postado em: " + post.Data;

            pb_icone.ImageLocation = post.Image;

        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, new FormUserCards()));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormPostEdit(post.Id));
        }

        private void PostCardEdit_Load(object sender, EventArgs e)
        {
            if (post.Cnpj == -1)
            {
                User u = UserList.selectCpf(post.Cpf);
                pb_user.ImageLocation = u.Image;
                lb_username.Text = u.Nome;
            }
            else
            {
                classes.Empresa emp = classes.ListaEmpresa.selectCpf(post.Cpf);
                pb_user.ImageLocation = emp.Image;
                lb_username.Text = emp.Nome;

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Post", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                post.Ativo = false;
                MessageBox.Show("Post Excluido");
                FormPrincipal.MudarForm("servicos", new FormUserCards());
            }               
            else
                MessageBox.Show("Cancelado");
        }
    }
}
