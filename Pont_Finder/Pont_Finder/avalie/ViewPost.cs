using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class ViewPost : Form
    {

        PostConstructor post;
        classes.Comentario comment;

        public ViewPost(long postId)
        {
            InitializeComponent();

            post = PostList.PosterId(postId);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewPost_Load(object sender, EventArgs e)
        {
            tb_descricao.Text = post.Desc;
            tb_problema.Text = post.Tipoproblema;
            tb_localizacao.Text = post.Localizacao;
            pb_imagem.ImageLocation = post.Img;
            lb_hora.Text = post.Tempohora;
            NomePos.Text = post.Nome;

            if (Session.Online)
            {
                comment = classes.ComentarioList.thisComentario(Session.Cpf, post.Id);

                if (comment != null)
                {
                    tb_resposta.Text = comment.Resposta;
                }

               
            }
            else
            {
                comment = null;
            }




        }

        private void bt_postar_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (this.comment == null && (tb_resposta.Text.Trim() != ""))
                {
                    classes.Comentario comment = new classes.Comentario();
                    comment.PostId = post.Id;
                    comment.UserCpf = Session.Cpf;
                    comment.Comment = "";
                    comment.Resposta = tb_resposta.Text;
                    comment.Status = true;
                    classes.ComentarioList.Add(comment);
                    FormPrincipal.MudarForm("avalie", new ViewPost(post.Id));
                }
                else
                {
                    MessageBox.Show("ja tem candango, edite\nEm branco é bichinho de goiaba");
                }
            }
            else
            {
                MessageBox.Show("tem que logar");
            }

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
           
            if (Session.Online)
            {
                if (this.comment != null && (tb_resposta.Text.Trim() != ""))
                {
                    MessageBox.Show("senhor, foi editado");
                    comment.Resposta = tb_resposta.Text;
                }
                else
                {
                    MessageBox.Show("senhor, digite o comeentario");
                }
            }
            else
            {
                MessageBox.Show("tem que logar");
            }

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            classes.ComentarioList.Remove(Session.Cpf, post.Id);
        }
    }
}
