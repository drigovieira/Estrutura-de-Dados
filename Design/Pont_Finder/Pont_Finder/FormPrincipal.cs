using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            //Pegar todas as fontes de um diretório
            foreach (string item in Directory.GetFiles("E:\\ADS\\Estrutura-de-Dados\\Design\\Font - Dubai\\dubai-cufonfonts\\", " *.ttf"))
                pfc.AddFontFile(item);

            //Responder todas as fontes do PrivateFontCollection na página
            foreach (FontFamily font in pfc.Families)
            {
                //Response.Write(font.Name + "<br />");
            }

            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile("E:\\ADS\\Estrutura-de-Dados\\Design\\Font - Dubai\\dubai-cufonfonts\\Dubai-Bold.ttf");
            //label1.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);

            formHome fh = new formHome();
            fh.TopLevel = false;
            panelHome.Controls.Add(fh);
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            fCC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLogin fL = new formLogin();
            fL.ShowDialog();
        }
    }
}
