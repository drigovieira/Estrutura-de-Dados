using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Hosp_Home : Form
    {
        public Hosp_Home()
        {
            InitializeComponent();

            bt_Cad_Empresa.Visible = true;
            Btn_Edit_Empresa.Visible = false;

            if (Session.Online)
            {
                Empresa emp = hostList.selectCpf(Session.Cpf);
                if (emp == null)
                {
                    bt_Cad_Empresa.Visible = true;
                    Btn_Edit_Empresa.Visible = false;
                }
                else
                {
                    bt_Cad_Empresa.Visible = false;
                    Btn_Edit_Empresa.Visible = true;
                }
            }

        }


        private void Hosp_Home_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("..\\..\\data\\images\\carrousel\\home\\3.png");
            pnl_img.BackgroundImage = image;
        }

        

        private void Bt_Cad_Empresa_Click(object sender, EventArgs e)
        {   
            
            if (Session.Online)
            {
                hospedagem.Cadastro_Empresa cadEmpre = new Cadastro_Empresa();
                FormPrincipal.MudarForm("hospedagem", cadEmpre);
            }
            else
            {
                MessageBox.Show("Faça login com sua conta para poder cadastrar sua empresa!");
            }
                
        }

        private void btn_salvar_empresa_Click(object sender, EventArgs e)
        {
            XML xmlli = new XML();

            xmlli.Drop();
            int cont = 0;
            foreach (var item in hostList.selectAll())
            {
                xmlli.Add(cont, item.Nomeempresa, item.Nomefantasia, item.CNPJ, item.Endereco, item.Cep, item.Telefone, item.Email, item.Foto, item.Tipo, item.Estrelas, item.Descricao, item.Ambiente, item.Ativo);
                cont++;
            }

            MessageBox.Show("Dados Salvos");

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Edit_Empresa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EDITAR EMPRESA");
        }
    }
}
