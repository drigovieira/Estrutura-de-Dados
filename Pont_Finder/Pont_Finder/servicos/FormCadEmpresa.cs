using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormCadEmpresa : Form
    {
        private bool img = false;
        public FormCadEmpresa()
        {
            InitializeComponent();
            pb_icone.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string fatasia = tb_fantasia.Text;
            long cnpj = long.Parse(tb_cep.Text);
            string endereco = tb_endereco.Text;
            string telefone = tb_telefone.Text;
            string email = tb_email.Text;

            string link = null;
            if (img)
            {
                if (!Directory.Exists("..//..//servicos//data//images//empresas"))
                    Directory.CreateDirectory("..//..//servicos//data//images//empresas");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;
                               
                link = "..//..//servicos//data//images//empresas//" + cnpj + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }

            classes.Empresa tmp = new classes.Empresa();
            tmp.Nome = nome;
            tmp.NomeFantasia = fatasia;
            tmp.Email = email;
            tmp.Cnpj = cnpj;
            tmp.Endereco = endereco;
            tmp.Telefone = telefone;
            tmp.Cpf = Session.Cpf;
            tmp.Image = link;
            tmp.Status = true;
            classes.ListaEmpresa.Add(tmp);
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void AddFotoEmpresa_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }
    }
}
