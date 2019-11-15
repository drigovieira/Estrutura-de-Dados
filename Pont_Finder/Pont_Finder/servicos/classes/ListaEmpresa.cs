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

            /*
            Empresa tmp = new Empresa();
            tmp.Nome = empresa.Nome;
            tmp.NomeFantasia = empresa.NomeFantasia;
            tmp.Email = empresa.Email;
            tmp.Cnpj = empresa.Cnpj;
            tmp.Cpf = empresa.Cpf;
            tmp.Endereco = empresa.Endereco;
            tmp.Telefone = empresa.Telefone;
            tmp.Image = empresa.Image;
            tmp.Status = true;
            listaEmpresa.Add(tmp);
            */
        }

        public static List<Empresa> selectAll()
        {
            List<Empresa> lista = new List<Empresa>();
            foreach (var item in listaEmpresa)
            {
                Empresa tmp = new Empresa();
                tmp.Nome = item.Nome;
                tmp.NomeFantasia = item.NomeFantasia;
                tmp.Email = item.Email;
                tmp.Servico = item.Servico;
                tmp.Cnpj = item.Cnpj;
                tmp.Cpf = item.Cpf;
                tmp.Endereco = item.Endereco;
                tmp.Telefone = item.Telefone;
                tmp.Image = item.Image;
                tmp.Status = item.Status;              
                lista.Add(tmp);
            }
            return lista;
        }
        public static Empresa selectCpf(long cpf)
        {
            Empresa emp = new Empresa();
            foreach (var item in listaEmpresa)
            {
                if (cpf == item.Cpf)
                {
                    emp.Nome = item.Nome;
                    emp.NomeFantasia = item.NomeFantasia;
                    emp.Email = item.Email;
                    emp.Cnpj = item.Cnpj;
                    emp.Cpf = item.Cpf;
                    emp.Endereco = item.Endereco;
                    emp.Servico = item.Servico;
                    emp.Telefone = item.Telefone;
                    emp.Status = item.Status;
                    emp.Image = item.Image;
                    return emp;
                }                
            }
            emp = null;
            return emp;
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
                    Empresa emp = new Empresa();
                    emp.Nome = item.Nome;
                    emp.NomeFantasia = item.NomeFantasia;
                    emp.Email = item.Email;
                    emp.Endereco = item.Endereco;
                    emp.Telefone = item.Telefone;
                    emp.Image = item.Image;
                    emp.Servico = item.Servico;
                    emp.Cnpj = item.Cnpj;
                    emp.Cpf = item.Cpf;
                    emp.Status = item.Status;
                    lista.Add(emp);
                }
                return lista; }
        }

        public static void XmlLoad()
        {         
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("servico"))
            {
                Empresa emp = new Empresa();
                emp.Nome = item.Element("nome").Value;
                emp.NomeFantasia = item.Element("nomeFantasia").Value;
                emp.Email = item.Element("email").Value;
                emp.Telefone = item.Element("telefone").Value;
                emp.Endereco = item.Element("endereco").Value;
                emp.Servico = item.Element("service").Value;
                emp.Cnpj = long.Parse( item.Element("cnpj").Value);
                emp.Cpf = long.Parse(item.Element("cpf").Value);
                emp.Image = item.Element("image").Value;
                emp.Status = bool.Parse( item.Element("status").Value);
                ListaEmpresa.Add(emp);               
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
                      new XElement("service", item.Servico),
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
