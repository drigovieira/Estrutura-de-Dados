using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Suporte
{
    public partial class telaLogin : Form
    {
        string caminho = "..\\..\\DadosUsuarios\\usuarios.xml";

        public telaLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            XmlDocument doc = new XmlDocument();  
            doc.Load(caminho);
            foreach (XmlNode node in doc.SelectNodes("//usuario"))
            {
                string cpfx = node.SelectSingleNode("cpf").InnerText;
                string senhax = node.SelectSingleNode("senha").InnerText;

                if (cpfx == btnCpf.Text && senhax == btnSenha.Text)
                {
                    MessageBox.Show("BEM VINDO "+ btnCpf.Text);
                }
                else
                {
                    MessageBox.Show("USUARIO NÃO ENCONTRADO");
                }
            }
            
          

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            btnCpf.Text = ""; btnSenha.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            telaCadastro TC = new telaCadastro();

            TC.Show();
            this.Hide();
        }
    }
}
