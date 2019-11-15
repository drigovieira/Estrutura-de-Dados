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
        public Listas_quartos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hospedagem.Cad_Quarto cadQuarto = new Cad_Quarto();
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
    }
}
