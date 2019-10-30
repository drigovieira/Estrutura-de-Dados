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

    public partial class formCriarConta : Form
    {

        
        public formCriarConta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string cad_Name = textB_nome.Text;
            long cad_CPF = long.Parse(textB_cpf.Text);
            string cad_email = textB_email.Text;
            string cad_senha = textB_senha.Text;

            User user = new User();
            user.Nome = cad_Name;
            user.Email = cad_email;
            user.Senha = cad_senha;
            user.Cpf = cad_CPF;
            user.Ativo = true;
            UserList.userAdd(user);
            
            MessageBox.Show("Usuário Cadastrado com sucesso!");

            //this.Dispose();
            this.Close();
            


        }

        private void textB_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void formCriarConta_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
