using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class SolicitadoList
    {
        private static List<Solicitado> solicitados = new List<Solicitado>();

        public static List<Solicitado> Solicitados { get => solicitados; set => solicitados = value; }

        public static Solicitado thisForId(int id)
        {
            foreach (var item in solicitados)
            {
                if (id == item.Id)
                    return item;              
            }
            return null;
        }
    }
}
