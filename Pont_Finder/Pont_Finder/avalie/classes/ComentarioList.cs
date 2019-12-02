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
        private static List<Comentario> comentariosLista = new List<Comentario>();
        private static string caminho = "..\\..\\avalie\\data\\comentarios.xml";

        public static List<Comentario> Comentarios { get => Comentarios; set => Comentarios = value; }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminho);
            foreach (var item in doc.Descendants("comentarios"))
            {
                Comentario itens = new Comentario();

                itens.Idcoment = long.Parse(item.Element("idcoment").Value);
                itens.PostId = long.Parse(item.Element("id").Value);
                itens.UserCpf = long.Parse(item.Element("cpf").Value);
                itens.Username = item.Element("data").Value;
                itens.ImgUser = item.Element("data").Value;
                itens.Comment = (item.Element("comment").Value);
                itens.Data = item.Element("data").Value;
                itens.Ativo = bool.Parse(item.Element("ativo").Value);


                string sLikes = item.Element("like").Value;
                string[] userLike = sLikes.Split('*');

                foreach (var like in userLike)
                {
                    if (like != "")
                    {
                        string[] v = like.Split(',');
                        itens.like(short.Parse(v[0]), long.Parse(v[1]));
                    }
                }

            }
        }
        public static void XmlSave()
        {

            foreach (var item in )
            {

                string like = "";
                foreach (var item2 in item.LikesList)
                {
                    like = like + item2[0] + "," + item2[1] + "*";
                }
                if (like.Length - 1 > 0)
                {
                    like = like.Remove(like.Length - 1);
                }



                xmlDrop();
            foreach (var itens in Comentarios)
            {
                XElement mensagem =
                    new XElement("comentarios",
                    new XElement("id", itens.PostId),
                    new XElement("idcoment", itens.Idcoment),
                    new XElement("nome", itens.Username),
                    new XElement("imguser", itens.ImgUser),
                    new XElement("cpf", itens.UserCpf),
                    new XElement("comment", itens.Comment),
                    new XElement("ativo", itens.Ativo),
                    new XElement("likes", like),
                    new XElement("data", itens.Data));
                    
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
            foreach (var item in xdoc.Descendants("comentarios"))
            {
                XmlNode node = xmldoc.SelectSingleNode("comentario/comentarios");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }



    }
}
