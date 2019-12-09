using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormVisualizarPost : Form
    {
        Form anterior;
        classes.Post post;
        classes.Empresa empresa;
        

        public FormVisualizarPost(int postId, Form anterior)
        {
            post = classes.PostList.SelectId(postId);
            empresa = classes.ListaEmpresa.ForCpf(post.Cpf);
            this.anterior = anterior;
            InitializeComponent();

            if (Session.Online)
            {
                if (post.Cpf == Session.Cpf)
                {
                    bt_negociar.Text = "Editar Post";
                }
                if (empresa.Cpf == Session.Cpf)
                {
                    bt_solicitar.Text = "Solicitações";
                }
            }              
        }

        private void FormVisualizarPost_Load(object sender, EventArgs e)
        {
            lb_titulo.Text = post.Titulo;
            if (post.Valor == 0)
            {
                lb_valor.Text = "A Combinar";
            }
            else
            {
                lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.post.Valor);
            }
            pb_icone.ImageLocation = post.Image;
            lb_descricao.Text = post.Descricao;

            lb_categoria.Text = empresa.Categoria;

            lb_fantasia.Text += empresa.NomeFantasia;
            lb_email.Text += empresa.Email;
            lb_endereco.Text += empresa.Endereco;
            lb_telefone.Text += empresa.Telefone;
            pb_empresa.ImageLocation = empresa.Image;

        }

        private void pb_icon_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_Endereco_Click(object sender, EventArgs e)
        {

        }

        private void Bt_voltar_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", anterior);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (anterior.Name.Equals("FormServicos"))
            {
                FormPrincipal.MudarForm("servicos", new FormServicos());
            }
            else
            {
                FormPrincipal.MudarForm("servicos", anterior);
            }
           
        }

        private void Btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            
            btn_back.Image = Model.Img_Voltar_Click;
        }

        private void Btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Model.Img_Voltar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (empresa.Cpf == Session.Cpf)
                {
                    FormPrincipal.MudarForm("servicos", new FormSolicitadosEmpresa());
                }
                else
                {
                    FormPrincipal.MudarForm("servicos", new Solicitar_Sevico(post.Id, new FormVisualizarPost(post.Id, new FormServicos())));
                }
               
            }
            else
            {
                MessageBox.Show("Faça o Login Para Continuar");
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (Session.Cpf == post.Cpf)
                {
                    FormPrincipal.MudarForm("servicos", new servicos.FormPostEdit(post.Id, new FormVisualizarPost(post.Id, anterior)));
                }
                else
                {
                    bool existe = false;
                    foreach (var item in socialist.ChatList.Chats)
                    {
                        if (item.PostId == post.Id && item.CpfUser == Session.Cpf)
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (existe)
                    {
                        FormPrincipal.MudarForm("servicos", new socialist.FormSociaListUser(post.Id));
                        //MessageBox.Show("O chat já foi criado anteriormente");
                    }
                    else
                    {
                        socialist.Chat solicitacao = new socialist.Chat();
                        solicitacao.PostId = post.Id;
                        solicitacao.CpfUser = Session.Cpf;
                        socialist.ChatList.Chats.Add(solicitacao);
                        FormPrincipal.MudarForm("servicos", new socialist.FormSociaListUser(post.Id));
                        //MessageBox.Show("O chat foi criado com Sucesso!");
                    }


                }

            }
            else
            {
                MessageBox.Show("É necessário estar logado para enviar uma mensagem");
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new PerfilEmpresa(empresa.Cpf, new FormVisualizarPost(post.Id, anterior)));
        }

        private void Lb_email_Click(object sender, EventArgs e)
        {

        }

        private void Lb_valor_Click(object sender, EventArgs e)
        {

        }

        private void Lb_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Lb_descricao_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lb_categoria_Click(object sender, EventArgs e)
        {

        }
    }
}
