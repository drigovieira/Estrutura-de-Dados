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
            tbFantasia.Text = CompanyList.selectAll()[idEmpresa].NomeFantasia;
            tbBairro.Text = CompanyList.selectAll()[idEmpresa].Bairro;
            tbRua.Text = CompanyList.selectAll()[idEmpresa].Rua;
            tbNum.Text = CompanyList.selectAll()[idEmpresa].Numero.ToString();
            mkb_Tel.Text = CompanyList.selectAll()[idEmpresa].TelComercial.ToString();
            tbEmail.Text = CompanyList.selectAll()[idEmpresa].Email;
            pb_icone.ImageLocation = CompanyList.selectAll()[idEmpresa].Image;
            cbCardapio.Checked = true;
            cbEntrega.Checked = true;
            maskedTextBox1.Text = CompanyList.selectAll()[idEmpresa].Taxa.ToString();
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
            foreach(var i in CompanyList.selectAll()[idEmpresa].FuncionamentoEmp)
            {
                if (i.Dia.Equals(cbSegunda.Text))
                {
                    cbSegunda.Checked = true;
                    maskedTextBox4.Text = i.HoraInicio.ToString();
                    maskedTextBox4.Enabled = true;
                    maskedTextBox19.Text = i.HoraFim.ToString();
                    maskedTextBox19.Enabled = true;
                }
                else if (i.Dia.Equals(cbTerca.Text))
                {
                    cbTerca.Checked = true;
                    maskedTextBox5.Text = i.HoraInicio.ToString();
                    maskedTextBox5.Enabled = true;
                    maskedTextBox18.Text = i.HoraFim.ToString();
                    maskedTextBox18.Enabled = true;
                }
                else if (i.Dia.Equals(cbQuarta.Text))
                {
                    cbQuarta.Checked = true;
                    maskedTextBox6.Text = i.HoraInicio.ToString();
                    maskedTextBox6.Enabled = true;
                    maskedTextBox17.Text = i.HoraFim.ToString();
                    maskedTextBox17.Enabled = true;
                }
                else if (i.Equals(cbQuinta.Text))
                {
                    cbQuinta.Checked = true;
                    maskedTextBox7.Text = i.HoraInicio.ToString();
                    maskedTextBox7.Enabled = true;
                    maskedTextBox16.Text = i.HoraFim.ToString();
                    maskedTextBox16.Enabled = true;
                }
                else if (i.Equals(cbSexta.Text))
                {
                    cbSexta.Checked = true;
                    maskedTextBox8.Text = i.HoraInicio.ToString();
                    maskedTextBox8.Enabled = true;
                    maskedTextBox15.Text = i.HoraFim.ToString();
                    maskedTextBox15.Enabled = true;
                }
                else if (i.Equals(cbSabado.Text))
                {
                    cbSabado.Checked = true;
                    maskedTextBox9.Text = i.HoraInicio.ToString();
                    maskedTextBox9.Enabled = true;
                    maskedTextBox14.Text = i.HoraFim.ToString();
                    maskedTextBox14.Enabled = true;
                }
                else if (i.Equals(cbDomingo.Text))
                {
                    cbDomingo.Checked = true;
                    maskedTextBox10.Text = i.HoraInicio.ToString();
                    maskedTextBox10.Enabled = true;
                    maskedTextBox13.Text = i.HoraFim.ToString();
                    maskedTextBox13.Enabled = true;
                }
                else if (i.Equals(cbFeriado.Text))
                {
                    cbFeriado.Checked = true;
                    maskedTextBox11.Text = i.HoraInicio.ToString();
                    maskedTextBox11.Enabled = true;
                    maskedTextBox12.Text = i.HoraFim.ToString();
                    maskedTextBox12.Enabled = true;
                }
            }
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

        private void CbSegunda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSegunda.Checked == true)
            {
                maskedTextBox4.Enabled = true;
                maskedTextBox19.Enabled = true;
            }
            else
            {
                maskedTextBox4.Enabled = false;
                maskedTextBox19.Enabled = false;
            }
        }

        private void CbTerca_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTerca.Checked == true)
            {
                maskedTextBox5.Enabled = true;
                maskedTextBox18.Enabled = true;
            }
            else
            {
                maskedTextBox5.Enabled = false;
                maskedTextBox18.Enabled = false;
            }
        }

        private void CbQuarta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQuarta.Checked)
            {
                maskedTextBox6.Enabled = true;
                maskedTextBox17.Enabled = true;
            }
            else
            {
                maskedTextBox6.Enabled = false;
                maskedTextBox17.Enabled = false;
            }
        }

        private void CbQuinta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQuinta.Checked == true)
            {
                maskedTextBox7.Enabled = true;
                maskedTextBox16.Enabled = true;
            }
            else
            {
                maskedTextBox7.Enabled = false;
                maskedTextBox16.Enabled = false;
            }
        }

        private void CbSexta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSexta.Checked == true)
            {
                maskedTextBox8.Enabled = true;
                maskedTextBox15.Enabled = true;
            }
            else
            {
                maskedTextBox8.Enabled = false;
                maskedTextBox15.Enabled = false;
            }
        }

        private void CbSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSabado.Checked == true)
            {
                maskedTextBox9.Enabled = true;
                maskedTextBox14.Enabled = true;
            }
            else
            {
                maskedTextBox9.Enabled = false;
                maskedTextBox14.Enabled = false;
            }
        }

        private void CbDomingo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDomingo.Checked == true)
            {
                maskedTextBox10.Enabled = true;
                maskedTextBox13.Enabled = true;
            }
            else
            {
                maskedTextBox10.Enabled = false;
                maskedTextBox13.Enabled = false;
            }
        }

        private void CbFeriado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFeriado.Checked == true)
            {
                maskedTextBox11.Enabled = true;
                maskedTextBox12.Enabled = true;
            }
            else
            {
                maskedTextBox11.Enabled = false;
                maskedTextBox12.Enabled = false;
            }
        }
    }
}
