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
    public partial class formservicos : Form
    {
        private int y = 5;
        public formservicos()
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
            Service s = new Service();
            s.Id = 0;
            s.Tipo = "ADS";
            s.Valor = 200.00;
            s.Detalhes = "Análise e desenvolvimento de sistemas";
            s.Sugestoes = 2;
            s.Visualizacoes = 200;
            s.Like = 12;
            s.Avaliacao = 4;
            s.Ativo = true;

            classes.ServiceList.Add(s);

         
            s.Id = 1;
            s.Tipo = "ADM";
            s.Valor = 300.00;
            s.Detalhes = "Administrador";
            s.Sugestoes = 2;
            s.Visualizacoes = 200;
            s.Like = 12;
            s.Avaliacao = 4;
            s.Ativo = true;

            classes.ServiceList.Add(s);



            foreach (var item in classes.ServiceList.selectAll())
            {
                postcard a = new postcard( item.Tipo,  item.Detalhes,  item.Valor);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel4.Height = panel4.Height + 180;
                panel4.Controls.Add(a);
            }
          
        }
    }
}
