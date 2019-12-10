using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class Solicitado
    {
        private string
            imagem,
            rua,
            bairro,
            descrição,
            status;
        private int
            id,
            numero,
            cep,
            postid;
        private long
            usercpf;
        private DateTime
            dataAgendada,
            dataSolicitacao;

        public string Imagem { get => imagem; set => imagem = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        public string Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Cep { get => cep; set => cep = value; }
        public int Postid { get => postid; set => postid = value; }
        public long Usercpf { get => usercpf; set => usercpf = value; }
        public DateTime DataAgendada { get => dataAgendada; set => dataAgendada = value; }
        public DateTime DataSolicitacao { get => dataSolicitacao; set => dataSolicitacao = value; }
    }
}
