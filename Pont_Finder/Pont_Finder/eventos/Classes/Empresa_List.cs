using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.eventos.classes
{
    class Empresa_List
    {

        private static string caminhoPost = "..\\..\\eventos\\Data\\Empresa_Eventos.xml";

        private static List<CaEmpresa> poster = new List<CaEmpresa>();


        public static CaEmpresa PosterId(long postCnpj)
        {
            CaEmpresa pos = new CaEmpresa();
            
            foreach (var item in poster)
            {
                if (item.Cnpj == postCnpj)
                {

                    pos.Nome = item.Nome;
                    pos.Nome_Fantasia = item.Nome;
                    pos.Email = item.Email;
                    pos.Senha = item.Senha;
                    pos.Cnpj = item.Cnpj;
                    pos.Telefone = item.Telefone;
                    pos.Endereco = item.Endereco;
                    pos.Ativo = item.Ativo;
                    return pos;
                }
            }
            return pos;
        }

        public static List<CaEmpresa> thisPoster
        {
            get { return poster; }
        }

        public static List<CaEmpresa> Poster
        {
            get
            {
                List<CaEmpresa> posts = new List<CaEmpresa>();

                foreach (var item in poster)
                {
                    CaEmpresa pos = new CaEmpresa();
                    pos.Nome = item.Nome;
                    pos.Nome_Fantasia = item.Nome_Fantasia;
                    pos.Email = item.Email;
                    pos.Senha = item.Senha;
                    pos.Cnpj = item.Cnpj;
                    pos.Telefone = item.Telefone;
                    pos.Endereco = item.Endereco;
                    pos.Ativo = item.Ativo;

                    posts.Add(pos);
                }
                return posts;
            }
        }

        public static List<CaEmpresa> PosterAtivo
        {
            get
            {
                List<CaEmpresa> posts = new List<CaEmpresa>();

                foreach (var item in poster)
                {
                    if (item.Ativo)
                    {
                        CaEmpresa pos = new CaEmpresa();
                        pos.Nome = item.Nome;
                        pos.Nome_Fantasia = item.Nome_Fantasia;
                        pos.Email = item.Email;
                        pos.Senha = item.Senha;
                        pos.Cnpj = item.Cnpj;
                        pos.Telefone = item.Telefone;
                        pos.Endereco = item.Endereco;
                        pos.Ativo = item.Ativo;
                        posts.Add(pos);
                    }
                }
                return posts;
            }
        }


        public static void PostAdd(CaEmpresa post)
        {
            CaEmpresa pos = new CaEmpresa();
            pos.Nome = post.Nome;
            pos.Nome_Fantasia = post.Nome_Fantasia;
            pos.Email = post.Email;
            pos.Senha = post.Senha;
            pos.Cnpj = post.Cnpj;
            pos.Telefone = post.Telefone;
            pos.Endereco = post.Endereco;
            pos.Ativo = post.Ativo;
            poster.Add(pos);
        }


        public static void XmlSave()
        {

            XmlDrop();

            foreach (var item in poster)
            {
                XElement post =
                      new XElement("EMPRESA",
                      new XElement("nome", item.Nome),
                      new XElement("nome_fantasia", item.Nome_Fantasia),
                      new XElement("email", item.Email),
                      new XElement("senha", item.Senha),
                      new XElement("cnpj", item.Cnpj),
                      new XElement("telefone", item.Telefone),
                      new XElement("endereco", item.Endereco),
                      new XElement("ativo", item.Ativo));

                XDocument doc = XDocument.Load(caminhoPost);

                doc.Root.Add(post);

                doc.Save(caminhoPost);
            }
        }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminhoPost);

            foreach (var item in doc.Descendants("EMPRESA"))
            {
                CaEmpresa postar = new CaEmpresa();

                postar.Nome = (item.Element("nome").Value);
                postar.Nome_Fantasia = item.Element("nome_fantasia").Value;
                postar.Email = item.Element("email").Value;
                postar.Senha = (item.Element("senha").Value);
                postar.Cnpj = long.Parse(item.Element("cnpj").Value);
                postar.Telefone = item.Element("telefone").Value;
                postar.Endereco = item.Element("endereco").Value;
                postar.Ativo = bool.Parse(item.Element("ativo").Value);

                poster.Add(postar);
            }
        }

        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminhoPost);

            XDocument xdoc = XDocument.Load(caminhoPost);

            foreach (var item in xdoc.Descendants("EMPRESA"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/CADEMPRESA/EMPRESA");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminhoPost);
        }

    }
}
