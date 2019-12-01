using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pont_Finder.servicos.socialist
{
    public partial class FormSociaListUser : Form
    {

        classes.Post post;
        classes.Empresa empresa;

        public FormSociaListUser(int postId)
        {
            InitializeComponent();
            if (postId != -1)
            {
                post = classes.PostList.ForId(postId);
                empresa = classes.ListaEmpresa.ForCpf(this.post.Cpf);
            }
            else
            {
                post = null;
                empresa = null;
            }
        }

        private void FormSociaList_Load(object sender, EventArgs e)
        {
            pb_userimage.ImageLocation = Session.Image;
            lb_username.Text = Session.Nome;

            int y = 5;
            panel_chat.Height = 180;
            int i = 0;
            foreach (var item in ChatList.Chats)
            {
                if (item.CpfUser.Equals(Session.Cpf))
                {
                    UserControl_ChatEmpresa a = new UserControl_ChatEmpresa(item.PostId, "cliente");
                    a.Location = new Point(10, (y));
                    y = y + a.Height + 5;
                    panel_chat.Height = panel_chat.Height + 180;
                    panel_chat.Controls.Add(a);
                    i++;
                }
            }

            if (post == null)
            {
                lb_empresa.Visible = false;
                pb_empresa.Visible = false;
            }
            else
            {
                lb_empresa.Text = empresa.Nome;
                pb_empresa.ImageLocation = empresa.Image;
                MensagensLoad();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tb_mensagem.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (post == null)
            {
                MessageBox.Show("Nenhum Chat Selecionado");
            }
            else
            {
                Mensagem msg = new Mensagem();
                msg.De = Session.Cpf;
                msg.Para = post.Cpf;
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
                if (item.PostId == post.Id && item.De == Session.Cpf && item.Para == post.Cpf)
                    tb_mensagens.Text += Session.Nome + ": " + item.Msg + "\n";
                else if (item.PostId == post.Id && item.Para == Session.Cpf && item.De == post.Cpf)
                    tb_mensagens.Text += empresa.NomeFantasia + ": " + item.Msg + "\n";
            }
        }
    }
}
