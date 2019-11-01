using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace xmlteste
{
    class EDIT
    {
        public void Editar()
        {
            string caminho = "..\\..\\data\\usuarios.xml";
            var doc = XDocument.Load(caminho);

            var node = doc.Descendants("usuario").FirstOrDefault(usuario => usuario.Element("nome").Value == "Leo");

            node.SetElementValue("email", "leozera@");

            doc.Save(caminho);

        }
    }
}
