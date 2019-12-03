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
        FormPrincipal fors = new FormPrincipal();


        public TelaCarregamento()
        {
            InitializeComponent();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timer1.Interval == 2000)
            {
                this.Visible = false;
                customProgressBar1.Value = customProgressBar1.Value + 1;
            }
            /*panelslide.Left += 10; // Velocidade

            if(panelslide.Left > 450) // Limite Até Onde A Barra Vai percorrer
            {
                panelslide.Left = 0;
            }
            if(panelslide.Left < 10)
            {
                move = 1;
            }
            */

            /*
            if (customProgressBar1.Value < 100)
            {
                customProgressBar1.Value = customProgressBar1.Value + 1;



            }
            else
            {
                timer1.Enabled = false;
                Application.Exit();
            }

            }
            */


            

        }

        private void TelaCarregamento_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
