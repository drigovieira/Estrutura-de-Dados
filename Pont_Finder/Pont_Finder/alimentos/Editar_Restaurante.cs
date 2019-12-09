using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Editar_Restaurante : Form
    {
        private int Empresa;
        public Editar_Restaurante(int idEmpresa)
        {
            Empresa = idEmpresa;
            InitializeComponent();
            tbNomeEmpresa.Text = CompanyList.selectAll()[idEmpresa].Nome;
        }

        private void Editar_Restaurante_Load(object sender, EventArgs e)
        {

        }

        private void TbNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            tbNomeEmpresa.MaxLength = 50;
        }

        private void TbFantasia_TextChanged(object sender, EventArgs e)
        {
            tbFantasia.MaxLength = 75;
        }

        private void TbBairro_TextChanged(object sender, EventArgs e)
        {
            tbBairro.MaxLength = 50;
        }

        private void TbRua_TextChanged(object sender, EventArgs e)
        {
            tbRua.MaxLength = 50;
        }

        private void TbNum_TextChanged(object sender, EventArgs e)
        {
            tbNum.MaxLength = 10;
        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            tbEmail.MaxLength = 50;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            formAlimentos home = new formAlimentos();
            FormPrincipal.MudarForm("alimentos", home);
        }
    }
}
