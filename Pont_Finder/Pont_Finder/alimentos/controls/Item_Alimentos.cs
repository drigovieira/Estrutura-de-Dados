using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Pont_Finder.alimentos.classes;

namespace Pont_Finder.alimentos
{
    public partial class Item_Alimentos : UserControl
    {
        private string NomeItem, ImageItem, maisIngredientes, maisCategoria;
        private float PrecoItem, qtdItem;
        private List<string> IngredientesItem, CategoriasItem;
        private int IdItem, Empresa, QuantosItem;
        private bool ExRes, Pedidos;

        private void Quant_ValueChanged(object sender, EventArgs e)
        {
            if(Quant.Value == 0)
            {
                Quant.Value = 1;
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            ListCardapio.Delete(IdItem);
            Cadastro_Produto cadProd = new Cadastro_Produto(Empresa);
            FormPrincipal.MudarForm("alimentos", cadProd);
        }

        private void Bt_addLista_Click(object sender, EventArgs e)
        {
            if (bt_addLista.Text.Equals("Pedir"))
            {
                object[] obj = new object[7];
                obj[0] = IdItem;
                obj[1] = NomeItem;
                obj[2] = ImageItem;
                obj[3] = maisIngredientes;
                obj[4] = PrecoItem;
                obj[5] = qtdItem;
                obj[6] = Quant.Value;
                Carrinho.Add(obj);
                bt_addLista.BackColor = System.Drawing.Color.DimGray;
                bt_addLista.Text = "Remover";                
            }
            else
            {
                Carrinho.Remove(IdItem);
                bt_addLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
                bt_addLista.Text = "Pedir";
            }
        }

        public Item_Alimentos(float Preco, string Nome, string Imagem, float Qtd, List<string> Ingredientes, List<string> Categorias, int Id, int idEmpresa, bool reserva, int quantos, bool pedido)
        {
            NomeItem = Nome;
            ImageItem = Imagem;
            PrecoItem = Preco;
            qtdItem = Qtd;
            IngredientesItem = Ingredientes;
            CategoriasItem = Categorias;
            IdItem = Id;
            maisIngredientes = "";
            maisCategoria = "";
            ExRes = reserva;
            Empresa = idEmpresa;
            QuantosItem = quantos;
            Pedidos = pedido;
            InitializeComponent();
            if (ListCardapio.select(Id).Image != null)
                pb_alimento.ImageLocation = CompanyList.select(Id).Image;
            else
                pb_alimento.ImageLocation = "..//..//alimentos//data//image//cardapio//offImage.jpg";
            int cont1 = 0;
            foreach (var ingred in IngredientesItem)
            {
                if (maisIngredientes.Equals(""))
                {
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
                    maisIngredientes += " / " + ingred;
                    cont1++;
                }
            }
            int cont2 = 0;
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
                        if (cont2 == 3)
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
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Item_Alimentos_Paint(object sender, PaintEventArgs e)
        {
            NomeComida.Text = NomeItem;                
            IngredienteComida.Text = maisIngredientes;
            qtdComida.Text = "Kg "+ qtdItem.ToString("N2");                        
            CategoriasPrato.Text = maisCategoria;
            lb_rs.Text = PrecoItem.ToString("C", CultureInfo.CurrentCulture);
            if (ExRes == false)
            {
                Quant.Visible = false;
                label1.Visible = false;
                bt_addLista.Visible = false;
                Excluir.Visible = true;
            }
            else
            {
                Excluir.Visible = false;
            }
            if(Pedidos == false)
            {
                Quant.Visible = false;
                label1.Visible = false;
                bt_addLista.Visible = false;
                Excluir.Visible = false;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }        
    }
}
