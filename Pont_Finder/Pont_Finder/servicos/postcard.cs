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
        private int id;
        private string titulo;
        private double valor;
        private string descricao;
        private bool ativo;
        private string image;
        private long cpf;
        private long cnpj;
        private DateTime data;
        private long likes;
        private List<long[]> listlikes = new List<long[]>();

        private long like;
        private long deslike;






        Bitmap up = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
     
        Bitmap down = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap upv = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap downv = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");


        public PostCard(int id)
        {
            classes.Post post = new classes.Post();
            post = classes.PostList.SelectId(id);
            this.titulo = post.Titulo;
            this.valor = post.Valor;
            this.id = post.Id;
            this.likes = post.Likes;
            this.ativo = post.Ativo;
            this.image = post.Image;
            this.data = post.Data;
            this.cpf = post.Cpf;
            this.cnpj = post.Cnpj;
            this.descricao = post.Descricao;


       
            InitializeComponent();


            if (post.Image != null)
                pb_icone.ImageLocation = post.Image;
            else
                pb_icone.ImageLocation = "..//..//servicos//data//images//posts//offImage.png";

            this.like = post.Joinha;
            this.deslike = post.DeJoinha;

            lb_like.Text = this.like + "";
            lb_deslike.Text = this.deslike + "";

            

            if (Session.Online)
            {
                long userlike = post.userLike(Session.Cpf);
                if (userlike == 1)
                {
                    pb_up.Image = upv;
                    pb_down.Image = down;
                   // lb_like.ForeColor = System.Drawing.Color.Blue;
                }
                else if (userlike == -1)
                {
                    pb_up.Image = up;
                    pb_down.Image = downv;
                   // lb_like.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                pb_up.Image = up;
                pb_down.Image = down;
            }

            lb_data.Text = "Postado em: " + data;

            lb_titulo.Text = this.titulo;
            lb_descricao.Text = this.descricao;
            lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.valor);



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
            //Like
            if (Session.Online)
            {
                if (pb_up.Image == upv)
                {
                    classes.Post post = classes.PostList.SelectId(this.id);
                    int vLike = post.vLike(Session.Cpf);
                    post.like(0, Session.Cpf);
                    lb_like.Text = "" + post.Joinha;
                    lb_deslike.Text = "" + post.DeJoinha;
                    pb_up.Image = up;
                    //lb_like.ForeColor = System.Drawing.Color.Blue;
                    pb_down.Image = down;
                }
                else
                {
                    classes.Post post = classes.PostList.SelectId(this.id);
                    int vLike = post.vLike(Session.Cpf);
                    post.like(1, Session.Cpf);
                    lb_like.Text = "" + post.Joinha;
                    lb_deslike.Text = "" + post.DeJoinha;
                    pb_up.Image = upv;
                    //lb_like.ForeColor = System.Drawing.Color.Blue;
                    pb_down.Image = down;
                }

               
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
                    classes.Post post = classes.PostList.SelectId(this.id);
                    int vLike = post.vLike(Session.Cpf);
                    post.like(0, Session.Cpf);
                    lb_like.Text = "" + post.Joinha;
                    lb_deslike.Text = "" + post.DeJoinha;
                    pb_down.Image = down;
                    //lb_like.ForeColor = System.Drawing.Color.Red;
                    pb_up.Image = up;
                }
                else
                {
                    classes.Post post = classes.PostList.SelectId(this.id);
                    int vLike = post.vLike(Session.Cpf);
                    post.like(-1, Session.Cpf);
                    lb_like.Text = "" + post.Joinha;
                    lb_deslike.Text = "" + post.DeJoinha;
                    pb_down.Image = downv;
                    //lb_like.ForeColor = System.Drawing.Color.Red;
                    pb_up.Image = up;
                }

                
            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
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

        private void Lb_descricao_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Lb_data_Click(object sender, EventArgs e)
        {

        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(id, new FormServicos()));
        }

        private void PostCard_Load(object sender, EventArgs e)
        {
            if (cnpj == -1)
            {
                User u = UserList.selectCpf(cpf);
                pb_user.ImageLocation = u.Image;
                lb_username.Text = u.Nome;
            }
            else
            {

                classes.Empresa emp = classes.ListaEmpresa.selectCpf(cpf);
                pb_user.ImageLocation = emp.Image;
                lb_username.Text = emp.Nome;

            }

        }

        private void lb_titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
