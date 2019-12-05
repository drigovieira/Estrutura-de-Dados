using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem.data.inc
{
    public partial class amb : UserControl
    {

        public amb(string ambiente)
        {

            InitializeComponent();

            pb_amb.ImageLocation = ambiente;
            pb_amb.Load();

        }

        private void pb_icon_Click(object sender, EventArgs e)
        {

        }
    }
}
