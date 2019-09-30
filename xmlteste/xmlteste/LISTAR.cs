using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlteste
{
    class LISTAR
    {
        public void Listar()
        {

            string caminho = "..\\..\\data\\usuarios.xml";
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("usuario"))
            {
                if (item.Element("ativo").Value == "true")
                {
                    Console.WriteLine("id: "+ item.Element("id").Value);
                    Console.WriteLine("nome: " + item.Element("nome").Value);
                    Console.WriteLine("email: " + item.Element("email").Value);
                    Console.WriteLine("senha: " + item.Element("senha").Value);
                    Console.WriteLine("cpf: " + item.Element("cpf").Value);
                    Console.WriteLine("--------------");
                }
            }


            Console.ReadLine();

        }
       
    }
}
