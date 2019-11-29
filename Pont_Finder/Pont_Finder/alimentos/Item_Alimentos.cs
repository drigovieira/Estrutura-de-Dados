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
    public partial class Item_Alimentos : UserControl
    {
        private string NomeItem, ImageItem;
        private float PrecoItem, qtdItem;
        private List<string> IngredientesItem, CategoriasItem;
        private int IdItem;
        public Item_Alimentos(float Preco, string Nome, string Imagem, float Qtd, List<string> Ingredientes, List<string> Categorias, int Id)
        {
            NomeItem = Nome;
            ImageItem = Imagem;
            PrecoItem = Preco;
            qtdItem = Qtd;
            IngredientesItem = Ingredientes;
            CategoriasItem = Categorias;
            IdItem = Id;
            InitializeComponent();
        }        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Item_Alimentos_Paint(object sender, PaintEventArgs e)
        {
            NomeComida.Text = NomeItem;
            string maisIngredientes = "";
            /*int cont1 = 0;
            foreach (var ingred in IngredientesItem)
            {
                if (maisIngredientes.Equals("")){
                    maisIngredientes = ingred;
                    cont1++;
                }
                else
                {
                    if (cont1 > 4)
                    {
                        cont1 = 0;
                        maisIngredientes += "\n";
                    }
                    maisIngredientes += " / "+ingred;
                    cont1++;
                }
                
            }*/
            IngredienteComida.Text = maisIngredientes;
            qtdComida.Text = qtdItem.ToString();
            string maisCategoria = "";
            /*int cont2 = 0;
            foreach (var aliment in CategoriasItem)
            {
                if (CategoriasItem.Count > 3)
                {
                    if (maisCategoria.Equals(""))
                    {
                        maisCategoria = aliment;
                        cont2++;
                    }
                    else
                    {
                        if(cont2 == 3)
                        {
                            maisCategoria += " e mais ...";
                            break;
                        }
                        maisCategoria += " / " + aliment;
                        cont2++;
                    }
                }
                else
                {
                    if (maisCategoria.Equals(""))
                    {
                        maisCategoria = aliment;
                    }
                    else
                    {
                        maisCategoria += " / " + aliment;
                    }
                }
            }*/
            CategoriasPrato.Text = maisCategoria;
            lb_rs.Text += PrecoItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }        
    }
}
