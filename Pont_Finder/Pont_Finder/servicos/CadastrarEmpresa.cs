using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class CadastrarEmpresa : Form
    {
        public CadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void Bt_continuar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string fatasia = tb_fantasia.Text;
            long cnpj = long.Parse(tb_cep.Text);
            string endereco = tb_endereco.Text;
            string telefone = tb_telefone.Text;
            string email = tb_email.Text;
        }

        private void Tb_endereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
