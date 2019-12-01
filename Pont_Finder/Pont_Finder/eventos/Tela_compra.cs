using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class Tela_compra : Form
    {
        public Tela_compra()
        {
            InitializeComponent();
        }

        private void Bt_boleto_Click(object sender, EventArgs e)
        {
            eventos.Tela_Boleto boleto = new eventos.Tela_Boleto();
            FormPrincipal.MudarForm("eventos", boleto);
        }

        private void Bt_cartao_Click(object sender, EventArgs e)
        {
            eventos.Cartao cartao = new eventos.Cartao();
            FormPrincipal.MudarForm("eventos", cartao);
        }
    }
}
