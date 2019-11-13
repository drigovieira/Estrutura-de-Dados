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
        private List<string> categorias = new List<string>();
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
                emp.Categoria = categorias;
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

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                categorias.Add("Comida Japonesa");
            }
            else
            {
                if (categorias.Contains("Comida Japonesa"))
                {
                    categorias.Remove("Comida Japonesa");
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                categorias.Add("Churrascaria");
            }
            else
            {
                if (categorias.Contains("Churrascaria"))
                {
                    categorias.Remove("Churrascaria");
                }
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                categorias.Add("Pizzaria");
            }
            else
            {
                if (categorias.Contains("Pizzaria"))
                {
                    categorias.Remove("Pizzaria");
                }
            }
        }
    }
}
