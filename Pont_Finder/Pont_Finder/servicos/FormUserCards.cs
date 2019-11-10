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
        public FormUserCards()
        {
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
            FormPrincipal.MudarForm("servicos",new FormPost() );
        }

        private void FormUserCards_Load(object sender, EventArgs e)
        {
            int y = 5;           
            int i = 0;
       
            foreach (var item in classes.PostList.PostsAtivo)
            {
                if (item.Cpf == Session.Cpf)
                {
                    if (i > 8)
                        break;
                    PostCardEdit a = new PostCardEdit(item.Id);
                    a.Location = new Point(25, y);
                    y = y + a.Height + 5;
                    painel.Controls.Add(a);
                    i++;
                }                              

            }

            
        }
    }
}
