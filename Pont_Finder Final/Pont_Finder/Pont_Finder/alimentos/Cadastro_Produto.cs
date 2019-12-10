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
            if(CompanyList.selectAll()[idEmpresa].SttsCardapio == true)
            {
                cbCardapio.Checked = true;
                cbDelivery.Visible = true;
                if(CompanyList.selectAll()[idEmpresa].SttsEntrega == true)
                {
                    cbDelivery.Checked = true;
                }
            }
            else
            {
                cbCardapio.Checked = false;
            }
        }
        public void Listar()
        {
            foreach (var item in ListCardapio.selectAll())
            {
                if (item.IdEmpresa == Company)
                {
                    Item_Alimentos AliItem = new Item_Alimentos(item.Preco, item.Nome, item.Image, item.Qtd, item.Ingredientes, item.Categoria, item.Id, Company, false, item.Quantos, true);
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

        private void CbCardapio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCardapio.Checked == true)
            {                
                Company comp = CompanyList.selectAll()[Company];
                comp.SttsCardapio = true;
                CompanyList.alter(Company, comp);
                cbDelivery.Visible = true;
                if (CompanyList.selectAll()[Company].SttsEntrega == true) cbDelivery.Checked = true;
            }
            else
            {
                Company comp = CompanyList.selectAll()[Company];
                comp.SttsCardapio = false;
                CompanyList.alter(Company, comp);
                cbDelivery.Visible = false;
            }
        }

        private void CbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelivery.Checked == true)
            {
                Company comp = CompanyList.selectAll()[Company];
                comp.SttsEntrega = true;
                CompanyList.alter(Company, comp);
            }
            else
            {                
                Company comp = CompanyList.selectAll()[Company];
                comp.SttsEntrega = false;
                CompanyList.alter(Company, comp);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Cardapio cadCardapio = new Cadastro_Cardapio(Company);
            FormPrincipal.MudarForm("alimentos", cadCardapio);
        }
    }
}
