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

        Bitmap up = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");    
        Bitmap down = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap upv = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap downv = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");

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

            pb_up.Image = up;
            pb_down.Image = down;

            if (Session.Online)
            {
                long userlike = this.post.userLike(Session.Cpf);

                if (userlike == 1)
                    pb_up.Image = upv;               
                else if (userlike == -1)
                    pb_down.Image = downv;               
            }
           

            lb_data.Text = "Postado em: " + this.post.Data;
            lb_titulo.Text = this.post.Titulo;
            lb_descricao.Text = this.post.Descricao;
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
                if (pb_up.Image == upv)
                {                   
                    post.like(0, Session.Cpf);     
                    pb_up.Image = up;
                    pb_down.Image = down;
                }
                else
                {
                    post.like(1, Session.Cpf);               
                    pb_up.Image = upv;                 
                    pb_down.Image = down;
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
                if (pb_down.Image == downv)
                {                  
                    post.like(0, Session.Cpf);
                    pb_down.Image = down;
                    pb_up.Image = up;
                }
                else
                {                  
                    post.like(-1, Session.Cpf);              
                    pb_down.Image = downv;
                    pb_up.Image = up;
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
                classes.Empresa emp = classes.ListaEmpresa.selectCpf(this.post.Cpf);
                pb_user.ImageLocation = emp.Image;
                lb_username.Text = emp.Nome;

            }

        }

        private void lb_titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
