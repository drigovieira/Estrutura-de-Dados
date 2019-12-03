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
        private int pagTotal;
        private int pagAtual;
        private int pagQuant;
        private int local, local1;
        private bool cat;
        private string filtro;
        private List<Company> lista = new List<Company>();
        private ProfileList prof = new ProfileList();
        private object[] result;
        public formAlimentos()
        {
            cat = false;
            local = 0;
            local1 = 0;
            pagQuant = 10;
            lista = CompanyList.selectAll();
            InitializeComponent();
            if (Session.Online)
            {
                result = CompanyList.verifEmp(Session.Cpf);
                if(result[0] != null)
                {
                    btn_Config.Visible = true;
                }                
            }
            else btn_Config.Visible = false;
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
                    lista = CompanyList.SearchName(PesquisaBox.Text);
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in lista)
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
                    lista = CompanyList.SearchFiltro(PesquisaBox.Text, Filtro());
                    ListarEmpresas.Controls.Clear();
                    local = 0;
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
            if (Session.Online)
            {
                alimentos.Cadastro_Restaurante cadastrarestabele = new alimentos.Cadastro_Restaurante();
                FormPrincipal.MudarForm("alimentos", cadastrarestabele);
            }
            else
            {
                MessageBox.Show("É necessário estar logado para Cadastrar uma empresa. ", "Aviso");
            }            
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
                    lista = CompanyList.SearchName(PesquisaBox.Text);
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in lista)
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
                    lista = CompanyList.SearchFiltro(PesquisaBox.Text, Filtro());
                    ListarEmpresas.Controls.Clear();
                    local = 0;
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

            //Listando Empresas
            pagTotal = CompanyList.selectAll().Count;
            if ((pagTotal % pagQuant) != 0)
            {
                pagTotal = (pagTotal / pagQuant);
                pagTotal++;
            }
            else
            {
                pagTotal = pagTotal / pagQuant;
            }
            pagAtual = 1;
            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;

            int i = 0;

            foreach (var item in lista)
            {
                if (i >= pagQuant)
                    break;
                Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                exbEmp.Location = new Point(0, local);
                local = local + exbEmp.Height + 5;
                ListarEmpresas.Controls.Add(exbEmp);
                i++;
            }
        }

        private void Bt_ant_Click(object sender, EventArgs e)
        {
            GoPag("anterior");
        }

        private void Bt_prox_Click(object sender, EventArgs e)
        {
            GoPag("proxima");
        }

        private void Bt_proxFull_Click(object sender, EventArgs e)
        {
            GoPag("ultima");
        }

        private void Bt_antFull_Click(object sender, EventArgs e)
        {
            GoPag("primeira");
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (lbConfig1.Visible == false && lbConfig2.Visible == false)
            {
                lbConfig1.Visible = true;
                lbConfig2.Visible = true;
            }
            else
            {
                lbConfig1.Visible = false;
                lbConfig2.Visible = false;
            }
        }

        private void LbConfig1_MouseMove(object sender, MouseEventArgs e)
        {
            lbConfig1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
        }

        private void LbConfig1_MouseLeave(object sender, EventArgs e)
        {
            lbConfig1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
        }

        private void LbConfig2_MouseMove(object sender, MouseEventArgs e)
        {
            lbConfig2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
        }

        private void LbConfig2_MouseLeave(object sender, EventArgs e)
        {
            lbConfig2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
        }

        private void LbConfig1_Click(object sender, EventArgs e)
        {
            alimentos.Editar_Restaurante editRest = new Editar_Restaurante();
            FormPrincipal.MudarForm("alimentos", editRest);
        }

        private void LbConfig2_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Produto gerenProd = new Cadastro_Produto(int.Parse(result[0].ToString()));
            FormPrincipal.MudarForm("alimentos", gerenProd);
        }

        public void GoPag(string p)
        {            
            int pagina;

            if (p.Equals("ant") || p.Equals("anterior"))
                pagina = -1;
            else if (p.Equals("prox") || p.Equals("proxima")) 
                pagina = -2;            
            else if (p.Equals("1") || p.Equals("primeira"))
                pagina = 1;
            else if (p.Equals("0") || p.Equals("ultima"))
                pagina = pagTotal;
            else
                pagina = int.Parse(p);


            if (lista.Count > pagQuant)
            {
                if (pagina == 1 && (pagAtual > 1))
                {
                    local = 0;
                    ListarEmpresas.Controls.Clear();

                    int i = 0;
                    foreach (var item in lista)
                    {
                        if (i >= pagQuant)
                            break;
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                        i++;
                    }
                    lb_pag.Text = "Pagina " + 1 + " de " + pagTotal;
                    pagAtual = 1;

                }
                else if (pagina == pagTotal && (pagAtual < pagTotal))
                {
                    local = 0;
                    ListarEmpresas.Controls.Clear();

                    int pg = ((pagTotal - 1) * pagQuant);
                    for (int i = 0; i < pagQuant; i++)
                    {
                        if (pg + i < lista.Count)
                        {
                            Publi exbEmp = new Publi(lista[pg + i].NomeFantasia, lista[pg + i].Rua, lista[pg + i].Bairro, lista[pg + i].Numero, lista[pg + i].TelComercial, lista[pg + i].Categoria, lista[pg + i].Id);
                            exbEmp.Location = new Point(0, local);
                            local = local + exbEmp.Height + 5;
                            ListarEmpresas.Controls.Add(exbEmp);
                        }

                    }

                    pagAtual = pagTotal;
                    lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;

                }
                else if (pagina == -1)
                {
                    if (pagAtual > 1)
                    {
                        local = 0;
                        ListarEmpresas.Controls.Clear();

                        int pg = ((pagAtual - 2) * pagQuant);

                        for (int i = 0; i < pagQuant; i++)
                        {
                            if (pg + i < lista.Count)
                            {
                                Publi exbEmp = new Publi(lista[pg + i].NomeFantasia, lista[pg + i].Rua, lista[pg + i].Bairro, lista[pg + i].Numero, lista[pg + i].TelComercial, lista[pg + i].Categoria, lista[pg + i].Id);
                                exbEmp.Location = new Point(0, local);
                                local = local + exbEmp.Height + 5;
                                ListarEmpresas.Controls.Add(exbEmp);
                            }
                        }
                        pagAtual--;

                        lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
                    }
                }
                else if (pagina == -2)
                {
                    if (pagAtual < pagTotal)
                    {
                        local = 0;
                        ListarEmpresas.Controls.Clear();                        
                        int pg = (pagAtual * pagQuant);

                        for (int i = 0; i < pagQuant; i++)
                        {
                            if (pg + i < lista.Count)
                            {
                                Publi exbEmp = new Publi(lista[pg + i].NomeFantasia, lista[pg + i].Rua, lista[pg + i].Bairro, lista[pg + i].Numero, lista[pg + i].TelComercial, lista[pg + i].Categoria, lista[pg + i].Id);
                                exbEmp.Location = new Point(0, local);
                                local = local + exbEmp.Height + 5;
                                ListarEmpresas.Controls.Add(exbEmp);
                            }

                        }
                        pagAtual++;
                        lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
                    }
                }
            }
        }
    }
}
