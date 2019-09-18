using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList userList = new UserList();
            

            if (true)
            {
                User user = new User();
                user.Nome = "guilherme";
                user.Email = "jho@gmail.com";
                user.Senha = "123";
                user.Cpf = 458;
                user.Ativo = true;
               
                userList.userAdd(user);
                
                
            }
            if (true)
            {
                User user = new User();
                user.Nome = "luiz";
                user.Email = "luiz@gmail.com";
                user.Senha = "321";
                user.Cpf = 854;
                user.Ativo = true;
           
                userList.userAdd(user);

                

            }



            for (int i = 0; i < userList.Tam ; i++)
            {
                Console.WriteLine(String.Format("Nome: {0} \nEmail: {1} \nTelefone: {2} \nCPF: {3} \nStatus: {4} \n", userList.select(i)));
            }

            userList.userDel(1);

            for (int i = 0; i < userList.Tam; i++)
            {
                Console.WriteLine(String.Format("Nome: {0} \nEmail: {1} \nTelefone: {2} \nCPF: {3} \nStatus: {4} \n", userList.select(i)));
            }

            if (true)
            {
                User user = new User();
                user.Nome = "chagas";
                user.Email = "chagas@gmail.com";
                user.Senha = "321";
                user.Cpf = 854;
                user.Ativo = true;
                userList.alter(0, user);
            }

            for (int i = 0; i < userList.Tam; i++)
            {
                Console.WriteLine(String.Format("Nome: {0} \nEmail: {1} \nTelefone: {2} \nCPF: {3} \nStatus: {4} \n", userList.select(i)));
            }



            //Console.WriteLine(String.Format("Nome: {0} \nEmail: {1} \nTelefone: {2} \nCPF: {3} \nStatus: {4} ", userList.select(0)));
            // Console.WriteLine(String.Format("Nome: {0} \nEmail: {1} \nTelefone: {2} \nCPF: {3} \nStatus: {4} ", userList.select(1)));

            Console.ReadKey();
            Console.WriteLine("-------------");

        }


        
    }
}
