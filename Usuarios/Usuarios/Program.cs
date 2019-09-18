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
            string str = "Nome: {0} \nEmail: {1} \nTelefone: {2} \nCPF: {3} \nStatus: {4} \n";
            UserList userList = new UserList();


            User user = new User();


            user.Nome = "guilherme";
            user.Email = "jho@gmail.com";
            user.Senha = "123";
            user.Cpf = 458;
            user.Ativo = true;
            userList.userAdd(user);

            user.Nome = "jhonatan";
            user.Email = "jhonatan@gmail.com";
            user.Senha = "458";
            user.Cpf = 458;
            user.Ativo = true;
            userList.userAdd(user);

            user.Nome = "mateus";
            user.Email = "mateus@gmail.com";
            user.Senha = "492";
            user.Cpf = 222;
            user.Ativo = true;
            userList.userAdd(user);

            Console.WriteLine("// adicionando user 1, 2 e 3");



            for (int i = 0; i < userList.Tam; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(String.Format(str, userList.select(i)));
            }

            userList.userDel(1);
            Console.WriteLine("\n// deletando user 1");

            for (int i = 0; i < userList.Tam; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(String.Format(str, userList.select(i)));
            }


            user.Nome = "chagas";
            user.Email = "chagas@gmail.com";
            user.Senha = "321";
            user.Cpf = 854;
            user.Ativo = true;
            userList.alter(0, user);

            Console.WriteLine("\n// alterado os dados do user 0");

            for (int i = 0; i < userList.Tam; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(String.Format(str, userList.select(i)));
            }



            Console.ReadKey();
            Console.WriteLine("-------------");

        }



    }
}
