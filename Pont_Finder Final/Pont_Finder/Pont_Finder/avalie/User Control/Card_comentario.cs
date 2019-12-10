using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie.User_Control
{
    public partial class Card_comentario : UserControl
    {
        private classes.Comentario comentario;

        Bitmap imgLike = Model.Img_like;
        Bitmap imgDeslike = Model.Img_deslike;
        Bitmap imgLikeBlue = Model.Img_like_click;
        Bitmap imgDeslikeBlue = Model.Img_deslike_click;

        long postid;

        public Card_comentario(long idcoment)
        {
            InitializeComponent();
            comentario = classes.ComentariosList.thisPostId(idcoment);
            this.postid = postid;

            
            
            datapost.Text = (comentario.Data);
            nome.Text = (comentario.Username);
            imagem.ImageLocation = (comentario.ImgUser);
            comentarios.Text = comentario.Comment;


            lb_like.Text = this.comentario.Joinha + "";
            lb_deslike.Text = this.comentario.DeJoinha + "";



            pb_up.Image = imgLike;
            pb_down.Image = imgDeslike;

            if (Session.Online)
            {
                long userlike = this.comentario.userLike(Session.Cpf);

                if (userlike == 1)
                    pb_up.Image = imgLikeBlue;
                else if (userlike == -1)
                    pb_down.Image = imgDeslikeBlue;
            }


           

            if (Session.Cpf == comentario.UserCpf)
            {
                bt_editar.Visible = true;
                bt_remover.Visible = true;
                comentarios.Enabled = true;
            }
            else
            {
                bt_editar.Visible = false;
                bt_remover.Visible = false;
                
            }

           

            


        }

        private void lb_comentario_Click(object sender, EventArgs e)
        {

        }

        private void pb_up_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (pb_up.Image == imgLikeBlue)
                {
                    comentario.like(0, Session.Cpf);
                    pb_up.Image = imgLike;
                    pb_down.Image = imgDeslike;
                }
                else
                {
                    comentario.like(1, Session.Cpf);
                    pb_up.Image = imgLikeBlue;
                    pb_down.Image = imgDeslike;
                }
                lb_like.Text = "" + comentario.Joinha;
                lb_deslike.Text = "" + comentario.DeJoinha;

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
                    comentario.like(0, Session.Cpf);
                    pb_down.Image = imgDeslike;
                    pb_up.Image = imgLike;
                }
                else
                {
                    comentario.like(-1, Session.Cpf);
                    pb_down.Image = imgDeslikeBlue;
                    pb_up.Image = imgLike;
                }
                lb_like.Text = "" + comentario.Joinha;
                lb_deslike.Text = "" + comentario.DeJoinha;
            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (comentarios.Text == "" )
            {
                MessageBox.Show("ENTRE COM UM COMENTÁRIO");
            }
            else
            {

                comentario.Comment = comentarios.Text;
            }
            FormPrincipal.MudarForm("avalie", new ViewPost(postid));
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (comentarios.Text == "")
            {
                MessageBox.Show("ENTRE COM UM COMENTÁRIO");
            }
            else
            {

                comentario.PostId = -1;
            }
            FormPrincipal.MudarForm("avalie", new ViewPost(postid));

        }

        private void Card_comentario_Load(object sender, EventArgs e)
        {

        }
    }
}
