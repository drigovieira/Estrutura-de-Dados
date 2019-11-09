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
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Hospedagem_Click(object sender, EventArgs e)
        {
            FormPrincipal fn = new FormPrincipal();
            hospedagem.FormHospedagem fHp = new hospedagem.FormHospedagem();

            fHp.TopLevel = false;
            fHp.Show();
        }

        private void button__Almentos_Click(object sender, EventArgs e)
        {

        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }
    }
}
