using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormServicos : Form
    {
        private int y = 5;
        public FormServicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Session.Id != -1)
            {

                button1.Visible = false;

            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formservicos_Load(object sender, EventArgs e)
        {
            panel_center.Height = 180;
            int i = 0;
            foreach (var item in classes.PostList.selectAll())
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
            {
                FormPost np = new FormPost();
                np.ShowDialog();

                y = 5;
                panel_center.Height = 180;
                panel_center.Controls.Clear();
                int i = 0;
                foreach (var item in classes.PostList.selectAll())
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
            else
            {
                MessageBox.Show("É nessessario estar logado para cadastrar um serviço");
            }

           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                CadastrarEmpresa cadEmpresa = new CadastrarEmpresa();
                cadEmpresa.ShowDialog();
            }
            else
            {
                MessageBox.Show("É nessessario estar logado para cadastrar uma empresa");
              
                FormPrincipal.MudarForm("servicos", new FormCadEmpresa());
            }


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

        private void Button4_Click(object sender, EventArgs e)
        {
            classes.PostList.XmlSave();
            MessageBox.Show("Salvo com sucesso");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            classes.PostList.DropList();
            classes.PostList.XmlLoad();
            MessageBox.Show("Carregado com sucesso");
            FormPrincipal.MudarForm("servicos", new FormServicos());
            
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Stack<classes.Post> pilha = new Stack<classes.Post>();
            foreach (var item in classes.PostList.selectAll())
            {
                pilha.Push(item);
            }

            y = 5;
            panel_center.Height = 180;
            panel_center.Controls.Clear();
            int i = 0;
            foreach (var item in pilha)
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
    }
}
