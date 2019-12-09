using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class Post_Card : UserControl
    {
        Classes.CoEvento post;

        private Classes.comentario comentario;

        Bitmap imgLike = Model.Img_like;
        Bitmap imgDeslike = Model.Img_deslike;
        Bitmap imgLikeBlue = Model.Img_like_click;
        Bitmap imgDeslikeBlue = Model.Img_deslike_click;

        long postid;
        public Post_Card(long postid)
        {
            InitializeComponent();

            post = Classes.Eventos_List.PosterId(postid);

            this.postid = postid;

            pb_imagem.ImageLocation = post.Imagem1;
            lb_nome.Text = post.Nome;
            lb_ingressos.Text = ""+post.IngressoDispinivel;
            lb_data.Text = post.Data;
            lb_categoria.Text = post.Categoria;
            lb_valor.Text = post.Valor;
            lb_classifica.Text = post.Idade;
            lb_local.Text = post.Local;
            lb_horario.Text = post.horario;

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

        private void Post_Card_Load(object sender, EventArgs e)
        {

        }

        private void Lb_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bt_visualizar_Click(object sender, EventArgs e)
        {
            eventos.Visualizar_evento avaliepost = new Visualizar_evento(post.Id);
            FormPrincipal.MudarForm("Reclame", avaliepost);

            //eventos.Visualizar_evento visu = new eventos.Visualizar_evento(post.Id);
            //visu.ShowDialog();


            //eventos.Visualizar_evento viewEvento = new eventos.Visualizar_evento(post.Id);
            //FormPrincipal.MudarForm("eventos", viewEvento);
        }

        private void Pb_up_Click(object sender, EventArgs e)
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

        private void Pb_down_Click(object sender, EventArgs e)
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
    }
}
