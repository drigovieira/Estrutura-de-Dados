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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button_CriarC_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            this.Close();
            fCC.ShowDialog();
            

        }

        private void buttonCriarC_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            fCC.ShowDialog();
            fCC.Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Session.Login(tb_email.Text, tb_senha.Text))
                this.Close();            
            else
                MessageBox.Show("Não Logado");          
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void TextB_senha_TextChanged(object sender, EventArgs e)
        {
            tb_senha.MaxLength = 100;
        }

        private void TextB_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Session.Login(tb_email.Text, tb_senha.Text))
                    this.Close();
                else
                    MessageBox.Show("Não Logado");
            }
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                
        }

        private void TextB_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Session.Login(tb_email.Text, tb_senha.Text))
                    this.Close();
                else
                    MessageBox.Show("Não Logado");
            }         
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Recuperar_senha Rec_Senha = new Recuperar_senha();
            Rec_Senha.ShowDialog();
        }

        private void Tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.MaxLength = 50;
        }
    }
}
