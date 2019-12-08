using Pont_Finder.alimentos.classes;
using Pont_Finder.alimentos.controls;
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
        public Lista_Pedidos(int idEmpresa, bool exibir, int idPedido)
        {
            Empresa = idEmpresa;
            InitializeComponent();
            int local = 0;
            foreach (var item in ListPedidos.selectAll())
            {
                if (item.IdEmpresa == idEmpresa)
                {
                    Cliente_Delivery client = new Cliente_Delivery(item.IdPedido);
                    client.Location = new Point(0, local);
                    local = local + client.Height + 5;
                    ListaClientes.Controls.Add(client);
                }
            }
            if (exibir)
            {
                Pedido_Delivery dados = new Pedido_Delivery(idPedido);
                dados.Location = new Point(0, 0);
                PedidoSelect.Controls.Add(dados);
            }
        }
    }
}
