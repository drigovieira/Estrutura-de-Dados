using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Hospedagem
{
    class XML
    {
        private string caminho = "..\\..\\data\\empresas_hospedagem.xml";

        public XElement Full
        {
            get { return XElement.Load(caminho); }
            //retorna o xml
            /*
             Console.WriteLine(xmlli.Full);
            */
        }

        public void Add(int id, string nomeempresa, string nomefantasia, long cnpj, string endereco, int cep, int telefone, string email, string foto)
        {

            XElement empresa_host =
                new XElement("Empresa",
                new XElement("id", id),
                new XElement("Nome Empresa", nomeempresa),
                new XElement("Nome Fantasia", nomefantasia),
                new XElement("CNPJ", cnpj),
                new XElement("Endereço", endereco),
                new XElement("CepCep", cep),
                new XElement("Telefone", telefone),
                new XElement("Email", email),
                new XElement("Foto", foto));
                
                
            XDocument doc = XDocument.Load(caminho);
            doc.Root.Add(empresa_host);
            doc.Save(caminho);

            //usado para adicionar um usuario ao xml
            /*
            xmlli.Add(11, "jhon", "jhon@gmail", "19374", 32859734);

            */

        }

    }
}
