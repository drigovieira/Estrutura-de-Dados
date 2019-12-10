using Pont_Finder.alimentos.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Editar_Restaurante : Form
    {
        private List<string> categorias = new List<string>();
        private List<Funcionamento> funcionamentos = new List<Funcionamento>();
        private int Empresa;
        private bool img;
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
            mkb_Cep.Text = CompanyList.selectAll()[idEmpresa].Cep.ToString();
            pb_icone.ImageLocation = CompanyList.selectAll()[idEmpresa].Image;
            cbCardapio.Checked = CompanyList.selectAll()[idEmpresa].SttsCardapio;
            cbEntrega.Checked = CompanyList.selectAll()[idEmpresa].SttsEntrega;
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
            int limit = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp.Count;
            for (int cont =0; cont < limit;cont++)
            {
                if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Segunda - Feira"))
                {
                    maskedTextBox4.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox19.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbSegunda.Checked = true;
                    maskedTextBox4.Enabled = true;
                    maskedTextBox19.Enabled = true;
                }
                else if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Terça - Feira"))
                {
                    maskedTextBox5.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox18.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbTerca.Checked = true;
                    maskedTextBox5.Enabled = true;
                    maskedTextBox18.Enabled = true;
                }
                else if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Quarta - Feira"))
                {
                    maskedTextBox6.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox17.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbQuarta.Checked = true;
                    maskedTextBox6.Enabled = true;
                    maskedTextBox17.Enabled = true;
                }
                else if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Quinta - Feira"))
                {
                    maskedTextBox7.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox16.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbQuinta.Checked = true;
                    maskedTextBox7.Enabled = true;
                    maskedTextBox16.Enabled = true;
                }
                else if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Sexta - Feira"))
                {
                    maskedTextBox8.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox15.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbSexta.Checked = true;
                    maskedTextBox8.Enabled = true;
                    maskedTextBox15.Enabled = true;
                }
                else if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Sábado"))
                {
                    maskedTextBox9.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox14.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbSabado.Checked = true;
                    maskedTextBox9.Enabled = true;
                    maskedTextBox14.Enabled = true;
                }
                else if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Domingo"))
                {
                    maskedTextBox10.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox13.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbDomingo.Checked = true;
                    maskedTextBox10.Enabled = true;
                    maskedTextBox13.Enabled = true;
                }
                else if (CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].Dia.Equals("Feriados"))
                {
                    maskedTextBox11.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraInicio.ToString("HH:mm");
                    maskedTextBox12.Text = CompanyList.selectAll()[idEmpresa].FuncionamentoEmp[cont].HoraFim.ToString("HH:mm");
                    cbFeriado.Checked = true;
                    maskedTextBox11.Enabled = true;
                    maskedTextBox12.Enabled = true;
                }
            }
        }
        private void RbComidaJaponesa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComidaJaponesa.Checked == true)
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

        private void RbChurrascaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChurrascaria.Checked == true)
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

        private void RbPizzaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPizzaria.Checked == true)
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

        private void RbSorveteria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSorveteria.Checked == true)
            {
                categorias.Add("Sorveteria");
            }
            else
            {
                if (categorias.Contains("Sorveteria"))
                {
                    categorias.Remove("Sorveteria");
                }
            }
        }

        private void RbPetiscaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPetiscaria.Checked == true)
            {
                categorias.Add("Petiscaria");
            }
            else
            {
                if (categorias.Contains("Petiscaria"))
                {
                    categorias.Remove("Petiscaria");
                }
            }
        }

        private void RbComidaItaliana_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComidaItaliana.Checked == true)
            {
                categorias.Add("Comida Italiana");
            }
            else
            {
                if (categorias.Contains("Comida Italiana"))
                {
                    categorias.Remove("Comida Italiana");
                }
            }
        }

        private void RbHambúrgueria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHambúrgueria.Checked == true)
            {
                categorias.Add("Hambúrgueria");
            }
            else
            {
                if (categorias.Contains("Hambúrgueria"))
                {
                    categorias.Remove("Hambúrgueria");
                }
            }
        }

        private void RbFrutosDoMar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFrutosDoMar.Checked == true)
            {
                categorias.Add("Frutos do Mar");
            }
            else
            {
                if (categorias.Contains("Frutos do Mar"))
                {
                    categorias.Remove("Frutos do Mar");
                }
            }
        }

        private void RbConvencional_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConvencional.Checked == true)
            {
                categorias.Add("Convencional");
            }
            else
            {
                if (categorias.Contains("Convencional"))
                {
                    categorias.Remove("Convencional");
                }
            }
        }

        private void RbOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOutros.Checked == true)
            {
                categorias.Add("Outros");
            }
            else
            {
                if (categorias.Contains("Outros"))
                {
                    categorias.Remove("Outros");
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

        private void BtnCad_Click(object sender, EventArgs e)
        {
            Company comp = new Company();            
            bool checkEmail = Validation.Email(tbEmail.Text);
            if (string.IsNullOrWhiteSpace(tbNomeEmpresa.Text) || string.IsNullOrWhiteSpace(tbFantasia.Text) || string.IsNullOrWhiteSpace(tbBairro.Text)
              || string.IsNullOrWhiteSpace(tbRua.Text) || string.IsNullOrWhiteSpace(tbNum.Text) || string.IsNullOrWhiteSpace(mkb_Cep.Text)
              || string.IsNullOrWhiteSpace(mkb_Tel.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso!");
            }
            else
            {
                if (checkEmail == false)
                {
                    MessageBox.Show("E-mail inválido.", "Aviso!");
                }
                else
                {
                    if (rbChurrascaria.Checked == false && rbPetiscaria.Checked == false && rbPizzaria.Checked == false && rbSorveteria.Checked == false
                        && rbOutros.Checked == false && rbHambúrgueria.Checked == false && rbFrutosDoMar.Checked == false && rbConvencional.Checked == false
                        && rbComidaJaponesa.Checked == false && rbComidaItaliana.Checked == false)
                    {
                        MessageBox.Show("Selecione uma ou mais categorias.", "Aviso!");
                    }
                    else
                    {
                        if (cbSegunda.Checked == false && cbTerca.Checked == false && cbQuarta.Checked == false && cbQuinta.Checked == false
                            && cbSexta.Checked == false && cbSabado.Checked == false && cbDomingo.Checked == false)
                        {
                            MessageBox.Show("Selecione um ou mais dias de funcionamento.", "Aviso!");
                        }
                        else
                        {                                                        
                                if (cbSegunda.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbSegunda.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox4.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox19.Text);
                                    funcionamentos.Add(funcio);
                                }
                                if (cbTerca.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbTerca.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox5.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox18.Text);
                                    funcionamentos.Add(funcio);
                                }
                                if (cbQuarta.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbQuarta.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox6.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox17.Text);
                                    funcionamentos.Add(funcio);
                                }
                                if (cbQuinta.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbQuinta.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox7.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox16.Text);
                                    funcionamentos.Add(funcio);
                                }
                                if (cbSexta.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbSexta.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox8.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox15.Text);
                                    funcionamentos.Add(funcio);
                                }
                                if (cbSabado.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbSabado.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox9.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox14.Text);
                                    funcionamentos.Add(funcio);
                                }
                                if (cbDomingo.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbDomingo.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox10.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox13.Text);
                                    funcionamentos.Add(funcio);
                                }
                                if (cbFeriado.Checked == true)
                                {
                                    Funcionamento funcio = new Funcionamento();
                                    funcio.Dia = cbFeriado.Text;
                                    funcio.HoraInicio = DateTime.Parse(maskedTextBox11.Text);
                                    funcio.HoraFim = DateTime.Parse(maskedTextBox12.Text);
                                    funcionamentos.Add(funcio);
                                }

                            if (rbComidaJaponesa.Checked == true)
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
                            if (rbChurrascaria.Checked == true)
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
                            if (rbPizzaria.Checked == true)
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
                            if (rbSorveteria.Checked == true)
                            {
                                categorias.Add("Sorveteria");
                            }
                            else
                            {
                                if (categorias.Contains("Sorveteria"))
                                {
                                    categorias.Remove("Sorveteria");
                                }
                            }
                            if (rbPetiscaria.Checked == true)
                            {
                                categorias.Add("Petiscaria");
                            }
                            else
                            {
                                if (categorias.Contains("Petiscaria"))
                                {
                                    categorias.Remove("Petiscaria");
                                }
                            }
                            if (rbComidaItaliana.Checked == true)
                            {
                                categorias.Add("Comida Italiana");
                            }
                            else
                            {
                                if (categorias.Contains("Comida Italiana"))
                                {
                                    categorias.Remove("Comida Italiana");
                                }
                            }
                            if (rbHambúrgueria.Checked == true)
                            {
                                categorias.Add("Hambúrgueria");
                            }
                            else
                            {
                                if (categorias.Contains("Hambúrgueria"))
                                {
                                    categorias.Remove("Hambúrgueria");
                                }
                            }
                            if (rbFrutosDoMar.Checked == true)
                            {
                                categorias.Add("Frutos do Mar");
                            }
                            else
                            {
                                if (categorias.Contains("Frutos do Mar"))
                                {
                                    categorias.Remove("Frutos do Mar");
                                }
                            }
                            if (rbConvencional.Checked == true)
                            {
                                categorias.Add("Convencional");
                            }
                            else
                            {
                                if (categorias.Contains("Convencional"))
                                {
                                    categorias.Remove("Convencional");
                                }
                            }
                            if (rbOutros.Checked == true)
                            {
                                categorias.Add("Outros");
                            }
                            else
                            {
                                if (categorias.Contains("Outros"))
                                {
                                    categorias.Remove("Outros");
                                }
                            }
                            Company emp = new Company();
                            try
                            {
                                emp.Nome = tbNomeEmpresa.Text;
                                emp.NomeFantasia = tbFantasia.Text;
                                emp.Rua = tbRua.Text;
                                emp.Numero = Convert.ToInt32(tbNum.Text);
                                emp.Cep = int.Parse(mkb_Cep.Text);
                                emp.Bairro = tbBairro.Text;
                                emp.Categoria = categorias;
                                emp.TelComercial = long.Parse(mkb_Tel.Text);
                                emp.Email = tbEmail.Text;
                                string link = "..//..//alimentos//data//image//empresas//offImage.jpg";
                                if (img)
                                {
                                    if (!Directory.Exists("..//..//alimentos//data//image//empresas"))
                                        Directory.CreateDirectory("..//..//alimentos//data//image//empresas");

                                    pb_icone.Load();
                                    pb_icone.Image = Image.FromFile(openIcone.FileName);

                                    Image bmp = new Bitmap(pb_icone.Image);

                                    Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                                    pb_icone.Image = bmp2;
                                    link = "..//..//alimentos//data//image//empresas//" + emp.Email + ".jpg";
                                    pb_icone.Image.Save(link, ImageFormat.Jpeg);
                                }
                                emp.Image = link;
                                emp.FuncionamentoEmp = funcionamentos;
                                if (cbCardapio.Checked == true)
                                {
                                    emp.SttsCardapio = true;
                                    if (cbEntrega.Checked == true)
                                    {
                                        emp.SttsEntrega = true;
                                    }
                                    else { emp.SttsEntrega = false; }
                                }
                                else { emp.SttsCardapio = false; emp.SttsEntrega = false; }
                                emp.Cpf = Session.Cpf;
                                if (cbEntrega.Checked == true)
                                {
                                    emp.Taxa = float.Parse(maskedTextBox1.Text);
                                }
                                emp.Id = Empresa;
                                CompanyList.alter(Empresa, emp);
                                MessageBox.Show("Empresa Modificada!", "Status Operation:");
                                if (cbCardapio.Checked == true)
                                {
                                    foreach (var i in CompanyList.selectAll())
                                    {
                                        if (i.Email.Equals(emp.Email))
                                        {
                                            alimentos.Cadastro_Produto cadCardapio = new Cadastro_Produto(i.Id);
                                            FormPrincipal.MudarForm("alimentos", cadCardapio);
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    formAlimentos homeAlimentos = new formAlimentos();
                                    FormPrincipal.MudarForm("alimentos", homeAlimentos);
                                }
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show("" + exp);
                            }                            
                        }
                    }

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                img = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
    }
}
