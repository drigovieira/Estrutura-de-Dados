using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class Evaluation
    {
        private int nota, indexEmp, indexClient, id;
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
        public int IndexClient
        {
            set { indexClient = value; }
            get { return indexClient; }
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
