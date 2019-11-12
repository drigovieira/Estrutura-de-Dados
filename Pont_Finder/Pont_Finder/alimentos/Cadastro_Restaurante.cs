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
            Company emp = new Company();
            try
            {
                emp.Nome = tbNomeEmpresa.Text;
                emp.NomeFantasia = tbFantasia.Text;
                emp.Rua = tbRua.Text;
                emp.Numero = Convert.ToInt32(tbNum.Text);
                emp.Cep = Convert.ToInt32(tbCep.Text);
                emp.Bairro = tbBairro.Text;
                emp.TelComercial = Convert.ToInt32(tbTel.Text);
                emp.Email = tbEmail.Text;
                CompanyList.CompAdd(emp);
                MessageBox.Show("Empresa Cadastrada!", "Status Operation:");
            }catch(Exception exp)
            {
                MessageBox.Show("" +exp);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
