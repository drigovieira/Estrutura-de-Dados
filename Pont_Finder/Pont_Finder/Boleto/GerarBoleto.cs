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

            //cpflabel.Text = Session.Cpf.ToString();
            valorlabel.Text = "R$ "+valorboleto+",00";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           


        }

        private void GerarBoleto_Load(object sender, EventArgs e)
        {

        }

        public void Print()
        {
            SaveFileDialog salvardiretorio = new SaveFileDialog();
            salvardiretorio.Filter = ("PNG(*.PNG)| *.PNG");

            if(salvardiretorio.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(boletoA.Width, boletoA.Height);
                DrawToBitmap(bmp, new Rectangle(0, 0, boletoA.Width, boletoA.Height));
                bmp.Save(salvardiretorio.FileName);

            }
            MessageBox.Show("Boleto Salvo Com Sucesso");

        }

        public void invisible()
        {
            btnPrint.Visible = false;
            btnSalvar.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            


            invisible();
            Print();
            visible();

        }

        public void visible()
        {
            btnPrint.Visible = true;
            btnSalvar.Visible = true;
        }

    }
}
