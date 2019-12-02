using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.TelaCarregamento
{
    public partial class TelaCarregamento : Form
    {
        int move = 0;


        public TelaCarregamento()
        {
            InitializeComponent();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panelslide.Left += 10; // Velocidade

            if(panelslide.Left > 450) // Limite Até Onde A Barra Vai percorrer
            {
                panelslide.Left = 0;
            }
            if(panelslide.Left < 10)
            {
                move = 1;
            }

        }

        private void TelaCarregamento_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
