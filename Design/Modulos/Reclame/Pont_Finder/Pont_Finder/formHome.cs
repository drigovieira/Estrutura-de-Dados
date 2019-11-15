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
        public List<Image> imageList = new List<Image>();
        public formHome()
        {
            InitializeComponent();         
            for (int i = 0; i < 4; i++)
            {
                imageList.Add(Image.FromFile("..\\..\\data\\images\\carrousel\\home\\" + i + ".png"));
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button__Almentos_Click(object sender, EventArgs e)
        {
            FormPrincipal.Mudar(Botao(sender).Text);
        }
        private Button Botao(object sender) => (Button)sender;

        private int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (cont == 4)
                cont = 0;           
            pn_slider.BackgroundImage = imageList[cont];
            cont++;
        }

        private void pc_slider_Click(object sender, EventArgs e)
        {

        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }
    }
}
