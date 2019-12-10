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
    public partial class Card_boleto : UserControl
    {
        double valorBoleto;
        public Card_boleto(long cpf,double valor)
        {
            InitializeComponent();
            valorBoleto = valor;
        }

        private void Bt_finalizar_Click(object sender, EventArgs e)
        {
            Classes.ComprEvento cm = new Classes.ComprEvento();

            MessageBox.Show("Compra Realizada Com Sucesso");
            Boleto.GerarBoleto bol = new Boleto.GerarBoleto(Session.Cpf, valorBoleto);
            bol.ShowDialog();
        }

        private void Bt_limpar_Click(object sender, EventArgs e)
        {
            tb_boleto_nome.Clear();
            tb_boleto_email.Clear();
            mkb_boleto_RG.Clear();
            mkb_boleto_CPF.Clear();
        }
    }
}
