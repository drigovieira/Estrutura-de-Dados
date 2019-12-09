using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class Propaganda_externa : UserControl
    {
        private int cont;
        public List<Bitmap> imagePropaganda = new List<Bitmap>();
        public List<string> texto = new List<string>();
        public Propaganda_externa()
        {
            InitializeComponent();
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\externa\\1.png"));
            texto.Add("Shoes");
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\externa\\2.png"));
            texto.Add("Mochila Medium");
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\externa\\3.png"));
            texto.Add("shoes");
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\externa\\4.png"));
            texto.Add("Mochila Big");
        }

        private void Propaganda_externa_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int num = rdn.Next(0, imagePropaganda.Count);
            pb_propaganda1.BackgroundImage = imagePropaganda[num];
            lb_texto.Text = texto[num];
            cont = num;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int num = rdn.Next(0, imagePropaganda.Count);
            pb_propaganda1.BackgroundImage = imagePropaganda[num];
            lb_texto.Text = texto[num];
            cont = num;
        }

        private void Pb_propaganda1_Click(object sender, EventArgs e)
        {
        }
    }
}
