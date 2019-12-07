using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        bool img = false;

        

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
            classes.Solicitado solicitado = new classes.Solicitado();

            int id = classes.SolicitadoList.Solicitados.Count;
            string link = null;
            if (img)
            {
                if (!Directory.Exists("..//..//servicos//data//images//solicitados"))
                    Directory.CreateDirectory("..//..//servicos//data//images//solicitados");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;
               
                link = "..//..//servicos//data//images//solicitados//" + id + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
                solicitado.Imagem = link;
            }

            solicitado.Id = id;
            solicitado.Status = "Aguardando Pagamento";

            solicitado.Rua = tb_rua.Text;
            solicitado.Bairro = tb_bairro.Text;
            solicitado.Numero = int.Parse(""+tb_numero.Value);
            solicitado.Cep = int.Parse(tb_cep.Text);
            solicitado.Descrição = tb_descricao.Text;
            solicitado.DataAgendada = tb_data.Value;
           
            solicitado.DataSolicitacao = DateTime.Now;

            solicitado.Usercpf = Session.Cpf;
            solicitado.Postid = post.Id;

            classes.SolicitadoList.Solicitados.Add(solicitado);
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, anterior));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, anterior));
        }

        private void Bt_icone_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new PerfilEmpresa(Session.Cpf, new FormServicos()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_rua.Text != "")
            {
                Mapa.Mapa map = new Mapa.Mapa(tb_rua.Text);
                map.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa localização não preenchida");
            }
        }
    }
}
