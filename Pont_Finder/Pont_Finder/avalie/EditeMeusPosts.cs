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

namespace Pont_Finder.avalie
{
    public partial class EditeMeusPosts : Form
    {
        PostConstructor post;
        private bool img = false;


        public EditeMeusPosts(long postId)
        {
            
            InitializeComponent();
            post = PostList.PosterId(postId);
        }

        private void tb_resposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_postar_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditeMeusPosts_Load(object sender, EventArgs e)
        {
            label4.Text = Session.Nome;
            cb_pro.Text = post.Tipoproblema;
            tb_loc.Text = post.Localizacao;
            tb_des.Text = post.Desc;
            pb_icone.ImageLocation = post.Img;
            lb_hora.Text = post.Tempohora;
            NomePos.Text = post.Nome;

        }

        private void bt_postar_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click_1(object sender, EventArgs e)
        {
            post.Tipoproblema = cb_pro.SelectedItem.ToString();
            post.Localizacao = tb_loc.Text;
            post.Desc = tb_des.Text;

            string link = null;
            if (img)
            {
                


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("Reclame", new FormAvalie());
        }
    }
}
