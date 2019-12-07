using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pont_Finder.avalie;

namespace Pont_Finder
{
    public partial class FormAvalie : Form
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

        public FormAvalie()
        {
            local = 5;
            

            InitializeComponent();
            CarregarPost();

         




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                avalie.FormPostar avaliepost = new FormPostar();
                FormPrincipal.MudarForm("Reclame", avaliepost);
            }
            else
            {
                MessageBox.Show("Por Favor, Efetue o Login para Realizar um Post");
                
            }



        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CarregarPost();

          


            /*t1.Top = let * let2;
            let = 24;
            let2 = 24;
            t1.Left = 5;
            leftcontrol = 0;
            leftcontrol = leftcontrol;*/
       


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void d_Click(object sender, EventArgs e)
        {
            
        }

        public void CarregarPost()
        {


            ListaDePost = PostList.PosterAtivo;
            ListaDePost.Reverse();

            pagQuant = 3;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                avalie.MeusPost avaliepost = new MeusPost();
                FormPrincipal.MudarForm("Reclame", avaliepost);
            }
            else
            {
                MessageBox.Show("Por Favor, Efetue o Login para visualizar seus posts");
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

        private void Tb_CatS_Enter(object sender, EventArgs e)
        {

        }

        private void Tb_CatS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cb_problemas.Text.Equals("!log"))
                {
                    Session.Login("admin", "admin");
                    FormPrincipal.MudarForm("Reclame", new FormAvalie());
                }


                ListaDePost.Clear();
                foreach (var item in PostList.PosterAtivo)
                {
                    if (item.Tipoproblema.ToLower().Trim().Contains(cb_problemas.Text.ToLower().Trim()))
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
        }

        private void Tb_CatS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {

            ListaDePost.Clear();
            foreach (var item in PostList.PosterAtivo)
            {
                if (item.Tipoproblema.ToLower().Trim().Contains(cb_problemas.Text.ToLower().Trim()))
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FormAvalie_Load(object sender, EventArgs e)
        {

        }

        private void Databox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Databox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListaDePost.Clear();
            foreach (var item in PostList.PosterAtivo)
            {
                if (item.Tempohora.ToLower().Trim().Contains(Databox.Text.ToLower().Trim()))
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



        public void LoadTop3()
        {
            ListaDePost = PostList.PosterAtivo;
            ListaDePost.Reverse();

            pagQuant = 3;

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

            top3panel.Controls.Clear();
            int i = 0;
            foreach (var item in ListaDePost)
            {
                if (i >= pagQuant)
                    break;
                UserControl1 t1 = new UserControl1(item.Id);
                t1.Location = new Point(0, local);
                local = local + t1.Height + 5;
                top3panel.Controls.Add(t1);
                i++;
            }

        }

        public void OrganizeTop3()
        {
            ListaDePost.Clear();

            foreach (var item in PostList.PosterAtivo)
            {
                
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
                top3panel.Height = top3panel.Height + 180;
                top3panel.Controls.Add(a);
                i++;
            }

        }
    }
}


