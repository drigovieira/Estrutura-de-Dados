using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.servicos.classes
{
    class ListaEmpresa
    {
       
        private static List<Empresa> listaEmpresa = new List<Empresa>();
        private static string caminho = "..\\..\\data\\empresas.xml";

        public static void Add(Empresa empresa)
        {
            listaEmpresa.Add(empresa);
        }

        public static List<Empresa> selectAll()
        {
            List<Empresa> lista = new List<Empresa>();
            foreach (var item in listaEmpresa)
            {
                Empresa empresa = new Empresa();
                empresa.Nome = item.Nome;
                empresa.NomeFantasia = item.NomeFantasia;
                empresa.Email = item.Email;
                empresa.Categoria = item.Categoria;
                empresa.Cnpj = item.Cnpj;
                empresa.Cpf = item.Cpf;
                empresa.Endereco = item.Endereco;
                empresa.Telefone = item.Telefone;
                empresa.Image = item.Image;
                empresa.Status = item.Status;              
                lista.Add(empresa);
            }
            return lista;
        }
        public static Empresa ForCpf(long cpf)
        {        
            foreach (var item in listaEmpresa)
            {
                if (cpf == item.Cpf)
                {
                    Empresa empresa = new Empresa();
                    empresa.Nome = item.Nome;
                    empresa.NomeFantasia = item.NomeFantasia;
                    empresa.Email = item.Email;
                    empresa.Cnpj = item.Cnpj;
                    empresa.Cpf = item.Cpf;
                    empresa.Endereco = item.Endereco;
                    empresa.Categoria = item.Categoria;
                    empresa.Telefone = item.Telefone;
                    empresa.Status = item.Status;
                    empresa.Image = item.Image;
                    return empresa;
                }                
            }
            return null;
        }

        public static Empresa thisForCpf(long cpf)
        {
            foreach (var item in listaEmpresa)
            {
                if (cpf == item.Cpf)
                    return item;               
            }
            return null;
        }

        public static List<Empresa> thisEmpresas
        {
            get{ return listaEmpresa; }            
        }


        public static List<Empresa> Empresas
        {
            get
            {
                List<Empresa> lista = new List<Empresa>();

                foreach (var item in listaEmpresa)
                {
                    Empresa empresa = new Empresa();
                    empresa.Nome = item.Nome;
                    empresa.NomeFantasia = item.NomeFantasia;
                    empresa.Email = item.Email;
                    empresa.Endereco = item.Endereco;
                    empresa.Telefone = item.Telefone;
                    empresa.Image = item.Image;
                    empresa.Categoria = item.Categoria;
                    empresa.Cnpj = item.Cnpj;
                    empresa.Cpf = item.Cpf;
                    empresa.Status = item.Status;
                    lista.Add(empresa);
                }
                return lista; }
        }

        public static void XmlLoad()
        {         
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("servico"))
            {
                Empresa empresa = new Empresa();
                empresa.Nome = item.Element("nome").Value;
                empresa.NomeFantasia = item.Element("nomeFantasia").Value;
                empresa.Email = item.Element("email").Value;
                empresa.Telefone = item.Element("telefone").Value;
                empresa.Endereco = item.Element("endereco").Value;
                empresa.Categoria = item.Element("service").Value;
                empresa.Cnpj = long.Parse( item.Element("cnpj").Value);
                empresa.Cpf = long.Parse(item.Element("cpf").Value);
                empresa.Image = item.Element("image").Value;
                empresa.Status = bool.Parse( item.Element("status").Value);
                ListaEmpresa.Add(empresa);               
            }
        }
        public static void XmlSave()
        {
            XmlDrop();
            foreach (var item in listaEmpresa)
            {
                XElement xemp =
                      new XElement("servico",
                      new XElement("nome", item.Nome),
                      new XElement("nomeFantasia", item.NomeFantasia),
                      new XElement("email", item.Email),
                      new XElement("telefone", item.Telefone),
                      new XElement("endereco", item.Endereco),
                      new XElement("service", item.Categoria),
                      new XElement("cnpj", item.Cnpj),
                      new XElement("cpf", item.Cpf),
                      new XElement("image", item.Image),
                      new XElement("status", item.Status));

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

            foreach (var item in xdoc.Descendants("servico"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/modulos/servico");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }

    }
}
