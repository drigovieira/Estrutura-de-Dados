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
  


        public FormEventos()
        {
            InitializeComponent();

            ListaDePost = Classes.Eventos_List.PosterAtivo;
            ListaDePost.Reverse();

          


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
            panel_center.Height = 180;
            int i = 0;

            foreach (var item in ListaDePost)
            {
                Post_Card a = new Post_Card(item.Id);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }
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

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
