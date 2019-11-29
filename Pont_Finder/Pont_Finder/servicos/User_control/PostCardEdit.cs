using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Pont_Finder.servicos
{
    public partial class PostCardEdit : UserControl
    {
        classes.Post post;

        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");


        public PostCardEdit(int postId)
        {
            post = classes.PostList.SelectId(postId);
            InitializeComponent();
            lb_titulo.Text = post.Titulo;
            lb_descricao.Text = post.Descricao;
            lb_like.Text = ""+post.Likes;
        
            lb_data.Text = "Postado em: " + post.Data;

            lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.post.Valor);

            pb_icone.ImageLocation = post.Image;

            lb_like.Text = this.post.Joinha + "";
            lb_deslike.Text = this.post.DeJoinha + "";

            pb_up.Image = imgLike;
            pb_down.Image = imgDeslike;

            if (Session.Online)
            {
                long userlike = this.post.userLike(Session.Cpf);

                if (userlike == 1)
                    pb_up.Image = imgLikeBlue;
                else if (userlike == -1)
                    pb_down.Image = imgDeslikeBlue;
            }


        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, new FormUserCards()));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormPostEdit(post.Id, new FormUserCards()));
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
                classes.Empresa emp = classes.ListaEmpresa.ForCpf(post.Cpf);
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lb_titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
