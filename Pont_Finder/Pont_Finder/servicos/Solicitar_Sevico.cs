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
    public partial class Solicitar_Sevico : Form
    {
        Form anterior;
        classes.Post post;

        public Solicitar_Sevico(int postid, Form anterior)
        {
            post = classes.PostList.thisForId(postid);
            this.anterior = anterior;
            InitializeComponent();
        }

        private void Bt_continuar_Click(object sender, EventArgs e)
        {
            
        

        }

        private void Solicitar_Sevico_Load(object sender, EventArgs e)
        {

        }

        private void tbBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_solicitar_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, anterior));
        }

        private void Bt_icone_Click(object sender, EventArgs e)
        {

        }
    }
}
