using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace xmlteste
{
    class DELETE
    {
        LOAD lod = new LOAD();
        UsuData UZ = new UsuData();

        public void Deletar()
        {
            lod.Listar();
            
            Console.WriteLine("nome: ");
            string nom = (Console.ReadLine());

            string caminho = "..\\..\\data\\usuarios.xml";
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("usuario"))
            {
                if (item.Element("id").Value == nom)
                {
                    ((XElement)item.Element("id")).Parent.Remove();
                    doc.Save(caminho);
                    break;
                }
            }



        }
    }
}
