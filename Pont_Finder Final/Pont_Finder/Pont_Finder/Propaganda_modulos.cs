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
    public partial class Propaganda_modulos : UserControl
    {
        private int cont;
        public List<Bitmap> imagePropaganda = new List<Bitmap>();
        public List<string> texto = new List<string>();
        public Propaganda_modulos()
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
            imagePropaganda.Add(new Bitmap("..\\..\\data\\images\\propagandas\\entre_modulos\\6.png"));
            texto.Add("Serviços");

        }

        private void Propaganda_modulos_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int num = rdn.Next(0, imagePropaganda.Count);
            pb_propaganda1.BackgroundImage = imagePropaganda[num];
            lb_texto.Text = texto[num];
            cont = num;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int num = rdn.Next(0, imagePropaganda.Count);
            pb_propaganda1.BackgroundImage = imagePropaganda[num];
            lb_texto.Text = texto[num];
            cont = num;
        }

        private void Pb_propaganda1_Click(object sender, EventArgs e)
        {
            if (texto[cont] == "Hospedagem")
            {
                FormPrincipal.MudarForm("hospedagem", new hospedagem.Hosp_Home());
            }

            if (texto[cont] == "Alimentos")
            {
                FormPrincipal.MudarForm("alimentos", new formAlimentos());
            }

            if (texto[cont] == "Eventos")
            {
                FormPrincipal.MudarForm("eventos", new eventos.FormEventos());
            }
            if (texto[cont] == "Serviços")
            {
                FormPrincipal.MudarForm("servicos", new servicos.FormServicos());
            }

        }
    }
}
