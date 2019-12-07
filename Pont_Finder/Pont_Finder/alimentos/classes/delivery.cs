using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos.classes
{
    class Delivery
    {
        private List<Cardapio> pedidos;
        private string rua, nome, referencia;
        private string observacoes;
        private int numero;

        public List<Cardapio> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
