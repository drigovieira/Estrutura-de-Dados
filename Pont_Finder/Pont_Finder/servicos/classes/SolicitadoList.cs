using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.servicos.classes
{
    class SolicitadoList
    {
        private static List<Solicitado> solicitados = new List<Solicitado>();
        private static string caminho = "..\\..\\servicos\\data\\solicitados.xml";

        public static List<Solicitado> Solicitados { get => solicitados; set => solicitados = value; }

        public static Solicitado thisForId(int id)
        {
            foreach (var item in solicitados)
            {
                if (id == item.Id)
                    return item;
            }
            return null;
        }

        public static void XmlLoad()
        {        
            XDocument doc = XDocument.Load(caminho);
            foreach (var item in doc.Descendants("solicitado"))
            {
                Solicitado solicitado = new Solicitado();
                solicitado.Imagem = item.Element("imagem").Value;
                solicitado.Rua = item.Element("rua").Value;
                solicitado.Bairro = item.Element("bairro").Value;
                solicitado.Descricao = item.Element("descricao").Value;
                solicitado.Status = item.Element("status").Value;

                solicitado.Id = int.Parse(item.Element("id").Value);
                solicitado.Numero = int.Parse(item.Element("numero").Value);
                solicitado.Cep = int.Parse(item.Element("cep").Value);
                solicitado.Postid = int.Parse(item.Element("postid").Value);

                solicitado.Usercpf = long.Parse(item.Element("usercpf").Value);

                solicitado.DataAgendada = DateTime.Parse(item.Element("dataAgendada").Value);
                solicitado.DataSolicitacao = DateTime.Parse(item.Element("dataSolicitacao").Value);
                solicitados.Add(solicitado);
            }
        }

        public static void XmlSave()
        {
            XmlDrop();
            foreach (var item in solicitados)
            {
                XElement solicitacao =
                      new XElement("solicitado",
                      new XElement("imagem", item.Imagem),
                      new XElement("rua", item.Rua),
                      new XElement("bairro", item.Bairro),
                      new XElement("descricao", item.Descricao),
                      new XElement("status", item.Status),
                      new XElement("id", item.Id),
                      new XElement("numero", item.Numero),
                      new XElement("cep", item.Cep),
                      new XElement("postid", item.Postid),
                      new XElement("usercpf", item.Usercpf),
                      new XElement("dataAgendada", item.DataAgendada),
                      new XElement("dataSolicitacao", item.DataSolicitacao));
                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(solicitacao);
                doc.Save(caminho);
            }
        }

        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("solicitado"))
            {
                XmlNode node = xmldoc.SelectSingleNode("solicitados/solicitado");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }

    }
}
