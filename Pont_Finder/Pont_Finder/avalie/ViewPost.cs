using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class ViewPost : Form
    {

        PostConstructor post;
        classes.Comentario comment;
        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");

        public ViewPost(long postId)
        {
            InitializeComponent();

            post = PostList.PosterId(postId);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewPost_Load(object sender, EventArgs e)
        {
            tb_descricao.Text = post.Desc;
            tb_problema.Text = post.Tipoproblema;
            tb_localizacao.Text = post.Localizacao;
            pb_imagem.ImageLocation = post.Img;
            lb_hora.Text = post.Tempohora;
            NomePos.Text = post.Nome;
            imagemuser.ImageLocation = post.Imgperfil;


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



            if (Session.Online)
            {
                comment = classes.ComentarioList.thisComentario(Session.Cpf, post.Id);

                if (comment != null)
                {
                    tb_resposta.Text = comment.Resposta;
                }

               
            }
            else
            {
                comment = null;
            }


            //MAPA

            //Inicia o mapa baseado no provedor selecionado e carrega o cache.
            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly;

            //LOCALIZAÇÃO DO CACHE
            gMapControl1.CacheLocation = @"F:\GMAP\GmapCache";

            // Inicia o mapa nas coordernadas correspondentes a cidade de cruzeiro.
            gMapControl1.Position = new GMap.NET.PointLatLng(-22.5785104945075, -44.959659576416);

            //end.Cidade = textBox2.Text;
            string endereco = post.Localizacao + ", Cruzeiro, Sâo Paulo";
            gMapControl1.SetPositionByKeywords(endereco);
            gMapControl1.Zoom = 16;
            //Cria um overlay do mapa e cria o marcador.
            GMapOverlay camada = new GMapOverlay("camada");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(), GMarkerGoogleType.red_dot);
            //Iguala o marcador com o texto digitado para trocar a posição e adiciona o marcador no overlay e no mapa.
            gMapControl1.GetPositionByKeywords(endereco, out PointLatLng x);
            gMapControl1.Overlays.Clear();
            marker.Position = x;
            gMapControl1.Overlays.Add(camada);
            camada.Markers.Add(marker);


        }

        private void bt_postar_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (this.comment == null && (tb_resposta.Text.Trim() != ""))
                {
                    classes.Comentario comment = new classes.Comentario();
                    comment.PostId = post.Id;
                    comment.UserCpf = Session.Cpf;
                    comment.Comment = "";
                    comment.Resposta = tb_resposta.Text;
                    comment.Status = true;
                    classes.ComentarioList.Add(comment);
                    FormPrincipal.MudarForm("avalie", new ViewPost(post.Id));
                }
                else
                {
                    MessageBox.Show("ja tem candango, edite\nEm branco é bichinho de goiaba");
                }
            }
            else
            {
                MessageBox.Show("tem que logar");
            }

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
           
            if (Session.Online)
            {
                if (this.comment != null && (tb_resposta.Text.Trim() != ""))
                {
                    MessageBox.Show("senhor, foi editado");
                    comment.Resposta = tb_resposta.Text;
                }
                else
                {
                    MessageBox.Show("senhor, digite o comeentario");
                }
            }
            else
            {
                MessageBox.Show("tem que logar");
            }

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            classes.ComentarioList.Remove(Session.Cpf, post.Id);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

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

        private void lb_like_Click(object sender, EventArgs e)
        {

        }

        private void lb_deslike_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_1;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_2;
        }

        private void Tb_resposta_TextChanged(object sender, EventArgs e)
        {
            tb_resposta.MaxLength = 500;
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
