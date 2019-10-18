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
    public partial class Hospedagem_DetalhesEmpresa : Form
    {
        public Hospedagem_DetalhesEmpresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hospedagem_CadQuarto cadQuarto = new Hospedagem_CadQuarto();
            cadQuarto.ShowDialog();
        }
    }
}
