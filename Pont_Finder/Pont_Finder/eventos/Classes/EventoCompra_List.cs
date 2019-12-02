using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.eventos.Classes
{
    class EventoCompra_List
    {
        private static string caminhoPost = "..\\..\\eventos\\Data\\compras_eventos.xml";

        private static List<ComprEvento> poster = new List<ComprEvento>();


        public static ComprEvento PosterId(int postId)
        {
            ComprEvento pos = new ComprEvento();

            foreach (var item in poster)
            {
                if (item.Id == postId)
                {
                    pos.Id = item.Id;
                    pos.Qnt = item.Qnt;
                    pos.Comprador = item.Comprador;
                    pos.Data = item.Data;
                    pos.Datavenc = item.Datavenc;
                    pos.Valortotal = item.Valortotal;
                    pos.Metodopagamento = item.Metodopagamento;
                    pos.Cpf = item.Cpf;
                    
                    return pos;
                }
            }
            return pos;
        }

        public static List<ComprEvento> thisPoster
        {
            get { return poster; }
        }



        public static List<ComprEvento> Poster
        {
            get
            {
                List<ComprEvento> posts = new List<ComprEvento>();

                foreach (var item in poster)
                {

                    ComprEvento pos = new ComprEvento();
                    pos.Id = item.Id;
                    pos.Qnt = item.Qnt;
                    pos.Comprador = item.Comprador;
                    pos.Data = item.Data;
                    pos.Datavenc = item.Datavenc;
                    pos.Valortotal = item.Valortotal;
                    pos.Metodopagamento = item.Metodopagamento;
                    pos.Cpf = item.Cpf;

                    posts.Add(pos);
                }
                return posts;
            }
        }

       
      


        public static void PostAdd(ComprEvento post)
        {
            ComprEvento pos = new ComprEvento();
            pos.Id = post.Id;
            pos.Id = post.Id;
            pos.Qnt = post.Qnt;
            pos.Comprador = post.Comprador;
            pos.Data = post.Data;
            pos.Datavenc = post.Datavenc;
            pos.Valortotal = post.Valortotal;
            pos.Metodopagamento = post.Metodopagamento;
            pos.Cpf = post.Cpf;
            poster.Add(pos);
        }

        public static ComprEvento thisPostId(int postId)
        {
            foreach (var item in poster)
            {
                if (postId == item.Id)
                    return item;
            }
            return null;
        }


        public static void XmlSave()
        {

            XmlDrop();

            foreach (var item in poster)
            {
                XElement post =
                      new XElement("compras",
                      new XElement("id", item.Id),
                      new XElement("cpf", item.Cpf),
                      new XElement("Metodopagamento", item.Metodopagamento),
                      new XElement("QuantidadedeIngresso", item.Qnt),
                      new XElement("ValorCompra", item.Valortotal),
                      new XElement("DataCompra", item.Data));

                XDocument doc = XDocument.Load(caminhoPost);

                doc.Root.Add(post);

                doc.Save(caminhoPost);
            }
        }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminhoPost);

            foreach (var item in doc.Descendants("compras"))
            {
                ComprEvento postar = new ComprEvento();

                postar.Id = int.Parse(item.Element("id").Value);
                postar.Cpf = long.Parse(item.Element("cpf").Value);
                postar.Metodopagamento = (item.Element("Metodopagamento").Value);
                postar.Valortotal = Double.Parse(item.Element("ValorCompra").Value);
                postar.Qnt = int.Parse(item.Element("QuantidadedeIngresso").Value);
                postar.Data = (item.Element("DataCompra").Value);





            }
        }

        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminhoPost);

            XDocument xdoc = XDocument.Load(caminhoPost);

            foreach (var item in xdoc.Descendants("compras"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/compra/compras");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminhoPost);
        }
    }
}
