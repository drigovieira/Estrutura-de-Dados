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
        static Color barra = Color.FromArgb(64, 64, 64);
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
            label1.Text = "";
            formHome fh = new formHome();
            fh.TopLevel = false;
            panelHome.Controls.Add(fh);
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            fCC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLogin fL = new formLogin();
            fL.ShowDialog();
            if (Session.Id != -1)
            {
                button4.Visible = false;
                button1.Visible = false;
                label1.Text = Session.Nome;
            }
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            XmlLi xmlli = new XmlLi();
            //final do programa salvando...
            xmlli.Drop();
            int cont = 0;
            foreach (var item in UserList.selectAll())
            {
                xmlli.Add(cont, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo);
                cont++;
            }

            MessageBox.Show("Dados Salvos");
           

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

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
                    navbar.BackColor = Color.FromArgb(0, 120, 215);
                    break;

                case "Hospedagem":
                    FormHospedagem fHosp = new FormHospedagem();
                    {
                        fHosp.TopLevel = false;
                    }
                    painel.Controls.Add(fHosp);
                    fHosp.Show();
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Mudar();
        }
    }
}
