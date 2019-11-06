using System;
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
            string Ambientes = "LISTA DE AMBIENTES";
            string Tipo = "TIPO DO QUARTO";
            int Estrelas = 5;

            Empresa empresa = new Empresa();

            empresa.Nomeempresa = NomeEmpresa;
            empresa.Nomefantasia = NomeFantasia;
            empresa.Endereco = Endereco;
            empresa.CNPJ = CNPJ;
            empresa.Cep = Cep;
            empresa.Telefone = Tel;  
            empresa.Email = Email;
            empresa.Foto = Foto;

            //Verifica se e hotel ou pousada
            if (radio_hotel.Checked)
            {
                empresa.Tipo = "Hotel";
            }
            if (radio_pousada.Checked)
            {
                empresa.Tipo = "Pousada";
            }

            //Verifica qtd de estrelas
            if (estrela2.Checked)
            {
                empresa.Estrelas = 2;
            }
            if (estrela3.Checked)
            {
                empresa.Estrelas = 3;
            }
            if (estrela4.Checked)
            {
                empresa.Estrelas = 4;
            }
            if (estrela5.Checked)
            {
                empresa.Estrelas = 5;
            }

            empresa.Descricao = descricao;
            empresa.Ambiente = Ambientes;
            empresa.Ativo = true;



            hostList.addEmpresa(empresa);
            MessageBox.Show("Usuário Cadastrado com sucesso!");

            hospedagem.Listas_quartos listQuartos = new Listas_quartos();
            FormPrincipal.MudarForm("hospedagem", listQuartos);
        }

        private void button3_Click(object sender, EventArgs e) //BOTAO QUE VERIFICA OS TEXT FIELDS E HABILITA OS DEMAIS
        {
            textBox1.Enabled = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
        }
    }
}
