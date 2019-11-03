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
            panel4.Height = 180;
            int i = 0;
            foreach (var item in classes.PostList.selectAll())
            {
                if (i > 8)
                    break;               
                PostCard a = new PostCard(item.Id);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel4.Height = panel4.Height + 180;
                panel4.Controls.Add(a);
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
                panel4.Height = 180;
                panel4.Controls.Clear();
                int i = 0;
                foreach (var item in classes.PostList.selectAll())
                {
                    if (i > 8)
                        break;
                    PostCard a = new PostCard(item.Id);
                    a.Location = new Point(0, (y));
                    y = y + a.Height + 5;
                    panel4.Height = panel4.Height + 180;
                    panel4.Controls.Add(a);
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
    }
}
