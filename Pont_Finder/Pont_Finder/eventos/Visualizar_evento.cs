using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class Visualizar_evento : Form
    {
       // private string nome, empresa, servicos, foto, status, tipo, nome_emp, fotos_emp, endereco_emp, descricao_emp, email_emp, logo_emp, ambiente;
        Classes.CoEvento post;

        private List<Classes.comentario> ListaPost;

        Classes.comentario coment;

        classes.CaEmpresa empresa;

        

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



        public Visualizar_evento(long postId)
        {

            
          
            InitializeComponent();
            post = Classes.Eventos_List.thisPostId(postId);
            empresa = classes.Empresa_List.forCnpj(post.Cnpj);
            postIdC = postId;

            //Evento:
            lb_nome_evento.Text = post.Nome;
            pb_principal.ImageLocation = post.Imagem1;
            lb_rs_boleto.Text = post.Valor;
            lb_descricao.Text = post.Descricao;
            lb_categoria.Text = post.Categoria;
            lb_data.Text = post.Data;
            lb_horario.Text = post.Horario;

            //Resolver:
            lb_emp_fantasia.Text = " " + empresa.Nome_Fantasia;
            check();


            CarregarComents();
            Filtro_comentario();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new eventos.FormEventos());
        }

        private void Visualizar_evento_Load(object sender, EventArgs e)
        {
            

        }

        private void Lb_rs_boleto_Click(object sender, EventArgs e)
        {

        }

        private void Bt_comprar_Click(object sender, EventArgs e)
        {
            if (Session.Online == true)
            {
                eventos.Tela_compra compevento = new Tela_compra(post.Id);
                FormPrincipal.MudarForm("eventos", compevento);
            }
            else
            {
                MessageBox.Show("É preciso estar logado para realizar a compra de ingressos!");
            }
        }

        public void check()
        {
            if (post.IngressoDispinivel == 0)
            {
                bt_comprar.Visible = false;
                esgotado.Visible = true;
            }
            else
            {
                bt_comprar.Visible = true;
                esgotado.Visible = false;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Bt_postar_Click(object sender, EventArgs e)
        {
            Classes.comentario post = new Classes.comentario();

            post.UserCpf = Session.Cpf;
            post.PostId = postIdC;
            post.Idcoment = Classes.comentario_list.Poster.Count();
            post.Data = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            post.Comment = tb_resposta.Text;
            post.ImgUser = Session.Image;
            post.Username = Session.Nome;
            post.Ativo = true;

            Classes.comentario_list.PostAdd(post);

            
            Filtro_comentario();
            tb_resposta.Text = "";
        }

        public void CarregarComents()
        {
            ListaPost = Classes.comentario_list.PosterAtivo;
            ListaPost.Reverse();

            pagQuant = 3;

            pagTotal = ListaPost.Count;
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
            foreach (var item in ListaPost)
            {
                if (i >= pagQuant)
                    break;
                User_Card.comentarios_eventos t1 = new User_Card.comentarios_eventos(item.Idcoment);
                t1.Location = new Point(0, local);
                local = local + t1.Height + 5;
                painelcoment.Controls.Add(t1);
                i++;
            }
        }

        public void Filtro_comentario()
        {
            ListaPost.Clear();

            foreach (var item in Classes.comentario_list.Poster)
            {
                if ((item.PostId == postIdC))
                {
                    ListaPost.Add(item);
                }
                else
                {
                    ListaPost.Remove(item);
                }
            }



            int y = 5;
            painelcoment.Height = 180;
            painelcoment.Controls.Clear();
            int i = 0;

            ListaPost.Reverse();

            pagTotal = ListaPost.Count;
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


            foreach (var item in ListaPost)
            {
                if (i >= pagQuant)
                    break;
                User_Card.comentarios_eventos a = new User_Card.comentarios_eventos(item.Idcoment);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                painelcoment.Height = painelcoment.Height + 180;
                painelcoment.Controls.Add(a);
                i++;
            }
        }

        private void Visualizar_evento_Load_1(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
