using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Pont_Finder.avalie.classes;
using Pont_Finder.avalie.User_Control;
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
        private List<Comentario> ListaDePost;
        classes.Comentario comment;

        private int pagTotal;
        private int pagAtual;
        //quantidade de cards por pag
        private int pagQuant;

        int local = 0;
        int leftcontrol = 8;
        int let = 0;
        int let2 = 0;

        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");
        long postIdC;

        public ViewPost(long postId)
        {

            

            InitializeComponent();

            post = PostList.thisPostId(postId);

            postIdC = postId;
            


            CarregarComentario();
            FiltroComentario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregarComentario();
            FiltroComentario();
        }

        private void ViewPost_Load(object sender, EventArgs e)
        {
            Recca();

        }

        public void Recca()
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






            
            
            



        }

        public void CarregarComentario()
        {


            ListaDePost = ComentariosList.PosterAtivo;
            ListaDePost.Reverse();

            pagQuant = 3;

            pagTotal = ListaDePost.Count;
            if ((pagTotal % pagQuant) != 0)
            {
                pagTotal = (pagTotal / pagQuant);
                pagTotal++;
            }
            else
            {
                pagTotal = pagTotal / pagQuant;
            }
            pagAtual = 1;

            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;

            local = 0;

            painelcoment.Controls.Clear();
            int i = 0;
            foreach (var item in ListaDePost)
            {
                if (i >= pagQuant)
                    break;
                Card_comentario t1 = new Card_comentario(item.Idcoment);
                t1.Location = new Point(0, local);
                local = local + t1.Height + 5;
                painelcoment.Controls.Add(t1);
                i++;
            }

        }

        public void FiltroComentario()
        {
            ListaDePost.Clear();

            foreach (var item in ComentariosList.Poster)
            {
                if ((item.PostId == postIdC))
                {
                    ListaDePost.Add(item);
                }
                
            }

            int y = 5;
            painelcoment.Height = 180;
            painelcoment.Controls.Clear();
            int i = 0;

            ListaDePost.Reverse();

            pagTotal = ListaDePost.Count;
            if ((pagTotal % pagQuant) != 0)
            {
                pagTotal = (pagTotal / pagQuant);
                pagTotal++;
            }
            else
            {
                pagTotal = pagTotal / pagQuant;
            }
            pagAtual = 1;

            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;


            foreach (var item in ListaDePost)
            {
                if (i >= pagQuant)
                    break;
                Card_comentario a = new Card_comentario(item.Idcoment);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                painelcoment.Height = painelcoment.Height + 180;
                painelcoment.Controls.Add(a);
                i++;
            }
            
        }



        private void bt_editar_Click(object sender, EventArgs e)
        {
           
            

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
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

        private void bt_postar_Click_1(object sender, EventArgs e)
        {
            Comentario post = new Comentario();

            post.UserCpf = Session.Cpf;
            post.PostId = postIdC;
            post.Idcoment = ComentariosList.Poster.Count(); ;
            post.Data = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            post.Comment = tb_resposta.Text;
            post.ImgUser = Session.Image;
            post.Username = Session.Nome;
            post.Ativo = true;

            ComentariosList.PostAdd(post);

            CarregarComentario();
            FiltroComentario();
            tb_resposta.Text = "";
        }

        private void bt_prox_Click(object sender, EventArgs e)
        {
            if (pagAtual < pagTotal)
            {
                local = 0;
                painelcoment.Controls.Clear();
                int pg = (pagAtual * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        Card_comentario t1 = new Card_comentario(ListaDePost[pg + i].Idcoment);
                        t1.Location = new Point(0, local);
                        local = local + t1.Height + 5;
                        painelcoment.Controls.Add(t1);
                    }

                }

                pagAtual++;
                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }
        }

        private void bt_ant_Click(object sender, EventArgs e)
        {
            if (pagAtual > 1)
            {
                local = 0;
                painelcoment.Controls.Clear();

                int pg = ((pagAtual - 2) * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        Card_comentario t1 = new Card_comentario(ListaDePost[pg + i].Idcoment);
                        t1.Location = new Point(0, local);
                        local = local + t1.Height + 5;
                        painelcoment.Controls.Add(t1);
                    }
                }
                pagAtual--;

                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }
    }
}
