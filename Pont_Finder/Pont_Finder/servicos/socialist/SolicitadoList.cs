using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.socialist
{
    class SolicitadoList
    {
        List<Solicitado> solicitados = new List<Solicitado>();

        public List<Solicitado> Solicitados { get => solicitados; set => solicitados = value; }
    }
}
