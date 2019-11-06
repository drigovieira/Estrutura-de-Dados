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
                new XElement("Endereço", endereco),
                new XElement("CepCep", cep),
                new XElement("Telefone", telefone),
                new XElement("Email", email),
                new XElement("Foto", foto),
                new XElement("Tipo",tipo),
                new XElement("estrelas", estrelas),
                new XElement("Descricao", descricao),
                new XElement("Ambiente", ambiente),
                new XElement("Ativo", ativo));


            XDocument doc = XDocument.Load(caminho);
            doc.Root.Add(empresa_host);
            doc.Save(caminho);
        }

        public void CarregarEmpresas()
        {
           
        }

    }
}
