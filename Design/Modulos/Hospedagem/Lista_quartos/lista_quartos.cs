using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_quartos
{
    class lista_quartos
    {
        private List<quarto> listaquartos = new List<quarto>();

        public void AdicionarQuarto(quarto quartos)
        {
            quarto q = new quarto();
            q.Id = quartos.Id;
            q.nomequarto = quartos.nomequarto;
            q.qtdpessoas = quartos.qtdpessoas;
            q.qtdquartos = quartos.qtdquartos;
            q.servicos = quartos.servicos;
            q.valordiaria = quartos.valordiaria;
            listaquartos.Add(q);
        }

    }
}
