using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos.socialist
{
    public partial class UserControl_ChatUser : UserControl
    {
        classes.Post post;
        User user;
        string tipo;

        public UserControl_ChatUser(int postId, string tipo, long userCpf)
        {
            this.post = classes.PostList.thisSelectId(postId);
            this.user = UserList.selectCpf(userCpf);
            this.tipo = tipo;


            InitializeComponent();
        }

        private void UserControl_ChatUser_Load(object sender, EventArgs e)
        {
            pb_icone.ImageLocation = user.Image;
            lb_servico.Text += post.Titulo;
            lb_username.Text += user.Nome;
            lb_status.Text += "Em Beta!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new socialist.FormSociaListEmpresa(post.Id, user.Cpf));
        }
    }
}
