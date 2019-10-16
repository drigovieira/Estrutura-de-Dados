using Pont_Finder.servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class FormPrincipal : Form
    {
        
        static Color barra = Color.FromArgb(64,64,64);
        static Panel navbar;
        static Panel painel;


        public FormPrincipal()
        {
            InitializeComponent();
            panel1.BackColor = barra;
            navbar = panel1;
            painel = panelHome;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formHome fh = new formHome();
            fh.TopLevel = false;
            panelHome.Controls.Add(fh);
            fh.Show();
        }

        public void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //public static void servicos()
        //{
        //    navbar.BackColor = Color.Blue;
        //}

        public static void Mudar(String x = "")
        {
            painel.Controls.Clear();
            switch (x)
            {
                case "Alimentos":
                    navbar.BackColor = Color.Red;
                    break;
                case "Serviços":
                    formservicos form = new formservicos
                    {
                        TopLevel = false
                    };
                    painel.Controls.Add(form);
                    form.Show();
                    navbar.BackColor = Color.Blue;

                    break;
                case "Hospedagem":
                    navbar.BackColor = Color.LimeGreen;
                    break;
                case "Eventos":
                    navbar.BackColor = Color.Blue;
                    break;
                case "Avalie":
                    navbar.BackColor = Color.Blue;
                    break;
                default:
                    formHome fh = new formHome
                    {
                        TopLevel = false
                    };
                    painel.Controls.Add(fh);
                    fh.Show();
                    navbar.BackColor = barra;
                    break;

            }
        }

        public static void padrao()
        {
            navbar.BackColor = barra;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mudar();
        }
    }
}
