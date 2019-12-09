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
            long p_cnpj = long.Parse(mkb_cnpj.Text);
            string p_endereco = Bendereco.Text;
            string p_telefone = mkb_telefone.Text;
            string p_email = Bemail.Text;
            //string p_senha = Bsenha.Text;


            

            postar.Nome = p_nomeEmpresa;
            postar.Nome_Fantasia = p_nomeFantasia;
            postar.Cnpj = p_cnpj;
            postar.Endereco = p_endereco;
            postar.Telefone = p_telefone;
            postar.Email = p_email;
            //postar.Senha = p_senha;


            postar.Ativo = true;


            Empresa_List.PostAdd(postar);

            //AvaliePrincipal.Att();
            MessageBox.Show("Cadastro realizado com sucesso!!!");

            eventos.ListEvent listagem = new eventos.ListEvent();
            FormPrincipal.MudarForm("eventos", listagem);


        }

        private void Bnomeempresa_TextChanged(object sender, EventArgs e)
        {
            Bnomeempresa.MaxLength = 50;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bnomeempresa.Clear();
            Bnomefantasia.Clear();
            mkb_cnpj.Clear();
            Bendereco.Clear();
            mkb_telefone.Clear();
            Bemail.Clear();
        }

        private void Bnomefantasia_TextChanged(object sender, EventArgs e)
        {
            Bnomefantasia.MaxLength = 75;
        }

        private void Bendereco_TextChanged(object sender, EventArgs e)
        {
            Bendereco.MaxLength = 50;
        }

        private void Bemail_TextChanged(object sender, EventArgs e)
        {
            Bemail.MaxLength = 50;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("eventos", new eventos.FormEventos());
        }
    }
}
