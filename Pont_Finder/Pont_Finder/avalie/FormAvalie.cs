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

                //formPostar fp = new formPostar();
                //fp.ShowDialog();

                formPostar f2 = new formPostar(); //be careful on this line!!
   
                f2.ShowDialog();
                FormPrincipal.MudarForm("avalie", new FormAvalie());
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
            local = 0;

            panel3.Controls.Clear();

            List<PostConstructor> lista = new List<PostConstructor>();
            lista = PostList.PosterAtivo;
            lista.Reverse();

            foreach (var item in lista)
            {
                UserControl1 t1 = new UserControl1(item.Id);
                t1.Location = new Point(0, local);
                local = local + t1.Height + 5;
                panel3.Controls.Add(t1);
            }

        }

    }
}


