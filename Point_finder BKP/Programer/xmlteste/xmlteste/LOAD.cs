using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace xmlteste
{
    class LOAD
    {
        public void Listar()
        {
            string caminho = "..\\..\\data\\usuarios.xml";
            XElement listar = XElement.Load(caminho);
            Console.WriteLine("---------------------");
            Console.WriteLine("USUARIOS NO SISTEMA");
            Console.WriteLine(listar);
            Console.WriteLine("---------------------");
        }
                 
}
}
