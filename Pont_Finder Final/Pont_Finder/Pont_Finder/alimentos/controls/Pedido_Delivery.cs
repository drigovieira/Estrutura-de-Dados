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
using System.Globalization;

namespace Pont_Finder.alimentos.controls
{
    public partial class Pedido_Delivery : UserControl
    {
        private int IndexPedido;        
        public Pedido_Delivery(int idPedido)
        {
            IndexPedido = idPedido;            
            InitializeComponent();
            foreach (var i in ListPedidos.selectAll()[idPedido].Pedidos)
            {
                Pedidos.Items.Add(i);
            }
        }

        private void Pedido_Delivery_Paint(object sender, PaintEventArgs e)
        {
            lb_valor_delivery.Text = ListPedidos.selectAll()[IndexPedido].Valor.ToString("C", CultureInfo.CurrentCulture);
            lb_rua_delivery.Text = ListPedidos.selectAll()[IndexPedido].Rua;
            lb_numero_delivery.Text = " N°: " + ListPedidos.selectAll()[IndexPedido].Numero;
            lb_referencia.Text = ListPedidos.selectAll()[IndexPedido].Referencia;            
            textBox1.Text = ListPedidos.selectAll()[IndexPedido].Observacoes;
            PgValue.Text = ListPedidos.selectAll()[IndexPedido].Pagamento;
        }

        private void Btn_Realizado_Click(object sender, EventArgs e)
        {
            ListPedidos.Delete(IndexPedido);
            if (ListPedidos.selectAll().Count == 0)
            {
                formAlimentos form = new formAlimentos();
                FormPrincipal.MudarForm("alimentos", form);
            }
            else
            {
                Lista_Pedidos pedidos = new Lista_Pedidos(CompanyList.verifEmp(Session.Cpf), false, -1);
                FormPrincipal.MudarForm("alimentos", pedidos);
            }
            
        }
    }
}
