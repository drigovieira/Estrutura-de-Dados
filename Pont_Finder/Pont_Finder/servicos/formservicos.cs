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
                empresa = classes.ListaEmpresa.ForCpf(Session.Cpf);            
            }
            else
            {
                empresa = null;  
                menu.Enabled = false;
            }

            if (empresa != null)
                bt_empresa.Text = "Gerenciar Empresa";
       

            pagQuant = 8;
            LoadPosts();


        }

        private void Formservicos_Load(object sender, EventArgs e)
        {
         
          
        }

   

        private void Button2_Click(object sender, EventArgs e)
        {
            if (empresa != null)
                FormPrincipal.MudarForm("servicos", new PerfilEmpresa(empresa.Cpf, new FormServicos()));
            else if (Session.Online)
                FormPrincipal.MudarForm("servicos", new FormCadEmpresa());
            else
                MessageBox.Show("É nessessario estar logado para cadastrar uma empresa");

        }

        private void button3_Click(object sender, EventArgs e)
        {
                FormPrincipal.MudarForm("servicos", new SolicitarServico());      
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (rb_semfiltro.Checked || rb_servico.Checked || rb_recente.Checked)
            {
                ListaDePost.Clear();
                foreach (var item in classes.PostList.PostsAtivo)
                {
                    if (item.Titulo.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListaDePost.Add(item);
                    }
                }
                ListaDePost.Reverse();
                Pesquisa();
            }
            else if (rb_antigo.Checked)
            {
                ListaDePost.Clear();
                foreach (var item in classes.PostList.PostsAtivo)
                {
                    if (item.Titulo.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListaDePost.Add(item);
                    }
                }
                Pesquisa();
            }
            else if (rb_empresa.Checked)
            {
                ListaDePost.Clear();
                foreach (var item in classes.PostList.PostsAtivo)
                {
                    classes.Empresa emp = classes.ListaEmpresa.ForCpf(item.Cpf);
                    if (emp.Nome.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim())
                        || emp.Nome.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListaDePost.Add(item);
                    }
                }
                ListaDePost.Reverse();
                Pesquisa();
            }
            else if (rb_categoria.Checked)
            {
                ListaDePost.Clear();
                foreach (var item in classes.PostList.PostsAtivo)
                {
                    classes.Empresa emp = classes.ListaEmpresa.ForCpf(item.Cpf);
                    if (emp.Categoria.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                    {
                        ListaDePost.Add(item);
                    }
                }
                ListaDePost.Reverse();
                Pesquisa();
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

        
        private void Bt_ant_Click(object sender, EventArgs e)
        {
            GoPag("anterior");
        }

        private void Bt_prox_Click(object sender, EventArgs e)
        {

            GoPag("proxima");
           


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
                if (rb_semfiltro.Checked || rb_servico.Checked || rb_recente.Checked)
                {
                    ListaDePost.Clear();
                    foreach (var item in classes.PostList.PostsAtivo)
                    {
                        if (item.Titulo.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                        {
                            ListaDePost.Add(item);
                        }
                    }
                    ListaDePost.Reverse();
                    Pesquisa();
                }
                else if (rb_antigo.Checked)
                {
                    ListaDePost.Clear();
                    foreach (var item in classes.PostList.PostsAtivo)
                    {
                        if (item.Titulo.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                        {
                            ListaDePost.Add(item);
                        }
                    }
                    Pesquisa();
                }
                else if (rb_empresa.Checked)
                {
                    ListaDePost.Clear();
                    foreach (var item in classes.PostList.PostsAtivo)
                    {
                        classes.Empresa emp = classes.ListaEmpresa.ForCpf(item.Cpf);
                        if (emp.Nome.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim())
                            || emp.Nome.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                        {
                            ListaDePost.Add(item);
                        }
                    }
                    ListaDePost.Reverse();
                    Pesquisa();
                }
                else if (rb_categoria.Checked)
                {
                    ListaDePost.Clear();
                    foreach (var item in classes.PostList.PostsAtivo)
                    {
                        classes.Empresa emp = classes.ListaEmpresa.ForCpf(item.Cpf);
                        if (emp.Categoria.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                        {
                            ListaDePost.Add(item);
                        }
                    }
                    ListaDePost.Reverse();
                    Pesquisa();
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
            FormPrincipal.MudarForm("servicos", new PerfilEmpresa(empresa.Cpf, new FormServicos()));
        }

      

        private void Lb_pag_Click(object sender, EventArgs e)
        {

        }

        private void Bt_proxFull_Click(object sender, EventArgs e)
        {
            GoPag("ultima");
        }

        private void Bt_antFull_Click(object sender, EventArgs e)
        {
            GoPag("primeira");
        }

        public void LoadPosts()
        {
            
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
            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;

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

        public void Pesquisa()
        {
            panel_center.Controls.Clear();
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

            panel_center.Height = 180;
            int i = 0;
            y = 5;
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


        public void GoPag(string p)
        {
            int pagina;

            if (p.Equals("ant") || p.Equals("anterior"))
                pagina = -1;           
            else if (p.Equals("prox") || p.Equals("proxima"))
                pagina = -2;
            else if (p.Equals("1") || p.Equals("primeira"))
                pagina = 1;
            else if (p.Equals("0") || p.Equals("ultima"))
                pagina = pagTotal;
            else
                pagina = int.Parse(p);
            
            
            if (ListaDePost.Count > pagTotal)
            {
                if (pagina == 1 && (pagAtual > 1))
                {
                    y = 5;
                    panel_center.Height = 180;
                    panel_center.Controls.Clear();

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
                    lb_pag.Text = "Pagina " + 1 + " de " + pagTotal;
                    pagAtual = 1;

                }
                else if (pagina == pagTotal && (pagAtual < pagTotal) )
                {
                    y = 5;
                    panel_center.Height = 180;
                    panel_center.Controls.Clear();

                    int pg = ((pagTotal - 1) * pagQuant);
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

                    pagAtual = pagTotal;
                    lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;

                }
                else if (pagina == -1)
                {
                    if (pagAtual > 1)
                    {
                        y = 5;
                        panel_center.Height = 180;
                        panel_center.Controls.Clear();

                        int pg = ((pagAtual - 2) * pagQuant);

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
                else if (pagina == -2)
                {
                    if (pagAtual < pagTotal)
                    {
                        y = 5;
                        panel_center.Height = 180;
                        panel_center.Controls.Clear();

                        int pg = (pagAtual * pagQuant);

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
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormSolicitados());
        }

        private void Bt_solicitados_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormSolicitados());
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            ListaDePost.Clear();
            ListaDePost = classes.PostList.top();
            Pesquisa();
        }
    }
}
