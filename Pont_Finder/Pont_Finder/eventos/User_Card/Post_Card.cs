using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class Post_Card : UserControl
    {
        Classes.CoEvento post;
        public Post_Card(int postid)
        {
            InitializeComponent();

            post = Classes.Eventos_List.PosterId(postid);

            pb_imagem.ImageLocation = post.Imagem1;
            lb_nome.Text = post.Nome;
            lb_ingressos.Text = ""+post.IngressosTotal;
            lb_data.Text = post.Data;
            lb_categoria.Text = post.Categoria;
            lb_valor.Text = post.Valor;
            lb_classifica.Text = post.Idade;
            lb_local.Text = post.Local;
            


        }

        private void Post_Card_Load(object sender, EventArgs e)
        {

        }

        private void Lb_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bt_visualizar_Click(object sender, EventArgs e)
        {
            eventos.Visualizar_evento viewpost = new eventos.Visualizar_evento(post.Id);
            FormPrincipal.MudarForm("Eventos", viewpost);

            //eventos.Visualizar_evento visu = new eventos.Visualizar_evento(post.Id);
            //visu.ShowDialog();


            //eventos.Visualizar_evento viewEvento = new eventos.Visualizar_evento(post.Id);
            //FormPrincipal.MudarForm("eventos", viewEvento);
        }
    }
}
