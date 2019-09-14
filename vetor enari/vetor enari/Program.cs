using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_enari
{
    class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();
            User user = new User();
         

            user.Nome = "jhonatan";
            user.Email = "jho@g.com";
            user.Senha = "123";
            user.Cpf = 458;
            user.Ativo = true;


            users.userAdd(user);

            Console.WriteLine(String.Format("Nome: {0} \nEmail: {1} \nTelefone: {2} \nCPF: {3} \nStatus: {4} ", users.select(0)) );

            Console.WriteLine("-------------");
         
     
            
            vetor v = new vetor();

            for (int i = 0; i < 3; i++)
            { 
                Console.WriteLine("-----------");
                Console.WriteLine("Criando");

                usuarios us = new usuarios();

                Console.Write("\nEntre com o Nome: ");
                us.setNome(Console.ReadLine());
                Console.Write("Entre com o Email: ");
                us.setEmail(Console.ReadLine());
                Console.Write("Entre com a senha: ");
                us.setSenha(Console.ReadLine());
                Console.Write("Entre com o cpf: ");
                us.setCpf(long.Parse(Console.ReadLine()));
                us.setAtivo(true);

                v.addUser(i, us);         
            }

            v.editUser(0);

           v.delUser(2);

            
            Console.WriteLine("Deletado");
            v.listar();
            Console.WriteLine("---------------");

            Console.ReadKey();

        }
    }
}
