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
    public partial class PostCard : UserControl
    {
        private classes.Post post;
        private classes.Empresa empresa;

        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");    
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");

        public PostCard(int id)
        {
            this.post = classes.PostList.thisSelectId(id);
            
            InitializeComponent();

            if (this.post.Image != null)
                pb_icone.ImageLocation = this.post.Image;
            else
                pb_icone.ImageLocation = "..//..//servicos//data//images//posts//offImage.png";

   
            lb_like.Text = this.post.Joinha + "";
            lb_deslike.Text = this.post.DeJoinha + "";

            lb_titulo.Text += " "+ this.post.Titulo;

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
           
            lb_data.Text = "Postado em: " + this.post.Data;

            //caractere invisivel alt + 0160 ou " "
            string desc = this.post.Descricao.Replace("\n", " ").Replace(" ", " ");

            if (desc.Length > 80)
            {
                desc = desc.Substring(0, 115);
                desc = desc+"...";
            }
            
            lb_descricao.Text = "Descrição: " + desc;
            lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.post.Valor);

        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
     
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Dar Um Like
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

        private void pictureBox4_Click(object sender, EventArgs e)
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


        private void valor_Click(object sender, EventArgs e)
        {

        }


        private void Lb_descricao_Click(object sender, EventArgs e)
        {

        }

      

        private void Lb_data_Click(object sender, EventArgs e)
        {

        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(this.post.Id, new FormServicos()));
        }

        private void PostCard_Load(object sender, EventArgs e)
        {
            if (this.post.Cnpj == -1)
            {
                User u = UserList.selectCpf(this.post.Cpf);
                pb_user.ImageLocation = u.Image;
                lb_username.Text = u.Nome;
            }
            else
            {
                empresa = classes.ListaEmpresa.ForCpf(this.post.Cpf);
                pb_user.ImageLocation = empresa.Image;
                lb_username.Text = empresa.Nome;
                lb_tipo.Text = "Categoria: "+ empresa.Categoria;

            }

        }

        private void lb_titulo_Click(object sender, EventArgs e)
        {

        }

        private void lb_deslike_Click(object sender, EventArgs e)
        {

        }
    }
}
