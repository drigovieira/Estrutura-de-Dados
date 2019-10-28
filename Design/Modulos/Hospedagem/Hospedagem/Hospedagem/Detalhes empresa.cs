using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem
{
    public partial class Detalhes_empresa : Form
    {
        
        
        public Detalhes_empresa()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // bottao cadastrar
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


            XML xmlli = new XML();
            //final do programa salvando...
            int cont = 0;
            foreach (var item in hostList.selectAll())
            {
                xmlli.Add(cont, item.Nomeempresa, item.Nomefantasia, item.CNPJ, item.Endereco, item.Cep, item.Telefone, item.Foto, item.Descricao);
                cont++;
            }

            MessageBox.Show("Dados Salvos");

        }

        private void button4_Click(object sender, EventArgs e) //botão que limpa os textbox do primeiro bloco
        {
            
            nomeempresa.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void button3_Click(object sender, EventArgs e) // 
        {
            
        }
    }
}
