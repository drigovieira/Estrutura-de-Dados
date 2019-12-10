using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.alimentos.classes
{
    class ListPedidos
    {
        private static List<Delivery> pedidos = new List<Delivery>();

        public static void Add(Delivery pedido)
        {
            Delivery del = new Delivery();
            del.Rua = pedido.Rua;
            del.Numero = pedido.Numero;
            del.Nome = pedido.Nome;
            del.Referencia = pedido.Referencia;
            del.Pedidos = pedido.Pedidos;
            del.Observacoes = pedido.Observacoes;
            del.Cpf = pedido.Cpf;
            del.Valor = pedido.Valor;
            del.IdEmpresa = pedido.IdEmpresa;
            del.Pagamento = pedido.Pagamento;
            pedidos.Add(del);
            pedidos[pedidos.IndexOf(del)].IdPedido = pedidos.IndexOf(del);
        }
        public static List<Delivery> selectAll()
        {
            return pedidos;
        }
        public static void Delete(int ID)
        {
            try
            {
                foreach (var rem in pedidos)
                {
                    if (rem.IdPedido == ID)
                    {
                        pedidos.Remove(rem);
                    }
                }
            }
            catch
            {

            }
        }
        public static void XmlLoad()
        {
            string caminho = "..\\..\\alimentos\\data\\pedidos.xml";
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("pedido"))
            {
                Delivery lisped = new Delivery();
                lisped.IdPedido = int.Parse(item.Element("id").Value);
                lisped.IdEmpresa = int.Parse(item.Element("idEmpresa").Value);
                lisped.Numero = int.Parse(item.Element("numero").Value);
                lisped.Rua = item.Element("rua").Value;
                lisped.Nome = item.Element("nome").Value;
                lisped.Referencia = item.Element("referencia").Value;
                lisped.Observacoes = item.Element("observacoes").Value;
                List<string> pedidosList = new List<string>();
                string[] tempCat = item.Element("pedidos").Value.Split(',');
                foreach (var i in tempCat)
                {
                    pedidosList.Add(i);
                }
                lisped.Pedidos = pedidosList;
                lisped.Pagamento = item.Element("pagamento").Value;
                lisped.Cpf = long.Parse(item.Element("cpf").Value);
                lisped.Valor = float.Parse(item.Element("valor").Value);
                pedidos.Add(lisped);
            }
        }
        public static void XmlSave()
        {
            XmlDrop();
            string caminho = "..\\..\\alimentos\\data\\pedidos.xml";
            foreach (var item in pedidos)
            {
                string pedidosList = "";
                foreach (var i in item.Pedidos)
                {
                    if (pedidosList.Equals(""))
                    {
                        pedidosList = i;
                    }
                    else
                    {
                        pedidosList += "," + i;
                    }
                }
                XElement xcar =
                new XElement("pedido",
                new XElement("id", item.IdPedido),
                new XElement("idEmpresa", item.IdEmpresa),
                new XElement("numero", item.Numero),
                new XElement("rua", item.Rua),
                new XElement("nome", item.Nome),
                new XElement("referencia", item.Referencia),
                new XElement("observacoes", item.Observacoes),
                new XElement("pedidos", pedidosList),
                new XElement("cpf", item.Cpf),
                new XElement("valor", item.Valor),
                new XElement("pagamento", item.Pagamento));
                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xcar);
                doc.Save(caminho);
            }

        }
        public static void XmlDrop()
        {
            string caminho = "..\\..\\alimentos\\data\\pedidos.xml";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("pedido"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/ListCardapio/pedido");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }
    }
}
