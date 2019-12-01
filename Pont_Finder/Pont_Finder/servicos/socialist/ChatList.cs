using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.servicos.socialist
{
    class ChatList
    {
        private static List<Chat> chats = new List<Chat>();
        private static string caminho = "..\\..\\servicos\\data\\chats.xml";

        public static List<Chat> Chats { get => chats; set => chats = value; }



        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminho);
            foreach (var item in doc.Descendants("chat"))
            {
                Chat chat = new Chat();
                chat.PostId = int.Parse(item.Element("postid").Value);
                chat.CpfUser = long.Parse(item.Element("cpfuser").Value);
                chat.Data = DateTime.Parse(item.Element("data").Value);
                chats.Add(chat);
            }
        }

        public static void XmlSave()
        {
            xmlDrop();
            foreach (var item in chats)
            {
                XElement chat =
                    new XElement("chat",
                    new XElement("postid", item.PostId),
                    new XElement("cpfuser", item.CpfUser),
                    new XElement("data", item.Data));
                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(chat);
                doc.Save(caminho);
            }
        }

        public static void xmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);
            XDocument xdoc = XDocument.Load(caminho);
            foreach (var item in xdoc.Descendants("chat"))
            {
                XmlNode node = xmldoc.SelectSingleNode("chatlist/chat");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }


    }
}
