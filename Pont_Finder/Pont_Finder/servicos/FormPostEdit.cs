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

namespace Pont_Finder.servicos
{
    public partial class FormPostEdit : Form
    {
        classes.Post post;
        private bool img = false;

        public FormPostEdit(int postId)
        {
            post = classes.PostList.SelectId(postId);
            InitializeComponent();
            tb_titulo.Text = post.Titulo;
            tb_valor.Text = "" + post.Valor;
            tb_descricao.Text = post.Descricao;
            pb_icone.ImageLocation = post.Image;

        }

        private void Publicar_Click(object sender, EventArgs e)
        {
            post.Titulo = tb_titulo.Text;
            post.Valor = double.Parse(tb_valor.Text);
            post.Descricao = tb_descricao.Text;

            string link = null;
            if (img)
            {
                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;
                string nome = tb_valor.Text;
                int id = classes.PostList.Tam;
                link = "..//..//servicos//data//images//posts//" + id + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
                post.Image = link;
            }



            FormPrincipal.MudarForm("servicos", new FormUserCards());
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormUserCards());
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
