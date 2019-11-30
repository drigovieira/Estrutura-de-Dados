using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class EditeMeusPosts : Form
    {
        PostConstructor post;
        private bool img = false;
        private long postId;

        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");


        public EditeMeusPosts(long postId)
        {
            
            InitializeComponent();
            post = PostList.thisPostId(postId);
            this.postId = postId;
        }

        private void tb_resposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_postar_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditeMeusPosts_Load(object sender, EventArgs e)
        {
            
            label4.Text = Session.Nome;
            cb_pro.Text = post.Tipoproblema;
            tb_loc.Text = post.Localizacao;
            tb_des.Text = post.Desc;
            pb_icone.ImageLocation = post.Img;
            lb_hora.Text = post.Tempohora;
            NomePos.Text = post.Nome;
            imagemuser.ImageLocation = post.Imgperfil;

            if (post.Resolved)
                r.Checked = true;
            else
                nr.Checked = true;


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

        private void bt_postar_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click_1(object sender, EventArgs e)
        {
            
             
            post.Tipoproblema = cb_pro.SelectedItem.ToString();
            post.Localizacao = tb_loc.Text;
            post.Desc = tb_des.Text;

        
            if (img)
            {
                if (!Directory.Exists("..//..//avalie//data//imagens//posts"))
                    Directory.CreateDirectory("..//..//avalie//data//imagens//posts");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openFileDialog1.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;

              
                string link = "..//..//avalie//data//imagens//posts//" + postId + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }

            if(r.Checked)
                post.Resolved = true;
            
            if(nr.Checked)
                post.Resolved = false;

            MessageBox.Show("Post Alterado Com Sucesso");

            
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }

        private void pb_icone_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openFileDialog1.FileName;
                img = true;
            }
        }

        private void bt_remover_Click_1(object sender, EventArgs e)
        {
            post.Ativo = false;
            MessageBox.Show("Post Removido Com Sucesso");
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }

     

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (tb_loc.Text != "")
            {
                Mapa.Mapa map = new Mapa.Mapa(tb_loc.Text);
                map.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa localização não preenchida");
            }

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

        private void Tb_des_TextChanged(object sender, EventArgs e)
        {
            tb_des.MaxLength = 300;
        }
    }
}
