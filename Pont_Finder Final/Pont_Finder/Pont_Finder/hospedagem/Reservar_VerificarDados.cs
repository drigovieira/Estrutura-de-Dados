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
    public partial class Reservar_VerificarDados : Form
    {
        Form anterior;
        public Reservar_VerificarDados(Form anterior)
        {
            this.anterior = anterior;
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rb_boleto_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_boleto.Checked) 
            {
                hospedagem.data.inc.User_boleto b = new data.inc.User_boleto();
                b.Location = new Point(0, 0);
                pn_formaPagamento.Controls.Add(b);
            }
            else
            {
                pn_formaPagamento.Controls.Clear();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rb_cartao_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cartao.Checked)
            {
                hospedagem.data.inc.User_Cartao c = new data.inc.User_Cartao();
                c.Location = new Point(0, 0);
                pn_formaPagamento.Controls.Add(c);
            }
            else
            {
                pn_formaPagamento.Controls.Clear();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
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
