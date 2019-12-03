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
        public TelaCarregamento()
        {
            InitializeComponent();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            FormPrincipal FPrince = new FormPrincipal();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                
                this.Visible = false;
                FPrince.Show();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 5;
                lb_carregar.Text = "Carregando : " + progressBar1.Value.ToString() + " %";
            }
        }

        private void TelaCarregamento_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
        }
    }
}
