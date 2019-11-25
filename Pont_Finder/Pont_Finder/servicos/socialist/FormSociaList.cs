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
    public partial class FormSociaList : Form
    {

        classes.Post post;
        classes.Empresa empresa;
        classes.Empresa userEmpresa;
        string tipo;


        public FormSociaList(int postId, string tipo)
        {
            this.tipo = tipo;

            
            if (postId != -1 && tipo.Equals("cliente"))
            {
                post = classes.PostList.SelectId(postId);
                empresa = classes.ListaEmpresa.selectCpf(this.post.Cpf);
            }
            else if (postId != -1 && tipo.Equals("empresa"))
            {
                post = classes.PostList.SelectId(postId);
               // this.userEmpresa = classes.ListaEmpresa.selectCpf(Session.Cpf);
            }
            else
            {
                post = null;
                empresa = null;
            }

            if (tipo.Equals("empresa"))
            {
                this.userEmpresa = classes.ListaEmpresa.selectCpf(Session.Cpf); ;
            }


                InitializeComponent();
        }

        private void FormSociaList_Load(object sender, EventArgs e)
        {
            if (tipo.Equals("cliente"))
            {
                pb_userimage.ImageLocation = Session.Image;
                lb_username.Text = Session.Nome;

                int y = 5;
                panel_chat.Height = 180;
                int i = 0;
                foreach (var item in SolicitadoList.Solicitados)
                {
                    if (item.CpfUser.Equals(Session.Cpf))
                    {
                        UserControl_ChatEmpresa a = new UserControl_ChatEmpresa(item.PostId, tipo);
                        a.Location = new Point(10, (y));
                        y = y + a.Height + 5;
                        panel_chat.Height = panel_chat.Height + 180;
                        panel_chat.Controls.Add(a);
                        i++;
                    }
                }

                if (post != null)
                {
                    lb_empresa.Text = empresa.Nome;
                    pb_empresa.ImageLocation = empresa.Image;

                    foreach (var item in MensagemList.Mensagens)
                    {
                        if (item.PostId == post.Id && item.De == Session.Cpf && item.Para == post.Cpf)
                        {
                            tb_mensagens.Text += Session.Nome + ": " + item.Msg + "\n";
                        }
                        else if (item.PostId == post.Id && item.Para == Session.Cpf && item.De == post.Cpf)
                        {
                            tb_mensagens.Text += empresa.NomeFantasia + ": " + item.Msg + "\n";
                        }
                    }
                }
                else
                {
                    lb_empresa.Text = "";
                    pb_empresa.Visible = false;
                }
            }
            else if (tipo.Equals("empresa") && Session.Online)
            {
                //caso for empresa

                pb_userimage.ImageLocation = userEmpresa.Image;
                lb_username.Text = userEmpresa.NomeFantasia;
            }
          

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tb_mensagem.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Mensagem msg = new Mensagem();
            msg.De = Session.Cpf;
            msg.Para = post.Cpf;
            msg.PostId = post.Id;
            msg.Msg = tb_mensagem.Text;


            MensagemList.Mensagens.Add(msg);
            tb_mensagens.Clear();
            foreach (var item in MensagemList.Mensagens)
            {
                if (item.PostId == post.Id && item.De == Session.Cpf && item.Para == post.Cpf)
                {
                    tb_mensagens.Text += Session.Nome + ": " + item.Msg + "\n";
                }
                else if (item.PostId == post.Id && item.Para == Session.Cpf && item.De == post.Cpf)
                {
                    tb_mensagens.Text += empresa.NomeFantasia + ": " + item.Msg + "\n";
                }
            }
           

            tb_mensagem.Clear();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

   
    }
}
