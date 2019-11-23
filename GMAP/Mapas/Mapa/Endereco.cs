using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa
{
    class Endereco
    {
        private string rua, cidade, estado, pais;
      
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
    }
}
