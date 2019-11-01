using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_do_projeto
{
    public partial class FormNav : Form
    {
        public FormNav()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void CardsModulos1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormHome fh = new FormHome();
            fh.TopLevel = false;
            panelHome.Controls.Add(fh);
            fh.Show();

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void PanelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fazer login");
        }
    }
}
