using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class Post_Card : UserControl
    {
        Classes.CoEvento post;
        public Post_Card(int postid)
        {
            InitializeComponent();
            post = Classes.Eventos_List.PosterId(postid);

            pb_imagem.ImageLocation = post.Imagem1;
            lb_nome.Text = post.Nome;
           // lb_ingressos.Text = post.Ingress
        }

        private void Post_Card_Load(object sender, EventArgs e)
        {

        }
    }
}
