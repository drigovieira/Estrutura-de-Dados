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
    public partial class Listas_quartos : Form
    {
        public Listas_quartos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hospedagem_CadQuarto cadQuarto = new Hospedagem_CadQuarto();
            cadQuarto.ShowDialog();
        }
    }
}
