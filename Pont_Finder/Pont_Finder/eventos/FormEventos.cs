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
    public partial class FormEventos : Form
    {
        int y = 5;
        private List<Classes.CoEvento> ListaDePost;


        
        private int pagTotal;
        private int pagAtual;
        //quantidade de cards por pag
        private int pagQuant;

        int local = 0;
        int leftcontrol = 8;
        int let = 0;
        int let2 = 0;

        Form anterior;


        public FormEventos()
        {
            InitializeComponent();

           

            CarregarPosts();

          


        }

        public void CarregarPosts()
        {

            ListaDePost = Classes.Eventos_List.PosterAtivo;
            ListaDePost.Reverse();

            pagQuant = 4;

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

            local = 0;

            panel_center.Controls.Clear();



            panel_center.Height = 180;
            int i = 0;

            foreach (var item in ListaDePost)
            {
                if (i >= pagQuant)
                    break;
                Post_Card a = new Post_Card(item.Id);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }





        }




        private void Btn_com_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("Eventos", new CadEmpresa());
            else
                MessageBox.Show("É necessário estar logado");          
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {


           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("Eventos", new ListEvent());
            else
                MessageBox.Show("É necessário estar logado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tb_cat.MaxLength = 50;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bt_prox_Click(object sender, EventArgs e)
        {
            if (pagAtual < pagTotal)
            {
                local = 0;
                panel_center.Controls.Clear();
                int pg = (pagAtual * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        Post_Card t1 = new Post_Card(ListaDePost[pg + i].Id);
                        t1.Location = new Point(0, local);
                        local = local + t1.Height + 5;
                        panel_center.Controls.Add(t1);
                    }

                }

                pagAtual++;
                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }




        }

        private void bt_ant_Click(object sender, EventArgs e)
        {
            if (pagAtual > 1)
            {
                local = 0;
                panel_center.Controls.Clear();

                int pg = ((pagAtual - 2) * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        Post_Card t1 = new Post_Card(ListaDePost[pg + i].Id);
                        t1.Location = new Point(0, local);
                        local = local + t1.Height + 5;
                        panel_center.Controls.Add(t1);
                    }
                }
                pagAtual--;

                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            ListaDePost.Clear();
            foreach (var item in Classes.Eventos_List.PosterAtivo)
            {
                if (item.Categoria.ToLower().Trim().Contains(tb_cat.Text.ToLower().Trim()) && (item.Idade.ToLower().Trim().Contains(tb_fai.Text.ToLower().Trim())) && (item.Categoria.ToLower().Trim().Contains(tb_cat.Text.ToLower().Trim())))
                {
                    ListaDePost.Add(item);
                }
            }


            int y = 5;
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
                Post_Card a = new Post_Card(item.Id);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }
        }

        private void Tb_bai_TextChanged(object sender, EventArgs e)
        {
            tb_bai.MaxLength = 50;
        }

        private void Tb_fai_TextChanged(object sender, EventArgs e)
        {
            tb_fai.MaxLength = 50;
        }
    }
}
