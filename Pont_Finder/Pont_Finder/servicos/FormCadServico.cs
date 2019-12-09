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
  
    public partial class FormCadServico : Form
    {
        classes.Empresa empresa;
        Form anterior;
        private bool img = false;

        public FormCadServico(Form anterior)
        {
            this.anterior = anterior;
            empresa = classes.ListaEmpresa.ForCpf(Session.Cpf);
            InitializeComponent();
           
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

            classes.Post post = new classes.Post();
            post.Id = classes.PostList.Tam;
            post.Titulo = tb_titulo.Text;

            if (cb_combinar.Checked)
            {
                tb_valor.Enabled = false;
                post.Valor = 0;
            }
            else
            {
                tb_valor.Enabled = true;
                post.Valor = double.Parse(tb_valor.Value + "");
            }

           
            post.Descricao = tb_descricao.Text;
            post.Image = link;
            post.Data = DateTime.Now;
            post.Cnpj = empresa.Cnpj;
            classes.PostList.Add(post);
            FormPrincipal.MudarForm("servicos", anterior);
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", anterior);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_combinar.Checked)
            {
                tb_valor.Enabled = false;
            }
            else
            {
                tb_valor.Enabled = true;
            }
        }

        private void FormCadServico_Load(object sender, EventArgs e)
        {

        }
    }
}
