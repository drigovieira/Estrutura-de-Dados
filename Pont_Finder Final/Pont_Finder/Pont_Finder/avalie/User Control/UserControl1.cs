using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class UserControl1 : UserControl
    {

        private PostConstructor post;

        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");


        public UserControl1(long postid)
        {
            InitializeComponent();

            post = PostList.PosterId(postid);

            NomePos.Text = (post.Nome);
            imagemuser.ImageLocation = (post.Imgperfil);
            
            userhora.Text = (post.Tempohora);
            lb_problema.Text = (post.Tipoproblema);
            lb_localizar.Text = (post.Localizacao);
            userboxdesc.Text = (post.Desc);
            pictureBox1.ImageLocation = post.Img;


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


            if (post.Resolved == true)
            {
                checado.Visible = true;
            }
            else
            {
                checado.Visible = false;
            }
            
            if(Session.Cpf == post.Cpf)
            {
                bt_editar.Visible = true;
            }
            else
            {
                bt_editar.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            avalie.ViewPost avaliepost = new ViewPost(post.Id);
            FormPrincipal.MudarForm("Reclame", avaliepost);

            /*
            if (Session.Online)
            {
                avalie.ViewPost avaliepost = new ViewPost();
                FormPrincipal.MudarForm("Reclame", avaliepost);
            }
            else
            {
                MessageBox.Show("Por Favor, Efetue o Login para Realizar um Post");
            }
            */
        }

        private void userhora_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            avalie.EditeMeusPosts avaliepost = new EditeMeusPosts(post.Id);
            FormPrincipal.MudarForm("Reclame", avaliepost);

        }

        private void pb_up_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (pb_up.Image == imgLikeBlue)
                {
                    post.like(0, Session.Cpf);
                    pb_up.Image = imgLike;
                    pb_down.Image = imgDeslike;
                }
                else
                {
                    post.like(1, Session.Cpf);
                    pb_up.Image = imgLikeBlue;
                    pb_down.Image = imgDeslike;
                }
                lb_like.Text = "" + post.Joinha;
                lb_deslike.Text = "" + post.DeJoinha;

            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
            }
        }

        private void pb_down_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (pb_down.Image == imgDeslikeBlue)
                {
                    post.like(0, Session.Cpf);
                    pb_down.Image = imgDeslike;
                    pb_up.Image = imgLike;
                }
                else
                {
                    post.like(-1, Session.Cpf);
                    pb_down.Image = imgDeslikeBlue;
                    pb_up.Image = imgLike;
                }
                lb_like.Text = "" + post.Joinha;
                lb_deslike.Text = "" + post.DeJoinha;
            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
            }
        }

        private void Userboxdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
