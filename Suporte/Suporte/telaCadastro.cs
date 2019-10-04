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
using System.Xml.XPath;

namespace Suporte
{
    public partial class telaCadastro : Form
    {
        USUARIO usudata = new USUARIO();
        string caminho = "..\\..\\DadosUsuarios\\usuarios.xml";


        public telaCadastro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usudata.Nome = btnNome.Text;
            usudata.Email = btnEmail.Text;
            usudata.Senha = btnSenha.Text;
            usudata.Cpf = long.Parse(btnCpf.Text);



            XDocument load = XDocument.Load(caminho);
            XElement usu = new XElement("usuario",
                new XElement("nome", usudata.Nome),
                new XElement("email", usudata.Email),
                new XElement("senha", usudata.Senha),
                new XElement("cpf", usudata.Cpf));

                load.Root.Add(usu);
                load.Save(caminho);
                Console.ReadLine();

            MessageBox.Show("CADASTRADO COM SUCESSO");

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            telaLogin lg = new telaLogin();

            lg.Show();
            this.Close();
        }
    }
}
