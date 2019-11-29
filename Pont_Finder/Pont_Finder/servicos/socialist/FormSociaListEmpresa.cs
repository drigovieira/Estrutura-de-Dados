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
        classes.Post post;
        classes.Empresa empresa;
        User usuario;

        public FormSociaListEmpresa(int postId, long userCpf)
        {
            empresa = classes.ListaEmpresa.ForCpf(Session.Cpf);

            if (userCpf == -1)
            {
                this.usuario = null;
                this.post = null;
            }
            else
            {
                this.post = classes.PostList.SelectId(postId);
                this.usuario = UserList.selectCpf(userCpf);
            }

            InitializeComponent();
        }

        private void FormSociaListEmpresa_Load(object sender, EventArgs e)
        {
            lb_empresa.Text = empresa.Nome;
            pb_empresa.ImageLocation = empresa.Image;

            int y = 5;
            panel_chat.Height = 180;
            int i = 0;
            foreach (var item in SolicitadoList.Solicitados)
            {
                classes.Post tPost = classes.PostList.SelectId(item.PostId);
                if (tPost.Cpf == Session.Cpf)
                {
                    UserControl_ChatUser a = new UserControl_ChatUser(item.PostId, "empresa", item.CpfUser);
                    a.Location = new Point(10, (y));
                    y = y + a.Height + 5;
                    panel_chat.Height = panel_chat.Height + 180;
                    panel_chat.Controls.Add(a);
                    i++;
                }
            }

            if (usuario == null)
            {
                lb_username.Visible = false;
                pb_usericone.Visible = false;
            }
            else
            {
                lb_username.Text = usuario.Nome;
                pb_usericone.ImageLocation = usuario.Image;
                MensagensLoad();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("Nenhum Chat Selecionado");
            }
            else
            {
                Mensagem msg = new Mensagem();
                msg.De = Session.Cpf;
                msg.Para = usuario.Cpf;
                msg.PostId = post.Id;
                msg.Msg = tb_mensagem.Text;
                MensagemList.Mensagens.Add(msg);
                MensagensLoad();
                tb_mensagem.Clear();
            }

        }

        public void MensagensLoad()
        {
            tb_mensagens.Clear();
            foreach (var item in MensagemList.Mensagens)
            {
                if (item.PostId == post.Id && item.De == Session.Cpf && item.Para == usuario.Cpf)
                    tb_mensagens.Text += empresa.NomeFantasia + ": " + item.Msg + "\n";                
                else if (item.PostId == post.Id && item.Para == Session.Cpf && item.De == usuario.Cpf)
                    tb_mensagens.Text += usuario.Nome + ": " + item.Msg + "\n";                
            }
        }
    }
}
