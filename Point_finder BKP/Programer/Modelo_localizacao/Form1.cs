using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_localizacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mapa.DragButton = MouseButtons.Left;
            Mapa.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txt_Lat.Text);
            double lon = Convert.ToDouble(txt_Lon.Text);
            Mapa.Position = new GMap.NET.PointLatLng(lat, lon);
            Mapa.MinZoom = 5; //Zoom minimo
            Mapa.MaxZoom = 100; //Zoom maximo
            Mapa.Zoom = 10; //Grau atual de zoom!
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
