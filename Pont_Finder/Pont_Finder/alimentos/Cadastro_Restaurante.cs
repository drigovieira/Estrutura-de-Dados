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
    public partial class Cadastro_Restaurante : Form
    {
        private List<string> categorias = new List<string>();
        private List<Funcionamento> funcionamentos = new List<Funcionamento>();
        private bool img = false;
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
                    link = "..//..//servicos//data//images//empresas//" + emp.Email + ".jpg";
                    pb_icone.Image.Save(link, ImageFormat.Jpeg);
                }
                emp.Image = link;
                emp.FuncionamentoEmp = funcionamentos;
                CompanyList.CompAdd(emp);                

                MessageBox.Show("Empresa Cadastrada!", "Status Operation:");
                if (cbCardapio.Checked == true)
                {
                    alimentos.Cadastro_Cardapio cadCardapio = new Cadastro_Cardapio();
                    FormPrincipal.MudarForm("alimentos", cadCardapio);
                }
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
            if (checkBox3.Checked == true)
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
            if (checkBox2.Checked == true)
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

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
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

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
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

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
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

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
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

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
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

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
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

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
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

        private void Btn_back_Click(object sender, EventArgs e)
        {
            formAlimentos alimentos = new formAlimentos();
            FormPrincipal.MudarForm("alimentos", alimentos);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                img = true;
            }
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

        private void CbRegistSim_CheckedChanged(object sender, EventArgs e)
        {

        }        

        private void CbEntregaSim_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CbEntregaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEntrega.Checked == true)
            {
                cbEntrega.Checked = false;
            }
        }

        private void Btn_back_Click_1(object sender, EventArgs e)
        {
            formAlimentos homeAlimentos = new formAlimentos();
            FormPrincipal.MudarForm("alimentos", homeAlimentos);
        }
    }
}
