﻿using System;
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
                //CEP
                emp.Bairro = tbBairro.Text;
                emp.Categoria = categorias;
                //Telefone
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
    }
}
