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
        public FormSociaList()
        {
            InitializeComponent();
        }

        private void FormSociaList_Load(object sender, EventArgs e)
        {
            int y = 5;
            pb_userimage.ImageLocation = Session.Image;
            lb_username.Text = Session.Nome;


            panel_chat.Height = 180;
            int i = 0;
            for (int j = 0; j < 3; j++)
            {
                UserControl_ChatEmpresa a = new UserControl_ChatEmpresa();
                a.Location = new Point(10, (y));
                y = y + a.Height + 5;
                panel_chat.Height = panel_chat.Height + 180;
                panel_chat.Controls.Add(a);
                panel_chat.Controls.Add(a);
                i++;
            }

          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tb_mensagem.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tb_mensagens.Text += Session.Nome +": "+ tb_mensagem.Text + "\n";
            tb_mensagem.Clear();
        }
    }
}
