using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_do_Projeto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string senha = textBox2.Text;
            bool valido = false;
            foreach (var item in UserList.selectAll())
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha))
                {
                    valido = true;
                    break;
                }
            }
            if (valido)
            {
                MessageBox.Show("logou");
            }
            else
            {
                MessageBox.Show("Não logou");
            }


            Session.Email = email;
            Session.Senha = senha;

            


            FormCadastroUser fC = new FormCadastroUser();
            fC.ShowDialog();
            this.Dispose();
        }
    }
}
