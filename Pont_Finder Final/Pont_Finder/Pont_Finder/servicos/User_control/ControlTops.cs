using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos.User_control
{
    public partial class ControlTops : UserControl
    {
        classes.Post post;
        classes.Empresa empresa;
        public ControlTops(int id)
        {
            post = classes.PostList.thisForId(id);
            empresa = classes.ListaEmpresa.ForCpf(post.Cpf);
            InitializeComponent();
            lb_servico.Text = post.Titulo;
            lb_categoria.Text = empresa.Categoria;
            pb_icone.ImageLocation = post.Image;
        }

        private void ControlTops_Load(object sender, EventArgs e)
        {

        }

        private void ControlTops_MouseClick(object sender, MouseEventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, new FormServicos()));
        }
    }
}
