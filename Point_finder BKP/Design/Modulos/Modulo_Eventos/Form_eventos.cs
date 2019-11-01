using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Eventos
{
    public partial class Form_eventos : Form
    {
        public Form_eventos()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_fim_de_ano OutroForm = new Form_fim_de_ano();
            OutroForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            case "Eventos":
            Form_eventos fEvent = new Form_eventos();
            {
                TopLevel = false
            };
            painel.Controls.Add(fEvent);
            fEvent.Show();
            navbar.Backcolor = Color.FromArgb(120; 88; 210);
            break;

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form_apres_musical OutroForm = new Form_apres_musical();
            OutroForm.Show();
        }
    }
}
