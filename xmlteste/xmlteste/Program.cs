using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlteste
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int action;
            ADD ad = new ADD();
            DELETE de = new DELETE();
            EDIT ed = new EDIT();
            LISTAR li = new LISTAR();

            Console.WriteLine("AÇÃO: [1] CRIAR  //  [2] DELETAR //  [3] EDITAR // [4] LISTAR ");
            action = int.Parse(Console.ReadLine());


            if (action == 1)
            {
                ad.Adicionar();
            }
            else if (action == 2)
            {
                de.Deletar();
            }
            else if (action == 3)
            {
                ed.Editar();
            }
            else if (action == 4)
            {
                li.Listar();
            }
            else
            {
                Console.WriteLine("Comando Inválido");
            }


        }
    }
}
