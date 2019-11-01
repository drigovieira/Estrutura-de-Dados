using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class ExibirEmpresa : UserControl
    {
        private string nomeEmpresa;
        private int ID;
        public ExibirEmpresa(string nomeComp, int idComp)
        {
            nomeEmpresa = nomeComp;
            ID = idComp;
            InitializeComponent();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {
            NomeEmpresa.Text = nomeEmpresa;
        }
    }
}
