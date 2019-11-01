using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlteste
{
    class UsuData
    {
        private string nome;
        private string email;
        private string senha;
        private long cpf;
        int id;


        public string Nome
        {
            get{ return nome; }
            set{ nome = value; }

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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
