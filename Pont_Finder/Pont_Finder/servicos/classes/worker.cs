using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos
{
    class Worker
    {
        private string endereco;
        private DateTime dataNascimento;
        private Service idServico;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public Service IdServico
        {
            get { return idServico; }
            set { idServico = value; }
        }
    }
}
