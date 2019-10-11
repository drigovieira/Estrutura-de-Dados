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
    public partial class FormCadastroUser : Form
    {
        public FormCadastroUser()
        {
            InitializeComponent();
        }

        private void FormCadastroUser_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            long cpf = long.Parse(textBox2.Text);
            string email = textBox3.Text;
            string senha = textBox1.Text;


            try
            {
                User u = new User();
                u.Nome = nome;
                u.Email = email;      
                u.Senha = senha;
                u.Cpf = cpf;
                u.Ativo = true;

                UserList.userAdd(u);
                XmlLi xmlli = new XmlLi();

                xmlli.Drop();
                int cont = 0;
                foreach (var item in UserList.selectAll())
                {
                    xmlli.Add(cont, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo);
                    cont++;
                }

                MessageBox.Show("Usuario cadastrado no Sistema");
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Não foi possivel cadastrar o usuario no Sistema\n"+ err.Message);
  

            }
        }
    }
}
