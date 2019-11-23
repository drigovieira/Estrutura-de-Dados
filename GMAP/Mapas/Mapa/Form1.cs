using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Mapa
{
    public partial class Form1 : Form
    {
        Endereco end = new Endereco();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicia o mapa baseado no provedor selecionado e carrega o cache.
            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly;
            gMapControl1.CacheLocation = @"F:\GMAP\GmapCache";

            // Inicia o mapa nas coordernadas correspondentes a cidade de cruzeiro.
            gMapControl1.Position = new GMap.NET.PointLatLng(-22.5785104945075, -44.959659576416);

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //end.Cidade = textBox2.Text;
            string endereco = textBox2.Text + ", Cruzeiro, Sâo Paulo";
            gMapControl1.SetPositionByKeywords(endereco);
            gMapControl1.Zoom = 16;
            //Cria um overlay do mapa e cria o marcador.
            GMapOverlay camada = new GMapOverlay("camada");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(), GMarkerGoogleType.red_dot);
            //Iguala o marcador com o texto digitado para trocar a posição e adiciona o marcador no overlay e no mapa.
            gMapControl1.GetPositionByKeywords(endereco,out PointLatLng x);
            gMapControl1.Overlays.Clear();
            marker.Position = x;
            gMapControl1.Overlays.Add(camada);
            camada.Markers.Add(marker);
            
        }
    }
}
