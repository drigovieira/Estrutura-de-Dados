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
    public partial class Pedido_Delivery : UserControl
    {
        private int IndexPedido;        
        public Pedido_Delivery(int idPedido)
        {
            IndexPedido = idPedido;            
            InitializeComponent();            
        }

        private void Pedido_Delivery_Paint(object sender, PaintEventArgs e)
        {
            lb_valor_delivery.Text = ListPedidos.selectAll()[IndexPedido].Valor.ToString();
            lb_rua_delivery.Text = ListPedidos.selectAll()[IndexPedido].Rua;
            lb_numero_delivery.Text = " N°: " + ListPedidos.selectAll()[IndexPedido].Numero;
            lb_referencia.Text = ListPedidos.selectAll()[IndexPedido].Referencia;
            lb_observacao.Text = ListPedidos.selectAll()[IndexPedido].Observacoes;
            for (int cont = 0; cont < ListPedidos.selectAll()[IndexPedido].Pedidos.Count; cont++)
            {
                Pedidos.Items.Add(ListPedidos.selectAll()[IndexPedido].Pedidos[cont].Nome + "x" + ListPedidos.selectAll()[IndexPedido].Pedidos[cont].Quantos);
            }

        }
    }
}
