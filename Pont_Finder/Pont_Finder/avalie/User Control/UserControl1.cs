using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class UserControl1 : UserControl
    {

        private PostConstructor post;

        public UserControl1(long postid)
        {
            InitializeComponent();
            post = PostList.PosterId(postid);

            NomePos.Text = (post.Nome);
            imagemuser.ImageLocation = (post.Imgperfil);
            
            userhora.Text = (post.Tempohora);
            userboxproblema.Text = (post.Tipoproblema);
            userboxlocalizacao.Text = (post.Localizacao);
            userboxdesc.Text = (post.Desc);
            pictureBox1.ImageLocation = post.Img;
           
            if(post.Resolved == true)
            {
                checado.Visible = true;
            }
            else
            {
                checado.Visible = false;
            }
            
            if(Session.Cpf == post.Cpf)
            {
                bt_editar.Visible = true;
            }
            else
            {
                bt_editar.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_obter_Click(object sender, EventArgs e)
        {
            avalie.ViewPost avaliepost = new ViewPost(post.Id);
            FormPrincipal.MudarForm("Reclame", avaliepost);

            /*
            if (Session.Online)
            {
                avalie.ViewPost avaliepost = new ViewPost();
                FormPrincipal.MudarForm("Reclame", avaliepost);
            }
            else
            {
                MessageBox.Show("Por Favor, Efetue o Login para Realizar um Post");
            }
            */
        }

        private void userhora_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            avalie.EditeMeusPosts avaliepost = new EditeMeusPosts(post.Id);
            FormPrincipal.MudarForm("Reclame", avaliepost);

        }
    }
}
