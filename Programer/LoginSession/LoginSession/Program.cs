using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSession
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlLi xmlli = new XmlLi();
            UserList userList = new UserList();
            User user = new User();

            foreach (var item in xmlli.select())
            {
                user.Nome = item[1];
                user.Email = item[2];
                user.Senha = item[3];
                user.Cpf = long.Parse(item[4]);
                user.Ativo = bool.Parse(item[5]);
                userList.userAdd(user);
            }

            

            //comeco do programa carregando string[] v = { id, nome, email, senha, cpf, ativo };

            Console.WriteLine("Logar [1]\nCadastrar [2]");
            int op = int.Parse(Console.ReadLine());

            
            string email = "";
            string senha = "";

            if (op == 1)
            {
                Console.WriteLine("Email: ");
                email = Console.ReadLine();
                Console.WriteLine("Senha: ");
                senha = Console.ReadLine();
                bool valido = false;
                foreach (var item in userList.selectAll())
                {
                    if (item.Email.Equals(email)  && item.Senha.Equals(senha))
                    {
                        valido = true;
                        break;
                    }
                }

                if (valido)
                {
                    Session.Email = email;
                    Session.Senha = senha;
                    Console.WriteLine("Usuario Logado no Sistema");
                }
                else
                {
                    Console.WriteLine("Usuario não cadastrado no Sistema");
                }

            }
            else
            {
                try
                {
                    User u = new User();

                    Console.WriteLine("Nome: ");
                    u.Nome = Console.ReadLine();

                    Console.WriteLine("Email: ");
                    u.Email = Console.ReadLine();

                    Console.WriteLine("Senha: ");
                    u.Senha = Console.ReadLine();

                    Console.WriteLine("Cpf: ");
                    u.Cpf = long.Parse(Console.ReadLine());

                    u.Ativo = true;
                    userList.userAdd(u);
                    Console.WriteLine("Usuario cadastrado no Sistema");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Não foi possivel cadastrar o usuario no Sistema");
                    Console.WriteLine(e.Message);
                    
                }
              
            }


            //final do programa salvando...
            xmlli.Drop();
            int cont = 0;
            foreach (var item in userList.selectAll())
            {
                xmlli.Add(cont, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo);
                cont++;
            }

            Console.WriteLine("Dados Salvos");

            Console.ReadKey();





        }
    }
}
