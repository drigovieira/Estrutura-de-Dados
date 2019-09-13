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
                v.addUser(i);
               
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
