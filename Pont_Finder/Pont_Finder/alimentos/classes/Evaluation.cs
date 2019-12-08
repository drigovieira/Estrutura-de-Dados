using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class Evaluation
    {
        private int nota, indexEmp, id;
        private long cpf;
        private string tipo;

        public int Nota
        {
            set { nota = value; }
            get { return nota; }
        }
        public int IndexEmp
        {
            set { indexEmp = value; }
            get { return indexEmp; }
        }
        public long Cpf
        {
            set { cpf = value; }
            get { return cpf; }
        }
        public string Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
    }
}
