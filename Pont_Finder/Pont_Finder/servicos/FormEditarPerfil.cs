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
    public partial class FormEditarPerfil : Form
    {
        classes.Empresa empresa;

        private bool img = false;
        private bool capa = false;


        public FormEditarPerfil()
        {
            empresa = classes.ListaEmpresa.thisForCpf(Session.Cpf);
            InitializeComponent();
            lb_fantasia.Text = empresa.NomeFantasia;
            lb_categoria.Text = empresa.Categoria;
            lb_email.Text = empresa.Email;
            tb_telefone.Text = empresa.Telefone;
            tb_endereco.Text = empresa.Endereco;
            pb_icone.ImageLocation = empresa.Image;

            tb_site.Text = empresa.Site;
            pb_capa.ImageLocation = empresa.ImageCapa;
            tb_descricao.Text = empresa.Descricao;
            tb_slogan.Text = empresa.Slogan;
            tb_sobre.Text = empresa.Sobre;
            tb_privacidade.Text = empresa.PoliticaPrivacidade;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEditarPerfil_Load(object sender, EventArgs e)
        {

        }

        private void Bt_icone_Click(object sender, EventArgs e)
        {

            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }

        private void Bt_capa_Click(object sender, EventArgs e)
        {

            if (openCapa.ShowDialog() == DialogResult.OK)
            {
                pb_capa.ImageLocation = openCapa.FileName;
                pb_capa.Load();
                capa = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string link = null;
            if (img)
            {
                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;
                link = "..//..//servicos//data//images//empresas//" + empresa.Cnpj + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
                empresa.Image = link;
            }

            link = null;
            if (capa)
            {
                if (!Directory.Exists("..//..//servicos//data//images//empresas//capas"))
                    Directory.CreateDirectory("..//..//servicos//data//images//empresas//capas");

                pb_capa.Load();
                pb_capa.Image = Image.FromFile(openCapa.FileName);

                Image bmp = new Bitmap(pb_capa.Image);

                Image bmp2 = new Bitmap(bmp, pb_capa.Size);

                pb_capa.Image = bmp2;

                link = "..//..//servicos//data//images//empresas//capas//" + empresa.Cnpj + ".jpg";
                pb_capa.Image.Save(link, ImageFormat.Jpeg);

                empresa.ImageCapa = link;
            }

            empresa.Site = tb_site.Text;
            empresa.Slogan = tb_slogan.Text;
            empresa.Descricao = tb_descricao.Text;
            empresa.Sobre = tb_sobre.Text;
            empresa.PoliticaPrivacidade = tb_privacidade.Text;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new PerfilEmpresa());
        }
    }
}
