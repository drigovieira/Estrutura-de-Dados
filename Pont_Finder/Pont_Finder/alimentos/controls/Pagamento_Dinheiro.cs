using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pont_Finder.alimentos.classes;

namespace Pont_Finder.alimentos
{
    public partial class Pagamento_Dinheiro : UserControl
    {
        public Pagamento_Dinheiro()
        {
            InitializeComponent();
        }

        private void Solicitar_Click(object sender, EventArgs e)
        {
            Delivery pedido = new Delivery();

        }
    }
}
