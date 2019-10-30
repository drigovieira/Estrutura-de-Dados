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
    public partial class Cadastro_Empresa : Form
    {
        public Cadastro_Empresa()
        {
            InitializeComponent();
        }

        private void Cadastro_Empresa_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            hospedagem.Listas_quartos listQuartos = new Listas_quartos();
            FormPrincipal.MudarForm("hospedagem", listQuartos);
        }
    }
}
