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

namespace Pont_Finder.alimentos.controls
{
    public partial class Cliente_Delivery : UserControl
    {
        private int IndexPedido;
        public Cliente_Delivery(int idPedido)
        {
            IndexPedido = idPedido;
            InitializeComponent();
        }

        private void Cliente_Delivery_Paint(object sender, PaintEventArgs e)
        {
            lb_nome_delivery.Text = ListPedidos.selectAll()[IndexPedido].Nome;
        }
    }
}
