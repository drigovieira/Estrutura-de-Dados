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
    public partial class Cadastro_Produto : Form
    {
        private int local, Company;
        public Cadastro_Produto(int idEmpresa)
        {
            Company = idEmpresa;
            local = 0;
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            foreach (var item in ListCardapio.selectAll())
            {
                if (item.IdEmpresa == Company)
                {
                    Item_Alimentos AliItem = new Item_Alimentos(item.Preco, item.Nome, item.Image, item.Qtd, item.Ingredientes, item.Categoria, item.Id, Company, false);
                    AliItem.Location = new Point(0, local);
                    local = local + AliItem.Height + 5;
                    Cardapio.Controls.Add(AliItem);
                }
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            formAlimentos homeAlimentos = new formAlimentos();
            FormPrincipal.MudarForm("alimentos", homeAlimentos);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Cardapio cadCardapio = new Cadastro_Cardapio(Company);
            FormPrincipal.MudarForm("alimentos", cadCardapio);
        }
    }
}
