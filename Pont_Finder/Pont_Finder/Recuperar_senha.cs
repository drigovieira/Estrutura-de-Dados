using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class Recuperar_senha : Form
    {
        public Recuperar_senha()
        {
            InitializeComponent();
        }

        private void Recuperar_senha_Load(object sender, EventArgs e)
        {

        }

        private void button_recuperar_Click(object sender, EventArgs e)
        {
            long cpf = long.Parse(tb_cpf.Text);
            string email = tb_email.Text;
            string senha = tb_senha.Text;
            string vsenha = tb_vsenha.Text;
            bool alterada = false;

            if (senha == vsenha)
            {
                foreach (var item in UserList.thisUsers())
                {
                    if (item.Email == email && item.Cpf == cpf)
                    {
                        item.Senha = senha;
                        alterada = true;
                        break;
                    }
                }
                if (alterada)
                {
                    MessageBox.Show("Senha Alterada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha Não Alterada.\nVerifique os Dados");
                    tb_senha.Text = "";
                    tb_vsenha.Text = "";
                }
               
            }
            else
            {
                tb_senha.Text = "";
                tb_vsenha.Text = "";
                MessageBox.Show("Senhas Diferentes");
            }

           
        }

        private void Tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.MaxLength = 50;
        }

        private void Tb_senha_TextChanged(object sender, EventArgs e)
        {
            tb_senha.MaxLength = 100;
        }

        private void Tb_vsenha_TextChanged(object sender, EventArgs e)
        {
            tb_vsenha.MaxLength = 100;
        }
    }
}
