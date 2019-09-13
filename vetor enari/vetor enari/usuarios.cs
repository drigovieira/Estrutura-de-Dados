using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_enari
{
    class usuarios
    {
        private string nome, email, senha;
        private long cpf;
        private bool ativo = false;

        public void setNome(string nom)
        {
            nome = nom;
        }

        public string getNome()
        {
            return nome;
        }

        public void setEmail(string emai)
        {
            email = emai;
        }

        public string getEmail()
        {
            return email;
        }

        public void setSenha(string sen)
        {
            senha = sen;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setCpf(long cp)
        {
            cpf = cp;
        }

        public long getCpf()
        {
            return cpf;
        }

        public void setAtivo(bool at)
        {
            ativo = at;
        }

        public bool getAtivo()
        {
            return ativo;
        }
    }
}
