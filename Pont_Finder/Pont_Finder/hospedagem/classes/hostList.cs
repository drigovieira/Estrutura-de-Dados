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
            e.Logo = empresa.Logo;
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

        public static List<Empresa> selectAll()
        {
            List<Empresa> lista = new List<Empresa>();
            foreach (var item in empresas)
            {
                Empresa e = new Empresa();

                e.CPFADMIN = item.CPFADMIN;
                e.Logo = item.Logo;
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

        public static Empresa selectCpf(long cpf)
        {
            Empresa e = new Empresa();
            foreach (var item in empresas)
            {
                if (cpf == item.CPFADMIN)
                {
                    e.CPFADMIN = item.CPFADMIN;
                    e.Logo = item.Logo;
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
                    return (e);
                }
            }
            e = null;
            return e;
        }

        public static Empresa selectCnpj(long cnpj)
        {
            Empresa e = new Empresa();
            foreach (var item in empresas)
            {
                if (cnpj == item.CNPJ)
                {
                    e.CPFADMIN = item.CPFADMIN;
                    e.Logo = item.Logo;
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
                    return (e);
                }
            }
            e = null;
            return e;
        }

        public static void CarregarXML()
        {
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("hospedagem"))
            {
                Empresa emp = new Empresa();
                emp.CPFADMIN = long.Parse(item.Element("admin").Value);
                emp.Logo = item.Element("logo").Value;
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
                      new XElement("logo", item.Logo),
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
