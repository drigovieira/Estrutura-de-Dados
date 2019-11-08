using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Publi : UserControl
    {
        private string nomeCompany;
        private int ID;
        public Publi(string Nome, int index)
        {
            nomeCompany = Nome;
            ID = index;
            InitializeComponent();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {
            NomeEmpresa.Text = nomeCompany;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            alimentos.Visualizar perfil = new alimentos.Visualizar();
            FormPrincipal.MudarForm("alimentos", perfil);
        }
    }
}
