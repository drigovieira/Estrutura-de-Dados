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
    public partial class Reservar_quarto : Form
    {
        public Reservar_quarto()
        {
            InitializeComponent();
        }

        private void rb_boleto_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (rb_boleto.Checked)
                {
                    hospedagem.data.inc.Reserva_boleto boleto = new data.inc.Reserva_boleto();
                    boleto.Location = new Point(0, 0);
                    panel_center.Controls.Add(boleto);
                }
                else
                {
                    panel_center.Controls.Clear();
                }
            }
        }

        private void rb_cartao_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cartao.Checked)
            {
                hospedagem.data.inc.Reserva_cartao cartao = new data.inc.Reserva_cartao();
                cartao.Location = new Point(0, 0);
                panel_center.Controls.Add(cartao);
            }
            else
            {
                panel_center.Controls.Clear();
            }
        }
    }
}
