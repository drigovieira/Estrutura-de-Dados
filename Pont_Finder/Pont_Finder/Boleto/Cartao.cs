using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.Boleto
{
    public partial class Cartao : Form
    {
        public Cartao()
        {
            Session.Termos = false;
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Cartao_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Session.Termos = true;
            this.Dispose();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Session.Termos = false;
            this.Dispose();
        }
    }
}
