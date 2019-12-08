using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class FormTermosDeUso : Form
    {
        public FormTermosDeUso()
        {
            Session.Termos = false;
            InitializeComponent();
        }

        private void Lb_descricao_Click(object sender, EventArgs e)
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
