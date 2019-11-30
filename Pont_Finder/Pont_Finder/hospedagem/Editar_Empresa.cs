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
    public partial class Editar_Empresa : Form
    {
        public Editar_Empresa()
        {
            InitializeComponent();
        }

        private void ckb_wifi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_lugarPet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_academia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_salaJogos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_piscina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_estacionamento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnl_ambDisp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tb_nameEmp_TextChanged(object sender, EventArgs e)
        {
            tb_nameEmp.MaxLength = 50;
        }

        private void Tb_nameFantasy_TextChanged(object sender, EventArgs e)
        {
            tb_nameFantasy.MaxLength = 75;
        }

        private void Tb_endereco_TextChanged(object sender, EventArgs e)
        {
            tb_endereco.MaxLength = 50;
        }

        private void Tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.MaxLength = 50;
        }
    }
}
