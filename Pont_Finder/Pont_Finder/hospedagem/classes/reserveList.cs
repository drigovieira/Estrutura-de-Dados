using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.hospedagem.classes
{
    class reserveList
    {
        private static List<Reserva> reservas = new List<Reserva>();

        private static string caminho = "..\\..\\hospedagem\\data\\reservas.xml";

        public static void addReserva(Reserva reserva)
        {
            Reserva r = new Reserva();

            r.Id = reserva.Id;
            r.IdQuarto = reserva.IdQuarto;
            r.Usuario = reserva.Usuario;
            r.Data_inicial = reserva.Data_inicial;
            r.Data_final = reserva.Data_final;
            r.MetodoPagamento = reserva.MetodoPagamento;
            r.Valor = reserva.Valor;

            reservas.Add(r);
        }

        public static List<Reserva> selectAll()
        {
            List<Reserva> lista = new List<Reserva>();

            foreach (var item in reservas)
            {
                Reserva r = new Reserva();

                r.Id = item.Id;
                r.IdQuarto = item.IdQuarto;
                r.Usuario = item.Usuario;
                r.Data_inicial = item.Data_inicial;
                r.Data_final = item.Data_final;
                r.MetodoPagamento = item.MetodoPagamento;
                r.Valor = item.Valor;


                lista.Add(r);
            }

            return lista;
        }

        public static List<Reserva> SelectCpf(long cpf_user)
        {
            List<Reserva> lista_cpf = new List<Reserva>();

            Reserva r = new Reserva();

            foreach (var item in reservas)
            {
                if (cpf_user == item.Usuario)
                {
                    r.Id = item.Id;
                    r.IdQuarto = item.IdQuarto;
                    r.Usuario = item.Usuario;
                    r.Data_inicial = item.Data_inicial;
                    r.Data_final = item.Data_final;
                    r.MetodoPagamento = item.MetodoPagamento;
                    r.Valor = item.Valor;

                    lista_cpf.Add(r);
                }
            }

            return lista_cpf;
        }

        public static int Tam
        {
            get { return reservas.Count; }
        }

        public static void CarregarXML()
        {
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("reserva"))
            {
                Reserva r = new Reserva();

                r.Id = int.Parse(item.Element("id").Value);
                r.IdQuarto = int.Parse(item.Element("idquarto").Value);
                r.Usuario = long.Parse(item.Element("usuario").Value);
                r.Data_inicial = DateTime.Parse(item.Element("dataentrada").Value);
                r.Data_final = DateTime.Parse(item.Element("datasaida").Value);
                r.MetodoPagamento = item.Element("pagamento").Value;
                r.Valor = long.Parse(item.Element("valor").Value);

                reservas.Add(r);

            }
        }

        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("reserva"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/reservelist/reserva");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }

        public static void XmlSave()
        {
            XmlDrop();

            foreach (var item in reservas)
            {
                XElement xemp =
                    new XElement("reserva",
                    new XElement("id", item.Id),
                    new XElement("idquarto", item.IdQuarto),
                    new XElement("usuario", item.Usuario),
                    new XElement("dataentrada", item.Data_inicial),
                    new XElement("datasaida", item.Data_final),
                    new XElement("pagamento", item.MetodoPagamento),
                    new XElement("valor", item.Valor));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xemp);
                doc.Save(caminho);
            }

        }

    }
}
