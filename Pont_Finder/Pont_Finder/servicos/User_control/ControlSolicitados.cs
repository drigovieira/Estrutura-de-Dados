using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Pont_Finder.servicos.User_control
{
    public partial class ControlSolicitados : UserControl
    {
        classes.Solicitado solicitado;
        classes.Post post;
        classes.Empresa empresa;
        public ControlSolicitados(int id)
        {
            solicitado = classes.SolicitadoList.thisForId(id);
            post = classes.PostList.thisForId(solicitado.Postid);
            empresa = classes.ListaEmpresa.thisForCpf(post.Cpf);
            InitializeComponent();

            pb_icone.ImageLocation = solicitado.Imagem;
            pb_user.ImageLocation = empresa.Image;
            lb_titulo.Text += post.Titulo;
            lb_status.Text += solicitado.Status;
            lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.post.Valor);
            lb_data.Text += solicitado.DataAgendada;
            lb_empresa.Text = empresa.NomeFantasia;


        }

        private void Bt_obter_Click(object sender, EventArgs e)
        {

        }

        private void Lb_descricao_Click(object sender, EventArgs e)
        {

        }

        private void ControlSolicitados_Load(object sender, EventArgs e)
        {

        }
    }
}
