using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos.classes
{
    class Funcionamento
    {
        private string dia;
        private DateTime horaInicio, horaFim;

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }
        public DateTime HoraFim
        {
            get { return horaFim; }
            set { horaFim = value; }
        }
    }
}
