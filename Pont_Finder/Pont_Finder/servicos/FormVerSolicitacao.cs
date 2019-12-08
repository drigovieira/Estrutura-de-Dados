using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormVerSolicitacao : Form
    {
        classes.Solicitado solicitado;
        classes.Post post;
        classes.Empresa empresa;
        User user;
        public FormVerSolicitacao(int id)
        {
            solicitado = classes.SolicitadoList.thisForId(id);
            post = classes.PostList.thisForId(solicitado.Postid);
            empresa = classes.ListaEmpresa.thisForCpf(post.Cpf);
            user = UserList.selectCpf(solicitado.Usercpf);
            InitializeComponent();
            lb_empresa.Text = empresa.Nome;
            lb_categoria.Text = empresa.Categoria;
            lb_servico.Text = post.Titulo;
            lb_data_solicitacao.Text = "" + solicitado.DataSolicitacao;
            lb_data_agendamento.Text = "" + solicitado.DataAgendada;
            lb_valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.post.Valor);
            lb_username.Text = user.Nome;
            lb_usercpf.Text = "" + user.Cpf;
            pb_solicitado.ImageLocation = solicitado.Imagem;
            lb_descricao.Text = solicitado.Descrição;
            lb_endereco.Text = solicitado.Rua + ", " + solicitado.Numero;



        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void FormVerSolicitacao_Load(object sender, EventArgs e)
        {

        }
    }
}
