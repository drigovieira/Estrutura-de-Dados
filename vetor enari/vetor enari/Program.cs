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
