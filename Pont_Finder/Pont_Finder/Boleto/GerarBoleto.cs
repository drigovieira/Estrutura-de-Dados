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
            Random rdn = new Random();
            cpfboleto = cpf.ToString();
            lb_cpf.Text = "CPF: "+Session.Cpf.ToString();
            valorboleto = valor.ToString();

            nome.Text = "Nome: " + Session.Nome;
            end.Text = "Rua: Alameda das Hortensias";

            //cpflabel.Text = Session.Cpf.ToString();
            valorlabel.Text = "R$ "+valorboleto+",00";
            CalcularN();
            data.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            dataPross.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            lb_num_doc.Text = rdn.Next(10000, 99999).ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
                Bitmap bmp = new Bitmap(boletoA.Width+100, boletoA.Height+100);
                DrawToBitmap(bmp, new Rectangle(0, 0, boletoA.Width+100, boletoA.Height+100));
                bmp.Save(salvardiretorio.FileName);

            }
            MessageBox.Show("Boleto Salvo Com Sucesso");

        }
        

        public void Printer()
        {
            
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
            
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(boletoA.Width, boletoA.Height);
            boletoA.DrawToBitmap(bm, new Rectangle(0, 0, boletoA.Width, boletoA.Height));
            e.Graphics.DrawImage(bm, 4, 0);
            bm.Dispose();
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
            btnSalvar.Visible = false;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            invisible();
            Printer();
            visible();
        }

        private void boletoA_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CalcularN()
        {
            Random rdn = new Random();

                   string cbip1,
                   seila = rdn.Next(10000, 99999).ToString(), 
                   p2 = rdn.Next(10000, 99999).ToString(),
                   p3 = rdn.Next(10000, 99999).ToString(),
                   p4 = rdn.Next(10000, 99999).ToString(),
                   p5 = rdn.Next(10000, 99999).ToString(),
                   p6 = rdn.Next(10000, 99999).ToString(),
                   p7 = rdn.Next(0, 9).ToString(),
                   p8 = rdn.Next(0, 9).ToString(),
                   valp91 = (5676).ToString(),
                   valp92 = "00000",
                   valp93 = valorboleto+ "00";

                   rdn.Next(0, 99999).ToString();

                   lb_num_codigo_barra.Text = ("00193" + "." + p2 + " " + p3 + "." + p4 + " " + p5 + "." + p6 + " " + p7 + " " + valp91 + valp92 + valp93);
                    lb_numero.Text = seila;
        }


    }
}
