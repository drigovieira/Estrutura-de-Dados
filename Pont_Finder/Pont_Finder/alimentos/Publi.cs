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
        private string nomeCompany, ruaCompany, bairroCompany, categoriaCompany;
        private int ID, numCompany, contatoCompany;

        private void Bt_visualizar_Click(object sender, EventArgs e)
        {
            foreach (var item in CompanyList.selectAll())
            {
                if(CompanyList.selectAll().IndexOf(item) == ID)
                {
                    alimentos.Visualizar exibirEmpresa = new alimentos.Visualizar(item.NomeFantasia, item.Rua, item.Bairro, item.Categoria, item.Numero, item.Cep, item.TelComercial);
                    FormPrincipal.MudarForm("alimentos", exibirEmpresa);
                }
            }            
        }

        public Publi(string Nome, string Rua, string Bairro, int Num, int Contato, List<string> Categoria, int index)
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
                            categoriaCompany += " ...";
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
        }


        private void Publi_Paint(object sender, PaintEventArgs e)
        {
            NomeEmpresa.Text = nomeCompany;
            lbRua.Text = ruaCompany;
            lbBairro.Text = bairroCompany;
            lbNumero.Text = numCompany.ToString();
            lbContato.Text = contatoCompany.ToString();
            lbCategoria.Text = categoriaCompany;
        }
    }
}
