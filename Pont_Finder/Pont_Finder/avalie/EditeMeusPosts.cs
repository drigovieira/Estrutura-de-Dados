using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie
{
    public partial class EditeMeusPosts : Form
    {
        PostConstructor post;

        public EditeMeusPosts()
        {
            InitializeComponent();
        }

        private void tb_resposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_postar_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

        }

        private void bt_remover_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditeMeusPosts_Load(object sender, EventArgs e)
        {

        }

        private void bt_postar_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click_1(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (this.post != null && (tb_problema.Text.Trim() != "") && (tb_descricao.Text.Trim() != "") && (pb_imagem.Text.Trim() != "") && (tb_localizacao.Text.Trim() != ""))
                {
                    MessageBox.Show("senhor, foi editado");
                    post.Tipoproblema = tb_problema.Text;
                    post.Desc = tb_descricao.Text;
                    post.Localizacao = tb_localizacao.Text;
                    
                }
                else
                {
                    MessageBox.Show("senhor, digite o comeentario");
                }
            }
            else
            {
                MessageBox.Show("tem que logar");
            }
        }
    }
}
