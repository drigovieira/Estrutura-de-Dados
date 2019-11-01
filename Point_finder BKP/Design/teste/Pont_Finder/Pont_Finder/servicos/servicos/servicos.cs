using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicos
{
    public partial class servicos : Form
    {
        public servicos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formservicos fh = new formservicos();
            fh.TopLevel = false;
            panelservicos.Controls.Add(fh);
            fh.Show();
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
