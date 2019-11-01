using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace vetor_enari
{
    class Users
    {
        private List<User> users = new List<User>();
        


        public void userAdd(User u)
        {
            users.Add(u);
        }

        public object[] select(int index)
        {
            string nome = users[index].Nome;
            string email = users[index].Email;
            string senha = users[index].Senha;
            long cpf = users[index].Cpf;
            bool ativo = users[index].Ativo;

            object[] vetor = { nome, email, senha, cpf, ativo };         

            return vetor;
        }
        
    }
}
