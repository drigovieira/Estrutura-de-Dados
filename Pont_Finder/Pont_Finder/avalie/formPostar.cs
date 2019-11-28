using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Pont_Finder.servicos;
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








namespace Pont_Finder.avalie
{
    public partial class FormPostar : Form
    {

        FormAvalie AvaliePrincipal = new FormAvalie();

        private bool img = false;

        public FormPostar()
        {
            InitializeComponent();
            

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtLocalizacao.Text == Text)
            {
                if (string.IsNullOrWhiteSpace(txtLocalizacao.Text)) ;

            }
            else
            {

                NavigateToRoute(new string[1] { txtLocalizacao.Text });
            }
        }
        /// <summary>
        /// Navega para uma rota composta por um ou mais pontos geográficos
        /// </summary>
        /// <param name="points">Um array/coleção contendo uma lista de pontos geográficos necessários para se criar a rota. Os pontos deve estar ordenados do inicial para o final!</param>
        public void NavigateToRoute(IEnumerable<string> points)
        {
            string baseAdress = "https://www.google.com.br/maps/dir/";

            StringBuilder url = new StringBuilder(baseAdress);
            foreach (string point in points)
            {
                url.Append(Uri.EscapeDataString(point));
                url.Append("/");
            }

           // webBrowser1.Navigate(new Uri(url.ToString()));
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            /*if (e.Url == webBrowser1.Url)
            {
                //progressBar1.Style = ProgressBarStyle.Blocks;
            }*/
        }

        private void WebBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            /*if (e.Url == webBrowser1.Url)
            {
                //progressBar1.Style = ProgressBarStyle.Blocks;
            }*/
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
            }
        }

        private void PictureBoxCarregarImagem_Click(object sender, EventArgs e)
        {

            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                img = true;
            }
        }
        private void BtnPostar_Click(object sender, EventArgs e)
        {




            /*PostConstructor post = new PostConstructor();
            

            string post_Tempohora = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string post_problema = comboBox1.SelectedItem.ToString();
            string post_localizao = txtLocalizacao.Text;
            string post_descricao = richTextBox1.Text;


            post.Tempohora = post_Tempohora;
            post.Tipoproblema = post_problema;
            post.Localizao = post_localizao;
            post.Desc = post_descricao;

            PostList.PostAdd(post);

            
            this.Close();*/

            string link = "..//..//avalie//data//imagens//posts//offImage.jpg";
            if (img)
            {
                if (!Directory.Exists("..//..//avalie//data//imagens//posts"))
                    Directory.CreateDirectory("..//..//avalie//data//imagens//posts");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);

                Image bmp = new Bitmap(pb_icone.Image);

                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                pb_icone.Image = bmp2;
              
                int id = PostList.Poster.Count;
                link = "..//..//avalie//data//imagens//posts//" + id + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }



            if (txtLocalizacao.Text == "   sua Localicação..." || txtLocalizacao.Text == ""
                || comboBox1.Text == "Sobre o quê você quer falar" || comboBox1.Text == "" ||
                pb_icone.ImageLocation == null || richTextBox1.Text == "")
            {
                MessageBox.Show("ATENÇÃO prencha todos os campos");
            }
            else
            {
                PostConstructor post = new PostConstructor();
                

                string post_Tempohora = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                string post_problema = comboBox1.SelectedItem.ToString();
                string post_localizao = txtLocalizacao.Text;
                string post_descricao = richTextBox1.Text;


                post.Cpf = Session.Cpf;
                post.Imgperfil = Session.Image;
                post.Id = PostList.Poster.Count();
                post.Nome = Session.Nome;
                post.Img = link;
                post.Tempohora = post_Tempohora;
                post.Tipoproblema = post_problema;
                post.Localizacao = post_localizao;
                post.Desc = post_descricao;
                post.Ativo = true;
                post.Resolved = false;

                PostList.PostAdd(post);

                //AvaliePrincipal.Att();
                MessageBox.Show("Post realizado com sucesso!!!");


                FormPrincipal.MudarForm("Avalie", new FormAvalie());






            }

            

        }

        private void FormPostar_Load(object sender, EventArgs e)
        {

            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocalizacao_TextChanged(object sender, EventArgs e)
        {
            



        }

        private void txtLocalizacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            /*
            //Inicia o mapa baseado no provedor selecionado e carrega o cache.
            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly;

            //LOCALIZAÇÃO DO CACHE
            gMapControl1.CacheLocation = @"F:\GMAP\GmapCache";

            // Inicia o mapa nas coordernadas correspondentes a cidade de cruzeiro.
            gMapControl1.Position = new GMap.NET.PointLatLng(-22.5785104945075, -44.959659576416);


            //end.Cidade = textBox2.Text;
            string endereco = txtLocalizacao.Text + ", Cruzeiro, Sâo Paulo";
            gMapControl1.SetPositionByKeywords(endereco);
            gMapControl1.Zoom = 16;
            //Cria um overlay do mapa e cria o marcador.
            GMapOverlay camada = new GMapOverlay("camada");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(), GMarkerGoogleType.red_dot);
            //Iguala o marcador com o texto digitado para trocar a posição e adiciona o marcador no overlay e no mapa.
            gMapControl1.GetPositionByKeywords(endereco, out PointLatLng x);
            gMapControl1.Overlays.Clear();
            marker.Position = x;
            gMapControl1.Overlays.Add(camada);
            camada.Markers.Add(marker);
            */

        }

      

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (txtLocalizacao.Text != "")
            {
                Mapa.Mapa map = new Mapa.Mapa(txtLocalizacao.Text);
                map.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa localização não preenchida");
            }

        }
    }
}
