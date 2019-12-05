using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class FormUserCards : Form
    {
        Form anterior;
        public FormUserCards(Form anterior)
        {
            this.anterior = anterior;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos",new FormCadServico(new FormUserCards(anterior)) );
        }

        private void FormUserCards_Load(object sender, EventArgs e)
        {
            int y = 5;           
            int i = 0;

            List<classes.Post> lista = classes.PostList.PostsAtivo;
            lista.Reverse();

            foreach (var item in lista)
            {
                if (item.Cpf == Session.Cpf)
                {
                    /*
                    if (i > 8)
                        break;
                    */
                    PostCardEdit a = new PostCardEdit(item.Id, anterior);
                    a.Location = new Point(25, y);
                    y = y + a.Height + 5;
                    painel.Controls.Add(a);
                    i++;
                }                              

            }

            
        }

        private void Painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.Image = Properties.Resources.back_2;
        }

        private void Btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_1;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", anterior);
        }
    }
}
