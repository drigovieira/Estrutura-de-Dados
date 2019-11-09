using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.hospedagem
{
    class hostList
    {
        private static List<Empresa> empresas = new List<Empresa>();

        private static string caminho = "..\\..\\data\\empresas.xml";

        public static void addEmpresa(Empresa empresa) //Adiciona uma empresa a lista
        {
            Empresa e = new Empresa();

            e.CPFADMIN = empresa.CPFADMIN;
            e.Nomeempresa = empresa.Nomeempresa;
            e.Nomefantasia = empresa.Nomefantasia;
            e.CNPJ = empresa.CNPJ;
            e.Endereco = empresa.Endereco;
            e.Cep = empresa.Cep;
            e.Telefone = empresa.Telefone;
            e.Email = empresa.Email;
            e.Foto = empresa.Foto;
            e.Tipo = empresa.Tipo;
            e.Estrelas = empresa.Estrelas;
            e.Descricao = empresa.Descricao;
            e.Ambiente = empresa.Ambiente;
            e.Ativo = empresa.Ativo;

            empresas.Add(e);
        }

        /*public static object[] select(int index) //Busca usuario pelo index
        {

            string nomeempresa = empresas[index].Nomeempresa;
            string nomefantasia = empresas[index].Nomefantasia;
            long cnpj = empresas[index].CNPJ;
            string endereco = empresas[index].Endereco;
            int cep = empresas[index].Cep;
            int telefone = empresas[index].Telefone;
            string email = empresas[index].Email;
            string foto = empresas[index].Foto;
            string tipo = empresas[index].Tipo;
            int estrelas = empresas[index].Estrelas;
            string descricao = empresas[index].Descricao;
            string ambiente = empresas[index].Ambiente;
            bool ativo = empresas[index].Ativo;

            object[] vetor = { nomeempresa, nomefantasia, cnpj, cep, telefone, email, foto, tipo, estrelas, descricao, ambiente, ativo };
            return vetor;

        }*/

        public static List<Empresa> selectAll()
        {
            List<Empresa> lista = new List<Empresa>();
            foreach (var item in empresas)
            {
                Empresa e = new Empresa();

                e.CPFADMIN = item.CPFADMIN;
                e.Nomeempresa = item.Nomeempresa;
                e.Nomefantasia = item.Nomefantasia;
                e.CNPJ = item.CNPJ;
                e.Endereco = item.Endereco;
                e.Cep = item.Cep;
                e.Telefone = item.Telefone;
                e.Email = item.Email;
                e.Foto = item.Foto;
                e.Tipo = item.Tipo;
                e.Estrelas = item.Estrelas;
                e.Descricao = item.Descricao;
                e.Ambiente = item.Ambiente;
                e.Ativo = item.Ativo;

                lista.Add(e);
            }
            return lista;
        }

        public static void CarregarXML()
        {
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("hospedagem"))
            {
                Empresa emp = new Empresa();
                emp.CPFADMIN = long.Parse(item.Element("admin").Value);
                emp.Nomeempresa = item.Element("nomeempresa").Value;
                emp.Nomefantasia = item.Element("nomefantasia").Value;
                emp.CNPJ = long.Parse(item.Element("cnpj").Value);
                emp.Endereco = item.Element("endereco").Value;
                emp.Cep = int.Parse(item.Element("cep").Value);
                emp.Telefone = int.Parse(item.Element("telefone").Value);
                emp.Email = item.Element("email").Value;
                emp.Foto = item.Element("foto").Value;
                emp.Tipo = item.Element("tipo").Value;
                emp.Estrelas = int.Parse(item.Element("estrelas").Value);
                emp.Descricao = item.Element("descricao").Value;
                emp.Ambiente = item.Element("ambiente").Value;
                emp.Ativo = bool.Parse(item.Element("status").Value);

                empresas.Add(emp);
            }
        }

        public static void XmlSave()
        {
            XmlDrop();
            foreach (var item in empresas)
            {
                XElement xemp =
                      new XElement("hospedagem",
                      new XElement("admin", item.CPFADMIN),
                      new XElement("nomeempresa", item.Nomeempresa),
                      new XElement("nomefantasia", item.Nomefantasia),
                      new XElement("cnpj", item.CNPJ),
                      new XElement("endereco", item.Endereco),
                      new XElement("cep", item.Cep),
                      new XElement("telefone", item.Telefone),
                      new XElement("email", item.Email),
                      new XElement("foto", item.Foto),
                      new XElement("tipo", item.Tipo),
                      new XElement("estrelas", item.Estrelas),
                      new XElement("descricao", item.Descricao),
                      new XElement("ambiente", item.Ambiente),
                      new XElement("status", item.Ativo));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xemp);
                doc.Save(caminho);
            }
        }

        
        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("hospedagem"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/modulos/hospedagem");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }
    }
}
