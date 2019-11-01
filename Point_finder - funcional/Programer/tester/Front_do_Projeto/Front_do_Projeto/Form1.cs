using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_do_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormHome fh = new FormHome();
            fh.TopLevel = false;
            panelHome.Controls.Add(fh);
            fh.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FormLogin fL = new FormLogin();
            fL.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormCadastroUser fC = new FormCadastroUser();
            fC.ShowDialog();
        }
    }
}
