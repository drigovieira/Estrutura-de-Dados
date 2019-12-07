using Pont_Finder.alimentos.classes;
using Pont_Finder.alimentos.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Reserva_Alimentos : Form
    {
        private int local, Company;
        public Reserva_Alimentos(int idEmpresa)
        {
            Company = idEmpresa;
            local = 0;
            InitializeComponent();
            Listar();
        }                
        
        private void Btn_back_Click(object sender, EventArgs e)
        {
            Carrinho.Drop();
            formAlimentos homeAlimentos = new formAlimentos();
            FormPrincipal.MudarForm("alimentos", homeAlimentos);
        }

        private void Bt_visualizar_Click(object sender, EventArgs e)
        {
            if (Carrinho.selectAll().Count != 0)
            {
                Delivery_Alimentos delivery = new Delivery_Alimentos();
                FormPrincipal.MudarForm("alimentos", delivery);
            }
            else
            {
                MessageBox.Show("Não exitem itens na lista de pedidos", "Alerta");
            }
        }

        private void Reserva_Alimentos_Paint(object sender, PaintEventArgs e)
        {
            ValueCarrinho.Text = Carrinho.selectAll().Count.ToString();
        }

        public void Listar()
        {
            foreach (var item in ListCardapio.selectAll())
            {
                if (item.IdEmpresa == Company)
                {
                    Item_Alimentos AliItem = new Item_Alimentos(item.Preco, item.Nome, item.Image, item.Qtd, item.Ingredientes, item.Categoria, item.Id, Company, true);
                    AliItem.Location = new Point(0, local);
                    local = local + AliItem.Height + 5;
                    menu.Controls.Add(AliItem);
                }
            }
        }
    }
}
