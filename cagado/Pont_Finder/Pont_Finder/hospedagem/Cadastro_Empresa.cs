﻿using System;
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
            string NomeEmpresa = nomeempresa.Text;
            string NomeFantasia = textBox2.Text;
            string Email = textBox3.Text;
            string Endereco = textBox4.Text;
            long CNPJ = long.Parse(textBox5.Text);
            int Cep = Convert.ToInt32(textBox6.Text);
            int Tel = Convert.ToInt32(textBox7.Text);
            string descricao = textBox1.Text;
            string Foto = "CAMINHO";
            string Ambientes = "abc";

            Empresa empresa = new Empresa();

            empresa.Nomeempresa = NomeEmpresa;
            empresa.Nomefantasia = NomeFantasia;
            empresa.Email = Email;
            empresa.Endereco = Endereco;
            empresa.CNPJ = CNPJ;
            empresa.Cep = Cep;
            empresa.Telefone = Tel;
            empresa.Descricao = descricao;
            empresa.Foto = Foto;
            empresa.Ambiente = Ambientes;




            hostList.addEmpresa(empresa);
            MessageBox.Show("Usuário Cadastrado com sucesso!");
            this.Close();

            

            //hospedagem.Listas_quartos listQuartos = new Listas_quartos();
            //FormPrincipal.MudarForm("hospedagem", listQuartos);
        }

        private void button3_Click(object sender, EventArgs e) //BOTAO QUE VERIFICA OS TEXT FIELDS E HABILITA OS DEMAIS
        {
            textBox1.Enabled = true;
        }
    }
}
