using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.eventos
{
    class CadEmpresa
    {
        private string nome;
        private string nome_fantasia;
        private string email;
        private string senha;
        private string cnpj;
        private string telefone;
        private string endereco;
        private string modulo;
        public string Nome
        {
            get {return nome; }
            set {nome = value;}
        }

        public string Nome_Fantasia
        {
            get { return nome_fantasia; }
            set { nome_fantasia = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }
    }
}
