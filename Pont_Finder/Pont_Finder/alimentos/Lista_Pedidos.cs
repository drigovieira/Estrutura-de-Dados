using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Lista_Pedidos : Form
    {
        private int Empresa;
        public Lista_Pedidos(int idEmpresa)
        {
            Empresa = idEmpresa;
            InitializeComponent();
        }
    }
}
