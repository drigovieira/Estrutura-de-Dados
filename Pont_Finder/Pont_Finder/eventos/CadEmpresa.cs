using Pont_Finder.eventos.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class CadEmpresa : Form
    {

       



        public CadEmpresa()
        {
            InitializeComponent();
        }

        private void CadEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //eventos.ListEvent ltEvent = new eventos.ListEvent();
            //FormPrincipal.MudarForm("evento", ltEvent);


            CaEmpresa postar = new CaEmpresa();


            string p_nomeEmpresa = Bnomeempresa.Text;
            string p_nomeFantasia = Bnomefantasia.Text;
            string p_cnpj = Bcnpj.Text;
            string p_endereco = Bendereco.Text;
            string p_telefone = Btelefone.Text;
            string p_email = Bemail.Text;


            

            postar.Nome = p_nomeEmpresa;
            postar.Nome_Fantasia = p_nomeFantasia;
            postar.Cnpj = p_cnpj;
            postar.Endereco = p_endereco;
            postar.Telefone = p_telefone;
            postar.Email = p_email;


            Empresa_List.PostAddEmpresa(postar);

            //AvaliePrincipal.Att();
            MessageBox.Show("Post realizado com sucesso!!!");

            foreach (var item in Empresa_List.poster)
            {
                testelista.Items.Add(item.Nome);
                testelista.Items.Add(item.Nome_Fantasia);
                testelista.Items.Add(item.Cnpj);
                testelista.Items.Add(item.Endereco);
                testelista.Items.Add(item.Telefone);
                testelista.Items.Add(item.Email);
            }


        }
    }
}
