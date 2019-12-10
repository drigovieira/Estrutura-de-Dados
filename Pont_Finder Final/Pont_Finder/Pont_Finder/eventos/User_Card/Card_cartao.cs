using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos.User_Card
{
    public partial class Card_cartao : UserControl
    {
        public Card_cartao()
        {
            InitializeComponent();
        }

        private void Bt_finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra efetuada com sucesso!");
        }

        private void Bt_limpar_Click(object sender, EventArgs e)
        {
            tb_cartao_num.Clear();
            mkb_cartao_CPF.Clear();
            cb_cartao_cod.Clear();
            tb_cartao_titular.Clear();
            mkb_cartao_vencimento.Clear();
        }
    }
}
