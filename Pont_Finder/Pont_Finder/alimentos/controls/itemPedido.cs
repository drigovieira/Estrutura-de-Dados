using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos.controls
{
    public partial class itemPedido : UserControl
    {
        private float preco;
        private string nome, image;
        private float qtd;
        private List<string> ingredientes;
        private int id;
        public itemPedido(float precoItem, string nomeItem, string imageItem, float QtdItem, List<string> Ingredientes, int ID)
        {
            preco = precoItem;
            nome = nomeItem;
            image = imageItem;
            qtd = QtdItem;
            ingredientes = Ingredientes;
            id = ID;
            InitializeComponent();
        }
    }
}
