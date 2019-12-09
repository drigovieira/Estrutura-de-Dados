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
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\entre_modulos\\1.png"));
            texto.Add("Hospedagem");
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\entre_modulos\\2.png"));
            texto.Add("Hospedagem");
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\entre_modulos\\3.png"));
            texto.Add("Eventos");
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\entre_modulos\\4.png"));
            texto.Add("Alimentos");
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\entre_modulos\\5.png"));
            texto.Add("Alimentos");
        }

        private void Propaganda_externa_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
