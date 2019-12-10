using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Publi : UserControl
    {
        string variavel;
        private string nomeCompany, ruaCompany, bairroCompany, categoriaCompany;
        private int ID, numCompany;

        private void Publi_Load(object sender, EventArgs e)
        {

        }

        private long contatoCompany;

        private void Bt_visualizar_Click(object sender, EventArgs e)
        {
            foreach (var item in CompanyList.selectAll())
            {
                if(CompanyList.selectAll().IndexOf(item) == ID)
                {
                    alimentos.Visualizar exibirEmpresa = new alimentos.Visualizar(ID, item.NomeFantasia, item.Rua, item.Bairro, item.Categoria, item.Numero, item.Cep, item.TelComercial, item.Image, item.SttsCardapio);
                    FormPrincipal.MudarForm("alimentos", exibirEmpresa);
                }
            }            
        }

        public Publi(string Nome, string Rua, string Bairro, int Num, long Contato, List<string> Categoria, int index)
        {                        
            nomeCompany = Nome;
            ruaCompany = Rua;
            bairroCompany = Bairro;
            numCompany = Num;
            contatoCompany = Contato;
            int cont = 0;
            foreach(var aliment in Categoria)
            {
                if (Categoria.Count > 3)
                {
                    if (Categoria.IndexOf(aliment) == 0)
                    {
                        categoriaCompany = aliment;
                        cont++;
                    }
                    else
                    {
                        if(cont == 3)
                        {
                            categoriaCompany += " e mais ...";
                            break;
                        }
                        categoriaCompany += " / " + aliment;
                        cont++;
                    }
                }
                else
                {
                    if (Categoria.IndexOf(aliment) == 0)
                    {
                        categoriaCompany = aliment;
                    }
                    else
                    {
                        categoriaCompany += " / " + aliment;
                    }
                }
            }            
            ID = index;
            InitializeComponent();
            if (CompanyList.select(index).Image != null)
                pb_Restaurante.ImageLocation = CompanyList.select(index).Image;
            else
                pb_Restaurante.ImageLocation = "..//..//alimentos//data//image//empresas//offImage.jpg";
            lbContato.Text = contatoCompany.ToString();
            if (lbContato.Text.Length.Equals(10))
            {

                variavel = contatoCompany.ToString(@"(00)0000-0000");
            }
            else
            {
                variavel = contatoCompany.ToString(@"(00)00000-0000");
            }
        }


        private void Publi_Paint(object sender, PaintEventArgs e)
        {
            NomeEmpresa.Text = nomeCompany;
            lbRua.Text = ruaCompany;
            lbBairro.Text = bairroCompany;
            lbNumero.Text = numCompany.ToString();
            lbContato.Text = variavel;
            lbCategoria.Text = categoriaCompany;
        }
    }
}
