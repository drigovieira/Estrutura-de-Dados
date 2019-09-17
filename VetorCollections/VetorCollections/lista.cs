using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VetorCollections
{
    class lista
    {
        public void HASHTABLE()
        {
            string nome, email, senha;
            long cpf;
            Int32 i;
            Int32 nmb;
            
            Hashtable key = new Hashtable();

            /* ADICIONANDO VALORES*/
            Console.WriteLine("Quantas Pessoas Você deseja cadastrar ? ");
            nmb = int.Parse(Console.ReadLine());
            nmb = nmb + 1;

            for (i = 1; i < nmb; i++)
            {
                Console.WriteLine("----------------------");
                Console.Write(i + "º Nome: ");
                nome = Console.ReadLine();
                Console.Write(i + "º Email: ");
                email = Console.ReadLine();
                Console.Write(i + "º Senha: ");
                senha = Console.ReadLine();
                Console.Write(i + "º CPF: ");
                cpf = long.Parse(Console.ReadLine());
                string entrada = String.Format("Nome: {0}, Email: {1}, Senha: {2}, Cpf: {3}", nome, email, senha, cpf);

                key.Add(i, entrada);
                Console.WriteLine("----------------------");

            }
            foreach (var k in key.Keys)
            {
                Console.WriteLine("ID: " + k+(" ")+ key[k]);

            }
            /* EDIÇÃO */
            Console.WriteLine("----------------------");
            Console.WriteLine("Informe qual editar");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("Edição");
            Console.WriteLine("----------------------");
            Console.Write(" Nome: ");
            nome = Console.ReadLine();
            Console.Write(" Email: ");
            email = Console.ReadLine();
            Console.Write(" Senha: ");
            senha = Console.ReadLine();
            Console.Write(" CPF: ");
            cpf = long.Parse(Console.ReadLine());
            string modify = String.Format("Nome: {0}, Email: {1}, Senha: {2}, Cpf: {3}", nome, email, senha, cpf);

            key[c] = modify;
            Console.WriteLine("----------------------");
            foreach (var k in key.Keys)
            {
                Console.WriteLine("ID: " + k + (" ") + key[k]);

            }

            
            Console.ReadKey();









        }
    }
}
