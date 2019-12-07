using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
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

        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();

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
            CalcularN();
            data.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        
        //PRINTANDO Begin

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Printer(boletoA);

        }

        public void Printer(Panel painelboleto)
        {
            PrinterSettings ps = new PrinterSettings();
            boletoA = painelboleto;
            getprintarea(painelboleto);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();
        }

        public void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width) - (this.boletoA.Width/1), this.boletoA.Location.Y);
           
        }


        Bitmap memoryimg;

        public void getprintarea(Panel painelboleto)
        {
            memoryimg = new Bitmap(painelboleto.Width, painelboleto.Height);
            painelboleto.DrawToBitmap(memoryimg, new Rectangle(0, 0, painelboleto.Width, painelboleto.Height));
        }


        //PRINTANDO END

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


        public void CalcularN()
        {
            Random rdn = new Random();

                    string cbip1,
                   p2 = rdn.Next(10000, 99999).ToString(),
                   p3 = rdn.Next(10000, 99999).ToString(),
                   p4 = rdn.Next(10000, 99999).ToString(),
                   p5 = rdn.Next(10000, 99999).ToString(),
                   p6 = rdn.Next(10000, 99999).ToString(),
                   p7 = rdn.Next(0, 9).ToString(),
                   p8 = rdn.Next(0, 9).ToString(),
                   valp91 = (5676).ToString(),
                   valp92 = "00000",
                   valp93 = valorboleto;

                   rdn.Next(0, 99999).ToString();

                   lb_num_codigo_barra.Text = ("00193" + "." + p2 + " " + p3 + "." + p4 + " " + p5 + "." + p6 + " " + p7 + " " + valp91 + valp92 + valp93);
        }


    }
}
