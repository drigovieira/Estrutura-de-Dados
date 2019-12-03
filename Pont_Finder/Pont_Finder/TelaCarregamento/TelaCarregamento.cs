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
                int valor = progressBar1.Value;

                 if(valor == 20)
                {
                    this.BackColor = Color.FromArgb(30, 125, 204);
                    lb_modulos.Text ="Serviços";
                }
                else if (valor == 40)
                {
                    this.BackColor = Color.FromArgb(69, 172, 20);
                    lb_modulos.Text = "Hospedagem";
                }
                else if (valor == 60)
                {
                    this.BackColor = Color.FromArgb(129, 78, 210);
                    lb_modulos.Text = "Eventos";
                }
                else if (valor == 80)
                {
                    this.BackColor = Color.DeepSkyBlue;
                    lb_modulos.Text = "Reclame";
                }
            }
        }

        private void TelaCarregamento_Load(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            timer1.Start();
        }
    }
}
