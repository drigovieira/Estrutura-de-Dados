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

        private void button2_Click_1(object sender, EventArgs e)
        {
             hospedagem.Listas_quartos lta_quartos = new hospedagem.Listas_quartos();
            
             
        }

        private void Hospedagem_DetalhesEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
