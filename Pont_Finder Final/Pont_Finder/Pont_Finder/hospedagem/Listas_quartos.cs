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
    public partial class Listas_quartos : Form
    {
        Form anterior;
        public Listas_quartos(Form anterior)
        {



            this.anterior = anterior;
            InitializeComponent();

            Empresa empresa = hostList.selectCpf(Session.Cpf);

            lb_nomeEmpresa.Text = empresa.Nomefantasia;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hospedagem.Cad_Quarto cadQuarto = new Cad_Quarto(new Listas_quartos(new Hosp_Home()));
            FormPrincipal.MudarForm("hospedagem", cadQuarto); 
        }

        private void Listas_quartos_Load(object sender, EventArgs e)
        {
            int y = 5;
            int i = 0;
            long cnpj = 0;

            List<Quarto> lista = roomList.quartosAtivos();
            lista.Reverse();

            Empresa emp = hostList.selectCpf(Session.Cpf);

            if (Session.Online)
            {
                cnpj = emp.CNPJ;
            }

            foreach (var item in lista)
            {
                if (item.Cnpj_Empresa == cnpj)
                {
                    Card_list_quarto a = new Card_list_quarto(item.ID);
                    a.Location = new Point(25, y);
                    y = y + a.Height + 5;
                    panel1.Controls.Add(a);
                    i++;
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("hospedagem", anterior);
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }
    }
}
