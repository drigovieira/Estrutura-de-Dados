using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.Boleto
{
    public partial class GerarBoleto : Form
    {

        string cpfboleto,
                valorboleto;

        public GerarBoleto()
        {
            InitializeComponent();
        }

        public GerarBoleto(long cpf, double valor)
        {
            InitializeComponent();
            cpfboleto = cpf.ToString();
            valorboleto = valor.ToString();

            cpflabel.Text = Session.Cpf.ToString();
            valorlabel.Text = "R$ "+valorboleto+",00";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            invisible();
            Print();
            visible();


        }

        private void GerarBoleto_Load(object sender, EventArgs e)
        {

        }

        public void Print()
        {
            Bitmap bmp = new Bitmap(boletoA.Width, boletoA.Height);
            DrawToBitmap(bmp, new Rectangle(0, 0, boletoA.Width, boletoA.Height));
            string link = "..//..//avalie//data//imagens//posts//" + cpfboleto + ".jpg";
            bmp.Save(link, ImageFormat.Jpeg);
            MessageBox.Show("Teste");

        }

        public void invisible()
        {
            btnPrint.Visible = false;
            btnSalvar.Visible = false;
        }

        public void visible()
        {
            btnPrint.Visible = true;
            btnSalvar.Visible = true;
        }

    }
}
