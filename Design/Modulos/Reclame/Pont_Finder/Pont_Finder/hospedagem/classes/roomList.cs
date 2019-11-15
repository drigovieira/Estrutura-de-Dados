using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.hospedagem
{
    class roomList
    {
        private static List<Quarto> quartos = new List<Quarto>();

        private static string caminho = "..\\..\\hospedagem\\data\\quartos.xml";

        public static void addQuarto(Quarto quarto) 
        {
            Quarto q = new Quarto();

            q.ID = quarto.ID;
            q.NomeQuarto = quarto.NomeQuarto;
            q.Qtd_Pessoas = quarto.Qtd_Pessoas;
            q.Qtd_Disponivel = quarto.Qtd_Disponivel;
            q.Servicos = quarto.Servicos;
            q.Valor_Diario = quarto.Valor_Diario;
            q.Foto = quarto.Foto;
            q.Status = quarto.Status;
            q.Cnpj_Empresa = quarto.Cnpj_Empresa;
            q.Ativo = quarto.Ativo;

            quartos.Add(q);
        }

        public static List<Quarto> selectAll()
        {
            List<Quarto> lista = new List<Quarto>();

            foreach(var item in quartos)
            {
                Quarto q = new Quarto();

                q.ID = item.ID;
                q.Cnpj_Empresa = item.Cnpj_Empresa;
                q.NomeQuarto = item.NomeQuarto;
                q.Qtd_Pessoas = item.Qtd_Pessoas;
                q.Qtd_Disponivel = item.Qtd_Disponivel;
                q.Servicos = item.Servicos;
                q.Valor_Diario = item.Valor_Diario;
                q.Foto = item.Foto;
                q.Status = item.Status;
                q.Ativo = item.Ativo;


                lista.Add(q);
            }

            return lista;
        }

        public static List<Quarto> SelectCnpj(long cnpj)
        {
            List<Quarto> lista_cnpj = new List<Quarto>();

            Quarto q = new Quarto();

            foreach (var item in quartos)
            {
                if (cnpj == item.Cnpj_Empresa)
                {
                    q.ID = item.ID;
                    q.Cnpj_Empresa = item.Cnpj_Empresa;
                    q.NomeQuarto = item.NomeQuarto;
                    q.Qtd_Pessoas = item.Qtd_Pessoas;
                    q.Qtd_Disponivel = item.Qtd_Disponivel;
                    q.Servicos = item.Servicos;
                    q.Valor_Diario = item.Valor_Diario;
                    q.Foto = item.Foto;
                    q.Status = item.Status;
                    q.Ativo = item.Ativo;

                    lista_cnpj.Add(q);
                }
            }

            return lista_cnpj;
        }

        public static List<Quarto> quartosAtivos()
        {
            List<Quarto> lista_ativos = new List<Quarto>();

            foreach (var item in quartos)
            {
                if (item.Ativo)
                {
                    Quarto q = new Quarto();
                    q.ID = item.ID;
                    q.Cnpj_Empresa = item.Cnpj_Empresa;
                    q.NomeQuarto = item.NomeQuarto;
                    q.Qtd_Pessoas = item.Qtd_Pessoas;
                    q.Qtd_Disponivel = item.Qtd_Disponivel;
                    q.Servicos = item.Servicos;
                    q.Valor_Diario = item.Valor_Diario;
                    q.Foto = item.Foto;
                    q.Status = item.Status;
                    q.Ativo = item.Ativo;

                    lista_ativos.Add(q);
                }
            }

            return lista_ativos;
        }

        public static void CarregarXML()
        {
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("quarto"))
            {
                Quarto q = new Quarto();

                q.ID = int.Parse(item.Element("id").Value);
                q.Ativo = bool.Parse(item.Element("status").Value);
                q.NomeQuarto = (item.Element("nome").Value);
                q.Qtd_Disponivel =int.Parse(item.Element("qtd_quartos").Value);
                q.Qtd_Pessoas = int.Parse(item.Element("qtd_pessoas").Value);
                q.Servicos = (item.Element("servicos").Value);
                q.Foto = (item.Element("foto").Value);
                q.Status = (item.Element("estado").Value);
                q.Valor_Diario = double.Parse(item.Element("valor").Value);
                q.Cnpj_Empresa= long.Parse(item.Element("empresa").Value);


                quartos.Add(q);

            }
        }

        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("quarto"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/roomlist/quarto");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }

        public static void XmlSave()
        {
            XmlDrop();

            foreach(var item in quartos)
            {
                XElement xemp =
                    new XElement("quarto",
                    new XElement("id", item.ID),
                    new XElement("empresa", item.Cnpj_Empresa),
                    new XElement("nome", item.NomeQuarto),
                    new XElement("qtd_pessoas", item.Qtd_Pessoas),
                    new XElement("qtd_quartos", item.Qtd_Disponivel),
                    new XElement("servicos", item.Servicos),
                    new XElement("valor", item.Valor_Diario),
                    new XElement("foto", item.Foto),
                    new XElement("estado", item.Status),
                    new XElement("status", item.Ativo));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xemp);
                doc.Save(caminho);
            }

        }

        public static int Tam
        {
            get { return quartos.Count; }
        }

        public static List<Quarto> Quartos
        {
            get
            {

                List<Quarto> lista = new List<Quarto>();

                foreach (var item in quartos)
                {
                    Quarto q = new Quarto();

                    q.ID = item.ID;
                    q.Cnpj_Empresa = item.Cnpj_Empresa;
                    q.NomeQuarto = item.NomeQuarto;
                    q.Qtd_Pessoas = item.Qtd_Pessoas;
                    q.Qtd_Disponivel = item.Qtd_Disponivel;
                    q.Servicos = item.Servicos;
                    q.Valor_Diario = item.Valor_Diario;
                    q.Foto = item.Foto;
                    q.Status = item.Status;
                    q.Ativo = item.Ativo;

                    lista.Add(q);
                }
                return lista;
            }
        }

        public static Quarto SelectId(int id)
        {
            return quartos[id];
        }

    }
}
