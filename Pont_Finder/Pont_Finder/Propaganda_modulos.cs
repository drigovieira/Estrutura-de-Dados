using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class Propaganda_modulos : UserControl
    {
        public Propaganda_modulos()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                //imageList.Add(Image.FromFile("..\\..\\data\\images\\propagandas\\entre_modulos\\" + i + ".png"));
            }
        }

        private void Propaganda_modulos_Load(object sender, EventArgs e)
        {

        }
    }
}
