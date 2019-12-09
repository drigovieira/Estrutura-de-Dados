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
        Form anterior;

        public FormPostEdit(int postId, Form anterior)
        {
            this.anterior = anterior;
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



            FormPrincipal.MudarForm("servicos", anterior);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            tb_descricao.MaxLength = 300;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_titulo_TextChanged(object sender, EventArgs e)
        {
            tb_titulo.MaxLength = 30;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_valor_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPostEdit_Load(object sender, EventArgs e)
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

        private void Cb_combinar_CheckedChanged(object sender, EventArgs e)
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
    }
}
