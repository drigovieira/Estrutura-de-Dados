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
    public partial class Cadastro_Restaurante : Form
    {
        CompanyList complist = new CompanyList();
        public Cadastro_Restaurante()
        {
            InitializeComponent();
        }

        private void Cadastro_Restaurante_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            Company comp = new Company();
            comp.Nome = tbNomeEmpresa.Text;
            comp.NomeFantasia = tbFantasia.Text;
            comp.Rua = tbRua.Text;
            comp.Numero = Convert.ToInt32(tbNum.Text);
            comp.Cep = Convert.ToInt32(tbCep.Text);
            comp.Bairro = tbBairro.Text;
            comp.TelComercial = Convert.ToInt32(tbTel.Text);
            comp.Email = tbEmail.Text;
            complist.CompAdd(comp);
        }
    }
}
