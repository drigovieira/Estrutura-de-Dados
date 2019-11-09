using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormServicos : Form
    {
        private List<classes.Post> ListaDePost;
        
        private int y = 5;
        public FormServicos()
        {
            InitializeComponent();
            if (Session.Online)
            {
                classes.Empresa emp = classes.ListaEmpresa.selectCpf(Session.Cpf);
                if (emp == null)
                    bt_cadEmpresa.Enabled = true;               
                else
                    bt_cadEmpresa.Enabled = false;               
            }

            ListaDePost = classes.PostList.Posts;
            ListaDePost.Reverse();
        }

        private void Formservicos_Load(object sender, EventArgs e)
        {
            panel_center.Height = 180;
            int i = 0;
            
            foreach (var item in ListaDePost)
            {
                if (i > 8)
                    break;               
                PostCard a = new PostCard(item.Id);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
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
                SolicitarServico solicservico = new SolicitarServico();
                solicservico.ShowDialog();
            }
            else
            {
                MessageBox.Show("É necessário estar logado para solicitar um Serviço");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            y = 5;
            panel_center.Height = 180;
            panel_center.Controls.Clear();
            int i = 0;
            foreach (var item in ListaDePost)
            {
                if (item.Titulo.ToLower().Trim().Contains(tb_pesquisar.Text.ToLower().Trim()))
                {
                    if (i > 8)
                        break;
                    PostCard a = new PostCard(item.Id);
                    a.Location = new Point(0, (y));
                    y = y + a.Height + 5;
                    panel_center.Height = panel_center.Height + 180;
                    panel_center.Controls.Add(a);
                    i++;
                }             
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
                MessageBox.Show("É necessário estar logado para solicitar um Serviço");          
        }
    }
}
