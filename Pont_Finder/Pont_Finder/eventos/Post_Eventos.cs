using Pont_Finder.eventos.Classes;
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

namespace Pont_Finder.eventos
{
    public partial class Post_Eventos : Form
    {

        public bool img = false;

        public Post_Eventos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            
            
            CoEvento postar = new CoEvento();

            string link = "..//..//eventos//Data//imagens//offImage.jpg";

            if (img)
            {
                if (!Directory.Exists("..//..//eventos//Data//imagens"))
                    Directory.CreateDirectory("..//..//eventos//Data//imagens");

                pb_icone.Load();

                pb_icone.Image = Image.FromFile(openIcone.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;

                int id = Eventos_List.Poster.Count;
                link = "..//..//eventos//Data//imagens//" + id + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }






           


            
            string p_descricao = Bdescricao.Text;
            string p_data = Bdata.Text;
            string p_horario = Bhorario.Text;
            string p_local = Blocal.Text;
            string p_patrocinadores = Bpatrocionadores.Text;
            string p_faixaetaria = CBfaixaetaria.SelectedItem.ToString();
            string p_valor = Bvalor.Text;


            postar.Imagem1 = link;
            postar.Imagem2 = "null";
            postar.Imagem3 = "null";
            postar.Imagem4 = "null";
            postar.Categoria = "TesteNull";
            postar.Descricao = p_descricao;
            postar.Data = p_data;
            postar.Horario = p_horario;
            postar.Local = p_local;
            postar.Patrocinadores = p_patrocinadores;
            postar.Idade = p_faixaetaria;
            postar.Valor = p_valor;
            postar.Ativo = true;


            postar.Ativo = true;


            Eventos_List.PostAdd(postar);

            //AvaliePrincipal.Att();
            MessageBox.Show("Post realizado com sucesso!!!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_icone_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                img = true;
            }

        }
    }
}
