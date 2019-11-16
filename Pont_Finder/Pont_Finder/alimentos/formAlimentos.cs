using Pont_Finder.alimentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class formAlimentos : Form
    {
        private int local, local1;
        private List<Company> lista = new List<Company>();
        private ProfileList prof = new ProfileList();
        public formAlimentos()
        {
            local = 0;
            local1 = 0;
            InitializeComponent();
            Listar();
        }

        private void FormAlimentos_Load(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Restaurante cadastrarestabele = new alimentos.Cadastro_Restaurante();
            FormPrincipal.MudarForm("alimentos", cadastrarestabele);

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (CategoriaBox.Visible == false)
            {
                if (PesquisaBox.Text.Equals(""))
                {
                    ListarEmpresas.Controls.Clear();
                    lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                    msg.Location = new Point(0, 0);
                    ListarEmpresas.Controls.Add(msg);
                }
                else
                {
                    List<Company> listaBusca = new List<Company>();
                    listaBusca = CompanyList.SearchName(PesquisaBox.Text);
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in listaBusca)
                    {
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                    }
                }
            }
            else
            {
                if (PesquisaBox.Text.Equals(""))
                {
                    ListarEmpresas.Controls.Clear();
                    lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                    msg.Location = new Point(0, 0);
                    ListarEmpresas.Controls.Add(msg);
                }
                else
                {
                    List<Company> listaBusca = new List<Company>();
                    listaBusca = CompanyList.SearchFiltro(PesquisaBox.Text, CategoriaBox.SelectedItem.ToString());
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in listaBusca)
                    {
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                    }
                }
            }
            /*List<ProfileCompany> BuscaPerfis = prof.profileList(listaBusca, CategoriaBox.SelectedItem.ToString());
            local1 = 0;
            Top5.Controls.Clear();
            foreach (var busca in prof.TopList(BuscaPerfis))
            {
                if (busca.NotaApurada != 0)
                {
                    foreach (var teste2 in comp.selectAll())
                    {
                        if (busca.CodigoCompany == comp.selectAll().IndexOf(teste2))
                        {
                            TopEmpresa te = new TopEmpresa(teste2.NomeFantasia);
                            te.Location = new Point(0, local1);
                            local1 = local1 + te.Height + 5;
                            Top5.Controls.Add(te);
                        }
                    }
                }
            }
            */
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            if (CategoriaBox.Visible == false)
            {
                if (CategoriaBox.SelectedItem != null) {
                    lbTop5.Text = "Top 5 " + CategoriaBox.SelectedItem.ToString();
                    List<Company> listaBusca = new List<Company>();
                    listaBusca = CompanyList.SearchCategoria(CategoriaBox.SelectedItem.ToString());
                    List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, CategoriaBox.SelectedItem.ToString());
                    local1 = 0;
                    Top5.Controls.Clear();
                    foreach (var busca in ProfileList.TopList(BuscaPerfis))
                    {
                        if (busca.NotaApurada != 0)
                        {
                            foreach (var teste2 in CompanyList.selectAll())
                            {
                                if (busca.CodigoCompany == CompanyList.selectAll().IndexOf(teste2))
                                {
                                    TopEmpresa te = new TopEmpresa(teste2.NomeFantasia);
                                    te.Location = new Point(0, local1);
                                    local1 = local1 + te.Height + 5;
                                    Top5.Controls.Add(te);
                                }
                            }
                        }
                    }
                }
                Filtrar.Text = "Sem Filtro";
                lbCategoria.Visible = true;
                CategoriaBox.Visible = true;
            }
            else
            {
                lbTop5.Text = "Top 5 Restaurantes";
                Filtrar.Text = "Filtrar";
                lbCategoria.Visible = false;
                CategoriaBox.Visible = false;
                local1 = 0;
                Top5.Controls.Clear();
                foreach (var teste in ProfileList.TopList(ProfileList.selectAll()))
                {
                    foreach (var teste2 in CompanyList.selectAll())
                    {
                        if (teste.CodigoCompany == CompanyList.selectAll().IndexOf(teste2))
                        {
                            TopEmpresa te = new TopEmpresa(teste2.Nome);
                            te.Location = new Point(0, local1);
                            local1 = local1 + te.Height + 5;
                            Top5.Controls.Add(te);
                        }
                    }
                }
            }
        }

        private void CategoriaBox_SelectedValueChanged(object sender, EventArgs e)
        {
            lbTop5.Text = "Top 5 " + CategoriaBox.SelectedItem.ToString();
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(CategoriaBox.SelectedItem.ToString());
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, CategoriaBox.SelectedItem.ToString());
            local1 = 0;
            Top5.Controls.Clear();
            foreach (var busca in ProfileList.TopList(BuscaPerfis))
            {
                if (busca.NotaApurada != 0)
                {
                    foreach (var teste2 in CompanyList.selectAll())
                    {
                        if (busca.CodigoCompany == CompanyList.selectAll().IndexOf(teste2))
                        {
                            TopEmpresa te = new TopEmpresa(teste2.NomeFantasia);
                            te.Location = new Point(0, local1);
                            local1 = local1 + te.Height + 5;
                            Top5.Controls.Add(te);
                        }
                    }
                }
            }
        }

        private void Btn_Edit_Empresa_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Restaurante cadastrarestabele = new alimentos.Cadastro_Restaurante();
            FormPrincipal.MudarForm("alimentos", cadastrarestabele);
        }

        private void pb_pesquisar_Click(object sender, EventArgs e)
        {
            if (CategoriaBox.Visible == false)
            {
                if (PesquisaBox.Text.Equals(""))
                {
                    ListarEmpresas.Controls.Clear();
                    lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                    msg.Location = new Point(0, 0);
                    ListarEmpresas.Controls.Add(msg);
                }
                else
                {
                    List<Company> listaBusca = new List<Company>();
                    listaBusca = CompanyList.SearchName(PesquisaBox.Text);
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in listaBusca)
                    {
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                    }
                }
            }
            else
            {
                if (PesquisaBox.Text.Equals(""))
                {
                    ListarEmpresas.Controls.Clear();
                    lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                    msg.Location = new Point(0, 0);
                    ListarEmpresas.Controls.Add(msg);
                }
                else
                {
                    List<Company> listaBusca = new List<Company>();
                    listaBusca = CompanyList.SearchFiltro(PesquisaBox.Text, CategoriaBox.SelectedItem.ToString());
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in listaBusca)
                    {
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                    }
                }
            }
            /*List<ProfileCompany> BuscaPerfis = prof.profileList(listaBusca, CategoriaBox.SelectedItem.ToString());
            local1 = 0;
            Top5.Controls.Clear();
            foreach (var busca in prof.TopList(BuscaPerfis))
            {
                if (busca.NotaApurada != 0)
                {
                    foreach (var teste2 in comp.selectAll())
                    {
                        if (busca.CodigoCompany == comp.selectAll().IndexOf(teste2))
                        {
                            TopEmpresa te = new TopEmpresa(teste2.NomeFantasia);
                            te.Location = new Point(0, local1);
                            local1 = local1 + te.Height + 5;
                            Top5.Controls.Add(te);
                        }
                    }
                }
            }
            */
        }

        private void Top5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RbChurrascaria_CheckedChanged(object sender, EventArgs e)
        {
            lbTop5.Text = "Top 5 " + rbChurrascaria.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbChurrascaria.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbChurrascaria.Text);
            local1 = 0;
            Top5.Controls.Clear();
            foreach (var busca in ProfileList.TopList(BuscaPerfis))
            {
                if (busca.NotaApurada != 0)
                {
                    foreach (var teste2 in CompanyList.selectAll())
                    {
                        if (busca.CodigoCompany == CompanyList.selectAll().IndexOf(teste2))
                        {
                            TopEmpresa te = new TopEmpresa(teste2.NomeFantasia);
                            te.Location = new Point(0, local1);
                            local1 = local1 + te.Height + 5;
                            Top5.Controls.Add(te);
                        }
                    }
                }
            }
        }

        public void Listar()
        {            
            foreach (var teste in ProfileList.TopList(ProfileList.selectAll()))
            {
                foreach (var teste2 in CompanyList.selectAll())
                {
                    if (teste.CodigoCompany == CompanyList.selectAll().IndexOf(teste2))
                    {
                        TopEmpresa te = new TopEmpresa(teste2.Nome);
                        te.Location = new Point(0, local1);
                        local1 = local1 + te.Height + 5;
                        Top5.Controls.Add(te);
                    }
                }
            }

            lista = CompanyList.selectAll();
            foreach (var item in lista)
            {
                Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                exbEmp.Location = new Point(0, local);
                local = local + exbEmp.Height + 5;
                ListarEmpresas.Controls.Add(exbEmp);
            }
        }
    }
}
