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
    public partial class FormHospedagem : Form
    {
        public FormHospedagem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospedagem_DetalhesEmpresa detEmpre = new Hospedagem_DetalhesEmpresa();
            detEmpre.ShowDialog();
        }

        private void FormHospedagem_Load(object sender, EventArgs e)
        {

        }
    }
}
