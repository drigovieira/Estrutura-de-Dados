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
    public partial class servicos : Form
    {
        public servicos()
        {
            InitializeComponent();
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void servicos_Load(object sender, EventArgs e)
        {
            formservicos fms = new formservicos();
            fms.Show();
        }
    }
}
