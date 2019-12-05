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

        private void Card_cartao_Load(object sender, EventArgs e)
        {
            if (tb_cartao_num.Text.Equals("") || mkb_cartao_vencimento.Text.Equals("")||cb_cartao_cod.Text.Equals("")||tb_cartao_titular.Text.Equals("")||mkb_boleto_CPF.Text.Equals("")||cb_select_cartao.SelectedItem==("")||cb_qtd_parcelas.SelectedItem==("")){
                MessageBox.Show("Preencha todos os campos");
            }

            else
            {
                string cartao_num = this.tb_cartao_num.Text;
                



            }
           
        }

        private void Tb_cartao_num_TextChanged(object sender, EventArgs e)
        {
        

        }
    }
}
