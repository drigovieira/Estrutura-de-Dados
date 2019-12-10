using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class MeusPost : Form
    {

        private List<PostConstructor> ListaDePost;
        private int pagTotal;
        private int pagAtual;
        //quantidade de cards por pag
        private int pagQuant;
        


        int local = 0;
        int leftcontrol = 8;
        int let = 0;
        int let2 = 0;


        public MeusPost()
        {
            InitializeComponent();
            Carregar();
            Organized();
            
        }

        public void Carregar()
        {

            ListaDePost = PostList.PosterAtivo;
            ListaDePost.Reverse();

            pagQuant = 2;

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

            panel3.Controls.Clear();
            int i = 0;
            foreach (var item in ListaDePost)
            {
                if (i >= pagQuant)
                    break;
                UserControl1 t1 = new UserControl1(item.Id);
                t1.Location = new Point(0, local);
                
                local = local + t1.Height + 5;
                panel3.Controls.Add(t1);
                i++;
            }
        }    
        

        public void Organized()
        {
           

                ListaDePost.Clear();
                foreach (var item in PostList.PosterAtivo)
                {
                    if (item.Nome.ToLower().Trim().Contains(Session.Nome.ToLower().Trim()))
                    {
                        ListaDePost.Add(item);
                    }
                }

                int y = 5;
                panel3.Height = 180;
                panel3.Controls.Clear();
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
                    UserControl1 a = new UserControl1(item.Id);
                    a.Location = new Point(0, (y));
                    y = y + a.Height + 5;
                    panel3.Height = panel3.Height + 180;
                    panel3.Controls.Add(a);
                    i++;
                }
            




        }

    

        private void bt_prox_Click(object sender, EventArgs e)
        {
            if (pagAtual < pagTotal)
            {
                local = 0;
                panel3.Controls.Clear();
                int pg = (pagAtual * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        UserControl1 t1 = new UserControl1(ListaDePost[pg + i].Id);
                        t1.Location = new Point(0, local);
                        local = local + t1.Height + 5;
                        panel3.Controls.Add(t1);
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
                panel3.Controls.Clear();

                int pg = ((pagAtual - 2) * pagQuant);

                for (int i = 0; i < pagQuant; i++)
                {
                    if (pg + i < ListaDePost.Count)
                    {
                        UserControl1 t1 = new UserControl1(ListaDePost[pg + i].Id);
                        t1.Location = new Point(0, local);
                        local = local + t1.Height + 5;
                        panel3.Controls.Add(t1);
                    }
                }
                pagAtual--;

                lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
            }
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

