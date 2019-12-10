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
            r.Status = reserva.Status;

            reservas.Add(r);
        }

        public static Reserva SelectId(int id)
        {
            foreach (var item in reservas)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
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
                r.Status = item.Status;

                lista.Add(r);
            }

            return lista;
        }

        public static List<Reserva> selectActiveReserves()
        {
            List<Reserva> lista = new List<Reserva>();

            foreach (var item in reservas)
            {
                if (item.Status == true)
                {
                    Reserva r = new Reserva();

                    r.Id = item.Id;
                    r.IdQuarto = item.IdQuarto;
                    r.Usuario = item.Usuario;
                    r.Data_inicial = item.Data_inicial;
                    r.Data_final = item.Data_final;
                    r.MetodoPagamento = item.MetodoPagamento;
                    r.Valor = item.Valor;
                    r.Status = item.Status;

                    lista.Add(r);
                }
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
                    r.Status = item.Status;

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
                r.Valor = double.Parse(item.Element("valor").Value);
                r.Status = bool.Parse(item.Element("status").Value);

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
                    new XElement("valor", item.Valor),
                    new XElement("status", item.Status));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xemp);
                doc.Save(caminho);
            }

        }

        public static List<Quarto> Tops()
        {
            
            List <int[]> lista = new List<int[]>();

            foreach (var item in reservas)
            {
                bool achou = false;

                foreach (var item2 in lista)
                {
                    if (item.IdQuarto == item2[0])
                    {
                        item2[1]++;
                        achou = true;
                        break;
                    }
                }

                if (!achou)
                {
                    int[] vetor = { item.IdQuarto, 1 };
                    lista.Add(vetor);
                }


            }

            int[] ids = new int[lista.Count];
            int[] quant = new int[lista.Count];

            int cont = 0;
            foreach (var item in lista)
            {
                ids[cont] = item[0];
                quant[cont] = item[1];
                cont++;
            }

            for (int i = 0; i < quant.Length; i++)
            {
                for (int j = 0; j < quant.Length; j++)
                {
                    if (quant[i] < quant[j])
                    {
                        int tmp = quant[i];
                        quant[i] = quant[j];
                        quant[j] = tmp;

                        int id = ids[i];
                        ids[i] = ids[j];
                        ids[j] = id;
                    }
                }
            }

            List<Quarto> top = new List<Quarto>();

            foreach (var item in ids)
            {
                top.Add(roomList.SelectId(item));
            }
            top.Reverse();

            return top;
        }

    }
}
