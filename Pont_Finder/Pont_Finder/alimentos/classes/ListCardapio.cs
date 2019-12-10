using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.alimentos
{
    class ListCardapio
    {
        private static List<Cardapio> cardapio = new List<Cardapio>();

        public static void CardapioAdd(Cardapio dados)
        {
            Cardapio car = new Cardapio();
            car.Nome = dados.Nome;
            car.Preco = dados.Preco;
            car.Qtd = dados.Qtd;
            car.Ingredientes = dados.Ingredientes;
            car.Image = dados.Image;
            car.Status = true;
            car.IdEmpresa = dados.IdEmpresa;
            cardapio.Add(car);
            cardapio[cardapio.IndexOf(car)].Id = cardapio.IndexOf(car);
        }
        public static Cardapio select(int index)
        {
            Cardapio lista = new Cardapio();
            foreach (var item in cardapio)
            {
                if (cardapio.IndexOf(item) == index)
                {
                    lista = item;
                }
            }
            return lista;
        }
        public static List<Cardapio> selectAll()
        {
            return cardapio;
        }
        public static List<Cardapio> searchName(string name)
        {
            List<Cardapio> lista = new List<Cardapio>();
            foreach(var item in cardapio)
            {
                if (item.Nome.ToLower().Contains(name.ToLower()))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
        public static void alter(Cardapio dados)
        {
            foreach(var items in cardapio)
            {
                
            }
        }
        public static void Delete(int index)
        {
            try
            {
                foreach (var item in cardapio)
                {
                    if (item.Id == index)
                    {
                        cardapio.Remove(item);
                    }
                }
            }
            catch { }
        }
        public static void Disable(int Id)
        {
            Cardapio car = new Cardapio();
            foreach(var item in cardapio)
            {
                if(cardapio.IndexOf(item) == Id)
                {
                    car.Status = false;
                }
            }
        }
        public static void XmlLoad()
        {
            string caminho = "..\\..\\alimentos\\data\\cardapio.xml";
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("cardapio"))
            {
                Cardapio itemCad = new Cardapio();
                itemCad.Id = int.Parse(item.Element("id").Value);
                itemCad.IdEmpresa = int.Parse(item.Element("idEmpresa").Value);
                itemCad.Quantos = int.Parse(item.Element("quantos").Value);
                itemCad.Preco = float.Parse(item.Element("preco").Value);
                itemCad.Nome = item.Element("nome").Value;
                itemCad.Image = item.Element("image").Value;
                itemCad.Qtd = float.Parse(item.Element("qtd").Value);
                List<string> ingredientes = new List<string>();
                string[] tempCat = item.Element("ingredientes").Value.Split(',');
                foreach (var i in tempCat)
                {
                    ingredientes.Add(i);
                }
                itemCad.Ingredientes = ingredientes;
                itemCad.Status = bool.Parse(item.Element("status").Value);
                cardapio.Add(itemCad);
            }
        }
        public static void XmlSave()
        {
            XmlDrop();
            string caminho = "..\\..\\alimentos\\data\\cardapio.xml";
            foreach (var item in cardapio)
            {
                XElement xcar =
                    new XElement("cardapio",
                    new XElement("id", item.Id),
                    new XElement("idEmpresa", item.IdEmpresa),
                    new XElement("quantos", '0'),
                    new XElement("preco", item.Preco),
                    new XElement("nome", item.Nome),
                    new XElement("image", item.Image),
                    new XElement("qtd", item.Qtd),
                    new XElement("ingredientes", item.Ingredientes),
                    new XElement("status", item.Status));
                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xcar);
                doc.Save(caminho);
            }

        }
        public static void XmlDrop()
        {
            string caminho = "..\\..\\alimentos\\data\\cardapio.xml";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("cardapio"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/ListCardapio/cardapio");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }
    }
}

