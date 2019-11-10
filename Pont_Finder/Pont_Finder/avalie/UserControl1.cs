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

            userhora.Text = (post.Tempohora);
            userboxproblema.Text = (post.Tipoproblema);
            userboxlocalizacao.Text = (post.Localizacao);
            userboxdescricao.Text = (post.Desc);
            pictureBox1.ImageLocation = post.Img;
        }
    }
}
