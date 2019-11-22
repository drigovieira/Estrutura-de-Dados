using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.avalie.classes
{
    class ComentarioList
    {
        private static List<Comentario> comentarios = new List<Comentario>();
        private static string caminhao = "..\\..\\avalie\\data\\comentarios.xml";

        public static void Add(Comentario comment)
        {
            comentarios.Add(comment);
        }


        public static Comentario thisComentario(long usercpf, long postid)
        {
            foreach (var item in comentarios)
            {
                if (item.UserCpf == usercpf && item.PostId == postid && item.Status)
                {
                    return item;
                }
            }
            return null;
        }

        public static void Remove(long usercpf, long postid)
        {
            foreach (var item in comentarios)
            {
                if (item.UserCpf == usercpf && item.PostId == postid)
                {
                     item.Status = false;
                }
            }
        }


        public static void XmlSave()
        {

            XmlDrop();
            foreach (var item in comentarios)
            {
                XElement post =
                      new XElement("comentario",
                      new XElement("usercpf", item.UserCpf),
                      new XElement("postid", item.PostId),
                     //new XElement("comment", item.Comment),
                      new XElement("resposta", item.Resposta),
                      new XElement("status", item.Status));

                XDocument doc = XDocument.Load(caminhao);

                doc.Root.Add(post);

                doc.Save(caminhao);
            }
        }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminhao);

            foreach (var item in doc.Descendants("comentario"))
            {
                Comentario comment = new Comentario();

                comment.UserCpf = long.Parse(item.Element("usercpf").Value);
                comment.PostId = long.Parse(item.Element("postid").Value);
                //comment.Comment = item.Element("comment").Value;
                comment.Resposta = item.Element("resposta").Value;
                comment.Status = bool.Parse(item.Element("status").Value);


                comentarios.Add(comment);
            }
        }

        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminhao);

            XDocument xdoc = XDocument.Load(caminhao);

            foreach (var item in xdoc.Descendants("comentario"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/comentariolist/comentario");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminhao);
        }




    }
}
