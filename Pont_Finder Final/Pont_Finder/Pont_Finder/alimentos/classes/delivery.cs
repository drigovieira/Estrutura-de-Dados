using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos.classes
{
    class Delivery
    {
        private List<string> pedidos;
        private string rua, nome, referencia;
        private string observacoes, pagamento;
        private int numero, idEmpresa, idPedido;
        private long cpf;
        private float valor;

        public List<string> Pedidos
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
        public string Pagamento
        {
            get { return pagamento; }
            set { pagamento = value; }
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
        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }
        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }
    }
}
