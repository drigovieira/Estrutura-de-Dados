using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.servicos.socialist
{
    class MensagemList
    {
        private static List<Mensagem> mensagens = new List<Mensagem>();
        private static string caminho = "..\\..\\servicos\\data\\mensagens.xml";

        public static List<Mensagem> Mensagens { get => mensagens; set => mensagens = value; }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminho);
            foreach (var item in doc.Descendants("mensagem"))
            {
                Mensagem mensagem = new Mensagem();
                mensagem.De = long.Parse(item.Element("de").Value);
                mensagem.Para = long.Parse(item.Element("para").Value);
                mensagem.PostId = int.Parse(item.Element("postid").Value);
                mensagem.Msg = item.Element("msg").Value;
               // mensagem.Data = DateTime.Parse(item.Element("data").Value);
                mensagens.Add(mensagem);
            }
        }
        public static void XmlSave()
        {
            xmlDrop();
            foreach (var item in mensagens)
            {
                XElement mensagem =
                    new XElement("mensagem",
                    new XElement("de", item.De),
                    new XElement("para", item.Para),
                    new XElement("postid", item.PostId),
                    new XElement("msg", item.Msg));
                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(mensagem);
                doc.Save(caminho);
            }
        }

        public static void xmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);
            XDocument xdoc = XDocument.Load(caminho);
            foreach (var item in xdoc.Descendants("mensagem"))
            {
                XmlNode node = xmldoc.SelectSingleNode("mensagemlist/mensagem");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }

    }
}
