using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_enari
{
    class menu
    {



        public void MENU()
        {
            vetor ver = new vetor();
            string escolha;

            Console.Write("BEM VINDO");

            
            Console.WriteLine("\nCADASTRAR[1] - EDITAR[2] - DESATIVAR[3] ");
            escolha = (Console.ReadLine());

            if (escolha == "1")
            {
                 Console.WriteLine("Em Processo");

            }
            else if(escolha == "2")
            {
                Console.WriteLine("Em Processo");

            }
            else if(escolha == "3")
            {
                Console.WriteLine("Em Processo");
            }

            else
            {
                Console.WriteLine("OPÇÃO NÃO VÁLIDA");
            }
                               
             
            




        }
    }
}
