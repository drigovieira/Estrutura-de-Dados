using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.eventos
{
    public partial class CadEmpresa : Form
    {
        public CadEmpresa()
        {
            InitializeComponent();
        }

        private void CadEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PostEventos outroform = new PostEventos();
            outroform.ShowDialog();
        }
    }
}
