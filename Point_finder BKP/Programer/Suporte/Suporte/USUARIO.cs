using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suporte
{
    class USUARIO
    {
        private string nome, email, senha;
        private long cpf;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


    }
}
