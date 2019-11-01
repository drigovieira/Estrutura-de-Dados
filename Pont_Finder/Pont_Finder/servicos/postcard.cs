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
    public partial class postcard : UserControl
    {
        private string tipo;
        private string detalhes;
        private double valor;
        private int id;
        private int sugestoes;
        private int visualizacoes;
        private long likes;
        private short avaliacao;
        private bool ativo;
        private string image;

        Bitmap up = Properties.Resources.upgrey;
        Bitmap down = Properties.Resources.downgrey;
        Bitmap upv = Properties.Resources.upblue;
        Bitmap downv = Properties.Resources.downred;


        public postcard(int id)
        {
            classes.Post post = new classes.Post();
            post = classes.PostList.SelectId(id);
            this.tipo = post.Titulo;
            this.detalhes = post.Detalhes;
            this.valor = post.Valor;
            this.id = post.Id;
            this.likes = post.Likes;
            this.ativo = post.Ativo;
            this.image = post.Image;
            InitializeComponent();
            if (post.Image != null)
                pb_icone.ImageLocation = post.Image;
            else
                pb_icone.ImageLocation = "..//..//servicos//data//images//posts//offImage.png";



            pb_icone.Load();


            pb_up.Image = up;
            pb_down.Image = down;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Visualizacoes_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //botao de likes
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            lb_titulo.Text = this.tipo;
            lb_descricao.Text = this.detalhes;
            lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.valor);
            lb_like.Text = this.likes+"";
            
            lb_username.Text = "none";
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tiposervico_Click(object sender, EventArgs e)
        {

        }

        private void like_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(pb_up.Image == up)
            {

                classes.Post post = classes.PostList.SelectId(this.id);
                int vLike = post.vLike(Session.Cpf);
                post.like(1, Session.Cpf);
                likes = post.Likes;

                pb_up.Image = upv;
                pb_down.Image = down;
                lb_like.ForeColor = System.Drawing.Color.Blue;
                
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pb_down.Image == down)
            {
                classes.Post post = classes.PostList.SelectId(this.id);
                int vLike = post.vLike(Session.Cpf);
                post.like(-1, Session.Cpf);
                likes = post.Likes;

                pb_up.Image = up;
                pb_down.Image = downv;
                lb_like.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void valor_Click(object sender, EventArgs e)
        {

        }

        private void visualizacoes_Click_1(object sender, EventArgs e)
        {

        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
