using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos.socialist
{
  

    public partial class FormSociaListEmpresa : Form
    {

        classes.Empresa empresa;
        User usuario;


        public FormSociaListEmpresa(long userCpf)
        {
            empresa = classes.ListaEmpresa.selectCpf(Session.Cpf);
            if (userCpf == -1)
            {
                this.usuario = null;
            }
            else
            {
                this.usuario = UserList.selectCpf(userCpf);
            }
            InitializeComponent();
        }

        private void Lb_username_Click(object sender, EventArgs e)
        {

        }

        private void FormSociaListEmpresa_Load(object sender, EventArgs e)
        {
            lb_empresa.Text = empresa.Nome;
            pb_empresa.ImageLocation = empresa.Image;

            if (usuario != null)
            {
                lb_username.Text = usuario.Nome;
                pb_usericone.ImageLocation = usuario.Image;
            }

            int y = 5;
            panel_chat.Height = 180;
            int i = 0;
            foreach (var item in SolicitadoList.Solicitados)
            {
                classes.Post tPost = classes.PostList.SelectId(item.PostId);
                if (tPost.Cpf == Session.Cpf)
                {
                    UserControl_ChatEmpresa a = new UserControl_ChatEmpresa(item.PostId, "empresa");
                    a.Location = new Point(10, (y));
                    y = y + a.Height + 5;
                    panel_chat.Height = panel_chat.Height + 180;
                    panel_chat.Controls.Add(a);
                    i++;
                }
            }


        }
    }
}
