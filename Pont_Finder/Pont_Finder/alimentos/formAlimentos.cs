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
        private bool cat;
        private string filtro;
        private List<Company> lista = new List<Company>();
        private ProfileList prof = new ProfileList();
        public formAlimentos()
        {
            cat = false;
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
            if (Categoria() == false)
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
                    listaBusca = CompanyList.SearchFiltro(PesquisaBox.Text, Filtro());
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
        public bool Categoria()
        {
            if (rbChurrascaria.Checked == false && rbPizzaria.Checked == false && rbPetiscaria.Checked == false && rbComidaItaliana.Checked == false && rbComidaJaponesa.Checked == false && rbSorveteria.Checked == false && rbHambúrgueria.Checked == false && rbFrutosDoMar.Checked == false && rbOutros.Checked == false)
            {
                cat = false;
            }
            else
            {
                cat = true;
            }
            return cat;
        }
        public string Filtro()
        {
            if (rbChurrascaria.Checked == true)
            {
                filtro = rbChurrascaria.Text;
            }
            else if(rbPetiscaria.Checked == true)
            {
                filtro = rbPetiscaria.Text;
            }
            else if(rbPizzaria.Checked == true)
            {
                filtro = rbPizzaria.Text;
            }
            else if(rbComidaItaliana.Checked == true)
            {
                filtro = rbComidaItaliana.Text;
            }
            else if(rbComidaJaponesa.Checked == true)
            {
                filtro = rbComidaJaponesa.Text;
            }
            else if(rbSorveteria.Checked == true)
            {
                filtro = rbSorveteria.Text;
            }
            else if(rbHambúrgueria.Checked == true)
            {
                filtro = rbHambúrgueria.Text;
            }
            else if(rbFrutosDoMar.Checked == true)
            {
                filtro = rbFrutosDoMar.Text;
            }
            else if (rbOutros.Checked == true)
            {
                filtro = rbOutros.Text;
            }
            return filtro;
        }

        private void Btn_Edit_Empresa_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Restaurante cadastrarestabele = new alimentos.Cadastro_Restaurante();
            FormPrincipal.MudarForm("alimentos", cadastrarestabele);
        }

        private void pb_pesquisar_Click(object sender, EventArgs e)
        {
            if (Categoria() == false)
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
                    listaBusca = CompanyList.SearchFiltro(PesquisaBox.Text, Filtro());
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
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
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

        private void RbPizzaria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbPizzaria.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbPizzaria.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbPizzaria.Text);
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

        private void RbPetiscaria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbPetiscaria.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbPetiscaria.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbPetiscaria.Text);
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

        private void RbComidaItaliana_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbComidaItaliana.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbComidaItaliana.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbComidaItaliana.Text);
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

        private void RbComidaJaponesa_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbComidaJaponesa.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbComidaJaponesa.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbComidaJaponesa.Text);
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

        private void RbSorveteria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbSorveteria.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbSorveteria.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbSorveteria.Text);
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

        private void RbHambúrgueria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbHambúrgueria.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbHambúrgueria.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbHambúrgueria.Text);
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

        private void RbFrutosDoMar_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbFrutosDoMar.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbFrutosDoMar.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbFrutosDoMar.Text);
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

        private void RbOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbOutros.Text;
            List<Company> listaBusca = new List<Company>();
            listaBusca = CompanyList.SearchCategoria(rbOutros.Text);
            List<ProfileCompany> BuscaPerfis = ProfileList.profileList(listaBusca, rbOutros.Text);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            remFiltro.Visible = false;
            rbChurrascaria.Checked = false;
            rbPizzaria.Checked = false;
            rbPetiscaria.Checked = false;
            rbSorveteria.Checked = false;
            rbComidaItaliana.Checked = false;
            rbComidaJaponesa.Checked = false;
            rbFrutosDoMar.Checked = false;
            rbHambúrgueria.Checked = false;
            rbOutros.Checked = false;
            lbTop5.Text = "Top 5 Restaurantes";
        }

        private void PesquisaBox_TextChanged(object sender, EventArgs e)
        {
            PesquisaBox.MaxLength = 50;
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
