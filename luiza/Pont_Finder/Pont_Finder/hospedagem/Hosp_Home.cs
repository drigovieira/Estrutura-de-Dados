using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Hosp_Home : Form
    {
        public Hosp_Home()
        {
            InitializeComponent();
        }

        private void Hosp_Home_Load(object sender, EventArgs e)
        {
            
        }

        private void Bt_Cad_Empresa_Click(object sender, EventArgs e)
        {
            hospedagem.Cadastro_Empresa cadEmpre = new Cadastro_Empresa();
            FormPrincipal.MudarForm("hospedagem", cadEmpre);
        }
    }
}
