using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.socialist
{
    class Solicitado
    {
        private int
            postId;

        private long
            cpfUser;

        private DateTime
            dataDaSolicitacao,
            dataAgendada;

        private string
            imagem,
            descricao,
            bairro,
            rua,
            numero,
            cep,
            status;

        public int PostId { get => postId; set => postId = value; }
        public long CpfUser { get => cpfUser; set => cpfUser = value; }
        public DateTime DataDaSolicitacao { get => dataDaSolicitacao; set => dataDaSolicitacao = value; }
        public DateTime DataAgendada { get => dataAgendada; set => dataAgendada = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Status { get => status; set => status = value; }
    }
}
