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
        private List<Quarto> ListadeQuartos;

        private int y = 5;
        public Hosp_Home()
        {
            InitializeComponent();

            bt_Cad_Empresa.Visible = true;
            Btn_Edit_Empresa.Visible = false;
            bt_gerenciar_quartos.Visible = false;

            if (Session.Online)
            {
                Empresa emp = hostList.selectCpf(Session.Cpf);
                if (emp == null)
                {
                    bt_Cad_Empresa.Visible = true;
                    Btn_Edit_Empresa.Visible = false;
                    bt_gerenciar_quartos.Visible = false;
                }
                else
                {

                    bt_Cad_Empresa.Visible = false;
                    Btn_Edit_Empresa.Visible = true;
                    bt_gerenciar_quartos.Visible = true;
                }
            }

            ListadeQuartos = roomList.Quartos;
            ListadeQuartos.Reverse();


        }


        private void Hosp_Home_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("..\\..\\data\\images\\carrousel\\home\\3.png");
            pnl_img.BackgroundImage = image;

            panel_center.Height = 180;
            int i = 0;

            foreach (var item in ListadeQuartos)
            {
                if (i > 8)
                    break;
                Hosp_PostCard a = new Hosp_PostCard(item.ID);
                a.Location = new Point(0, (y));
                y = y + a.Height + 5;
                panel_center.Height = panel_center.Height + 180;
                panel_center.Controls.Add(a);
                i++;
            }

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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Edit_Empresa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EDITAR EMPRESA");
        }

        private void bt_gerenciar_quartos_Click(object sender, EventArgs e)
        {
            hospedagem.Listas_quartos listaQuartos = new Listas_quartos();
            FormPrincipal.MudarForm("hospedagem", listaQuartos);
        }

        private void panel_center_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
