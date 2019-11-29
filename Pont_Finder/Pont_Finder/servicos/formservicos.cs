using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormServicos : Form
    {
        private List<classes.Post> ListaDePost;
        private int pagTotal;
        private int pagAtual;
        //quantidade de cards por pag
        private int pagQuant;

        classes.Empresa empresa;


        private int y = 5;
        public FormServicos()
        {
           
            InitializeComponent();
            if (Session.Online)
            {
                empresa = classes.ListaEmpresa.selectCpf(Session.Cpf);            
            }
            else
            {
                empresa = null;
                bt_mensagens.Enabled = false;
                bt_solicitados.Enabled = false;
                bt_servicos.Enabled = false;
                bt_empresa.Enabled = false;
            }

            if (empresa == null)
            {
                bt_solicitados.Enabled = false;
                bt_servicos.Enabled = false;
            }
            else
            {
                bt_empresa.Enabled = false;

            }

            pagQuant = 8;

            ListaDePost = classes.PostList.PostsAtivo;
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

            lb_pag.Text = "Pagina "+ pagAtual +" de "+ pagTotal;


        }

        private void Formservicos_Load(object sender, EventArgs e)
        {
            panel_center.Height = 180;
            int i = 0;
            
            foreach (var item in ListaDePost)
            {
                if (i >= pagQuant)
                    break;               
                PostCard a = new PostCard(item.Id);
                a.Location = new Point(0, (y));
                y = y + a.Height + 10;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;            
            }
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("servicos", new FormPost());           
            else
                MessageBox.Show("É nessessario estar logado para cadastrar um serviço");                   
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("servicos", new FormCadEmpresa());            
            else
                MessageBox.Show("É nessessario estar logado para cadastrar uma empresa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                FormPrincipal.MudarForm("servicos", new SolicitarServico());
            }
            else
            {
                MessageBox.Show("É necessário estar logado para solicitar um Serviço");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (tb_pesquisar.Text.Equals("!log"))
            {
                Session.Login("admin", "admin");
                FormPrincipal.MudarForm("servicos", new FormServicos());               

            }


            ListaDePost.Clear();
            foreach (var item in classes.PostList.PostsAtivo)
            {
                if (item.Titulo.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                {
                    ListaDePost.Add(item);
                }
            }

            y = 5;
            panel_center.Height = 180;
            panel_center.Controls.Clear();
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
                PostCard a = new PostCard(item.Id);
                a.Location = new Point(0, (y));
                y = y + a.Height + 10;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }
        }

        private void Tb_pesquisa_Enter(object sender, EventArgs e)
        {
            tb_pesquisar.Text = "";
        }

        private void Tb_pesquisa_Leave(object sender, EventArgs e)
        {
            tb_pesquisar.Text = "Pesquisar";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("servicos", new FormUserCards());          
            else
                MessageBox.Show("É necessário estar logado para gerenciar serviços");          
        }

        private void Bt_ant_Click(object sender, EventArgs e)
        {
            if (pagAtual > 1)
            {
                y = 5;
                panel_center.Height = 180;
                panel_center.Controls.Clear();

                int pg = ((pagAtual-2) * pagQuant);
                
                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        PostCard a = new PostCard(ListaDePost[pg + i].Id);
                        a.Location = new Point(0, (y));
                        y = y + a.Height + 10;
                        panel_center.Height = panel_center.Height + 180;
                        panel_center.Controls.Add(a);
                    }
                }
                pagAtual--;

                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }


        }

        private void Bt_prox_Click(object sender, EventArgs e)
        {

            if (pagAtual < pagTotal)
            {
                y = 5;
                panel_center.Height = 180;
                panel_center.Controls.Clear();

                int pg = (pagAtual* pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        PostCard a = new PostCard(ListaDePost[pg + i].Id);
                        a.Location = new Point(0, (y));
                        y = y + a.Height + 10;
                        panel_center.Height = panel_center.Height + 180;
                        panel_center.Controls.Add(a);
                    }
                   
                }
               
                pagAtual++;
                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }
           


        }

        private void Tb_pesquisar_TextChanged(object sender, EventArgs e)
        {
            tb_pesquisar.MaxLength = 45;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tb_pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tb_pesquisar.Text.Equals("!log"))
                {
                    Session.Login("admin", "admin");
                    FormPrincipal.MudarForm("servicos", new FormServicos());
                }


                ListaDePost.Clear();
                foreach (var item in classes.PostList.PostsAtivo)
                {
                    if (item.Titulo.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListaDePost.Add(item);
                    }
                }

                y = 5;
                panel_center.Height = 180;
                panel_center.Controls.Clear();
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
                    PostCard a = new PostCard(item.Id);
                    a.Location = new Point(0, (y));
                    y = y + a.Height + 10;
                    panel_center.Height = panel_center.Height + 180;
                    panel_center.Controls.Add(a);
                    i++;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new socialist.FormSociaListUser(-1));
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new socialist.FormSociaListEmpresa(-1, -1));
        }

        private void VisualizarPerfil_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new PerfilEmpresa());
        }

        private void EditarPerfil_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormEditarPerfil());
        }
    }
}
