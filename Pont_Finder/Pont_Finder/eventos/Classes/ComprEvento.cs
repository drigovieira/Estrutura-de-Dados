using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.eventos.Classes
{
    class ComprEvento
    {

        long cpf,
             id,
             qnt;


       string metodopagamento,
              comprador,
              data,
              datavenc;

        double valortotal;

        public long Cpf { get => cpf; set => cpf = value; }
        public long Qnt { get => qnt; set => qnt = value; }
        public string Metodopagamento { get => metodopagamento; set => metodopagamento = value; }
        public string Comprador { get => comprador; set => comprador = value; }
        public string Data { get => data; set => data = value; }
        public string Datavenc { get => datavenc; set => datavenc = value; }
        public long Id { get => id; set => id = value; }
        public double Valortotal { get => valortotal; set => valortotal = value; }
    }
}
