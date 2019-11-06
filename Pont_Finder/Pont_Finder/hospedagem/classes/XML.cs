using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.hospedagem
{
    class XML
    {
        private string caminho = "..\\..\\hospedagem\\data\\empresas.xml";

        public XElement Full
        {
            get { return XElement.Load(caminho); }
        }

        public void Add(int id, string nomeempresa, string nomefantasia, long cnpj, string endereco, int cep, int telefone, string email, string foto, string tipo, int estrelas, string descricao, string ambiente, bool ativo)
        {

            XElement empresa_host =
                new XElement("Empresa",
                new XElement("ID", id),
                new XElement("NomeEmpresa", nomeempresa),
                new XElement("NomeFantasia", nomefantasia),
                new XElement("CNPJ", cnpj),
                new XElement("Endereco", endereco),
                new XElement("Cep", cep),
                new XElement("Telefone", telefone),
                new XElement("Email", email),
                new XElement("Foto", foto),
                new XElement("Tipo",tipo),
                new XElement("Estrelas", estrelas),
                new XElement("Descricao", descricao),
                new XElement("Ambiente", ambiente),
                new XElement("Ativo", ativo));


            XDocument doc = XDocument.Load(caminho);
            doc.Root.Add(empresa_host);
            doc.Save(caminho);
        }

        public List<string[]> select()
        {

            List<string[]> empresas = new List<string[]>();

            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("Empresa"))
            {
                string id = item.Element("ID").Value;
                string nomeEmpresa = item.Element("NomeEmpresa").Value;
                string nomeFantasia = item.Element("NomeFantasia").Value;
                string cnpj = item.Element("CNPJ").Value;
                string endereco = item.Element("Endereco").Value;
                string cep = item.Element("Cep").Value;
                string telefone = item.Element("Telefone").Value;
                string email = item.Element("Email").Value;
                string foto = item.Element("Foto").Value;
                string tipo = item.Element("Tipo").Value;
                string estrelas = item.Element("Estrelas").Value;
                string descricao = item.Element("Descricao").Value;
                string ambiente = item.Element("Ambiente").Value;
                string ativo = item.Element("Ativo").Value;


                string[] empresa = { id, nomeEmpresa, nomeFantasia, cnpj, endereco, cep, telefone, email, foto, tipo, estrelas, descricao,ambiente, ativo };

                empresas.Add(empresa);
            }

            return empresas;
        }

        public void Drop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("Empresa"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/ListaEmpresas/Empresa");
                node.ParentNode.RemoveChild(node);
            }

            xmldoc.Save(caminho);
        }

        public void Load()
        {
            XDocument doc = XDocument.Load(caminho);
            foreach (var item in doc.Descendants("Empresa"))
            {
                Empresa empresa = new Empresa();

                empresa.ID = int.Parse(item.Element("ID").Value);
                empresa.Nomeempresa = item.Element("NomeEmpresa").Value;
                empresa.Nomefantasia = item.Element("NomeFantasia").Value;
                empresa.CNPJ = long.Parse(item.Element("CNPJ").Value);
                empresa.Endereco = item.Element("Endereco").Value;
                empresa.Cep = int.Parse(item.Element("Cep").Value);
                empresa.Telefone = int.Parse(item.Element("Telefone").Value);
                empresa.Email = item.Element("Email").Value;
                empresa.Foto = item.Element("Foto").Value;
                empresa.Tipo = item.Element("Tipo").Value;
                empresa.Estrelas = int.Parse(item.Element("Estrelas").Value);
                empresa.Descricao = item.Element("Descricao").Value;
                empresa.Ambiente = item.Element("Ambiente").Value;
                empresa.Ativo = bool.Parse(item.Element("Ativo").Value);
                hostList.addEmpresa(empresa);
            }
        }

    }
}
