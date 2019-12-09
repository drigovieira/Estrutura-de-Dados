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
        private string filtro;
        private int Empresa;
        public Editar_Restaurante(int idEmpresa)
        {
            Empresa = idEmpresa;
            InitializeComponent();
            tbNomeEmpresa.Text = CompanyList.selectAll()[idEmpresa].Nome;
            tbFantasia.Text = CompanyList.selectAll()[idEmpresa].NomeFantasia;
            tbBairro.Text = CompanyList.selectAll()[idEmpresa].Bairro;
            tbRua.Text = CompanyList.selectAll()[idEmpresa].Rua;
            tbNum.Text = CompanyList.selectAll()[idEmpresa].Numero.ToString();
            mkb_Tel.Text = CompanyList.selectAll()[idEmpresa].TelComercial.ToString();
            tbEmail.Text = CompanyList.selectAll()[idEmpresa].Email;
            pb_icone.ImageLocation = CompanyList.selectAll()[idEmpresa].Image;
            cbCardapio.Checked = true;
            cbEntrega.Checked = true;
            label15.Text = CompanyList.selectAll()[idEmpresa].Taxa.ToString();
            foreach(var i in CompanyList.selectAll()[idEmpresa].Categoria)
            {
                if (i == rbChurrascaria.Text)
                {
                    rbChurrascaria.Checked = true;
                }
                else if (i == rbPetiscaria.Text)
                {
                    rbPetiscaria.Checked = true;
                }
                else if (i == rbPizzaria.Text)
                {
                    rbPizzaria.Checked = true;
                }
                else if (i == rbComidaItaliana.Text)
                {
                    rbComidaItaliana.Checked = true;
                }
                else if (i == rbComidaJaponesa.Text)
                {
                    rbComidaJaponesa.Checked = true;
                }
                else if (i == rbSorveteria.Text)
                {
                    rbSorveteria.Checked = true;
                }
                else if (i == rbHambúrgueria.Text)
                {
                    rbHambúrgueria.Checked = true;
                }
                else if (i == rbFrutosDoMar.Text)
                {
                    rbFrutosDoMar.Checked = true;
                }
                else if (i == rbOutros.Text)
                {
                    rbOutros.Checked = true;
                }
            }
        }
        public string Filtro()
        {
            if (rbChurrascaria.Checked == true)
            {
                filtro = rbChurrascaria.Text;
            }
            else if (rbPetiscaria.Checked == true)
            {
                filtro = rbPetiscaria.Text;
            }
            else if (rbPizzaria.Checked == true)
            {
                filtro = rbPizzaria.Text;
            }
            else if (rbComidaItaliana.Checked == true)
            {
                filtro = rbComidaItaliana.Text;
            }
            else if (rbComidaJaponesa.Checked == true)
            {
                filtro = rbComidaJaponesa.Text;
            }
            else if (rbSorveteria.Checked == true)
            {
                filtro = rbSorveteria.Text;
            }
            else if (rbHambúrgueria.Checked == true)
            {
                filtro = rbHambúrgueria.Text;
            }
            else if (rbFrutosDoMar.Checked == true)
            {
                filtro = rbFrutosDoMar.Text;
            }
            else if (rbOutros.Checked == true)
            {
                filtro = rbOutros.Text;
            }
            return filtro;
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
