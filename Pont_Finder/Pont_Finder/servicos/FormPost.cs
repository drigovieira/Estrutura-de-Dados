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
    public partial class FormPost : Form
    {
        private bool img = false;
        public FormPost()
        {
            InitializeComponent();
            pb_icone.SizeMode = PictureBoxSizeMode.StretchImage;

            classes.Empresa emp = classes.ListaEmpresa.selectCpf(Session.Cpf);
            if (emp == null)
            {
                bt_empresa.Enabled = false;
            }
            else
            {
                bt_empresa.Enabled = true;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void Publicar_Click(object sender, EventArgs e)
        {
            string link = null;
            if (img)
            {
                if (!Directory.Exists("..//..//servicos//data//images//posts"))
                    Directory.CreateDirectory("..//..//servicos//data//images//posts");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);
              
                Image bmp = new Bitmap(pb_icone.Image);
              
                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;
                string nome = tb_valor.Text;
                int id = classes.PostList.Tam;
                link = "..//..//servicos//data//images//posts//" + id + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }

            classes.Post p = new classes.Post();
            p.Id = classes.PostList.Tam;
            p.Titulo = tb_titulo.Text;
            p.Valor = double.Parse(tb_valor.Text);
            p.Detalhes = tb_detalhes.Text;
            p.Descricao = tb_descricao.Text;
            p.Image = link;
            p.Data = DateTime.Now;
            p.Cnpj = -1;
            classes.PostList.Add(p);
            FormPrincipal.MudarForm("servicos", new FormServicos());
     
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenIcone_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPost_Load(object sender, EventArgs e)
        {
             
        }

        private void Bt_empresa_Click(object sender, EventArgs e)
        {


            string link = null;
            if (img)
            {
                if (!Directory.Exists("..//..//servicos//data//images//posts"))
                    Directory.CreateDirectory("..//..//servicos//data//images//posts");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;
                string nome = tb_valor.Text;
                int id = classes.PostList.Tam;
                link = "..//..//servicos//data//images//posts//" + id + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }

            classes.Empresa emp = classes.ListaEmpresa.selectCpf(Session.Cpf);

            classes.Post p = new classes.Post();
            p.Id = classes.PostList.Tam;
            p.Titulo = tb_titulo.Text;
            p.Valor = double.Parse(tb_valor.Text);
            p.Detalhes = tb_detalhes.Text;
            p.Descricao = tb_descricao.Text;
            p.Image = link;
            p.Data = DateTime.Now;
            p.Cnpj = emp.Cnpj;
            classes.PostList.Add(p);
            FormPrincipal.MudarForm("servicos", new FormServicos());

        }
    }
}
