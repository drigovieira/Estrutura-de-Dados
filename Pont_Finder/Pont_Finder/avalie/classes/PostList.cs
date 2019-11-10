using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.avalie
{

    class PostList
    {
        private static string caminhoPost = "..\\..\\avalie\\data\\postagens.xml";

        private static List<PostConstructor> poster = new List<PostConstructor>();


        public static PostConstructor PosterId(long postId)
        {
            PostConstructor pos = new PostConstructor();
            pos.Id = -1;
            foreach (var item in poster)
            {
                if (item.Id == postId)
                {               
                    pos.Id = item.Id;
                    pos.Img = item.Img;
                    pos.Cpf = item.Cpf;
                    pos.Tipoproblema = item.Tipoproblema;
                    pos.Localizacao = item.Localizacao;
                    pos.Desc = item.Desc;
                    pos.Tempohora = item.Tempohora;
                    pos.Ativo = item.Ativo;
                    return pos;
                }               
            }
            return pos;
        }
    


        public static List<PostConstructor> thisPoster
        {
            get { return poster; }
        }

        public static List<PostConstructor> Poster
        {
            get {
                List<PostConstructor> posts = new List<PostConstructor>();

                foreach (var item in poster)
                {
                    PostConstructor pos = new PostConstructor();
                    pos.Id = item.Id;
                    pos.Img = item.Img;
                    pos.Cpf = item.Cpf;
                    pos.Tipoproblema = item.Tipoproblema;
                    pos.Localizacao = item.Localizacao;
                    pos.Desc = item.Desc;
                    pos.Tempohora = item.Tempohora;
                    pos.Ativo = item.Ativo;

                    posts.Add(pos);
                }
                return posts; }
        }

        public static List<PostConstructor> PosterAtivo
        {
            get
            {
                List<PostConstructor> posts = new List<PostConstructor>();

                foreach (var item in poster)
                {
                    if (item.Ativo)
                    {
                        PostConstructor pos = new PostConstructor();
                        pos.Id = item.Id;
                        pos.Img = item.Img;
                        pos.Cpf = item.Cpf;
                        pos.Tipoproblema = item.Tipoproblema;
                        pos.Localizacao = item.Localizacao;
                        pos.Desc = item.Desc;
                        pos.Tempohora = item.Tempohora;
                        pos.Ativo = item.Ativo;
                        posts.Add(pos);
                    }                 
                }
                return posts;
            }
        }


        public static void PostAdd(PostConstructor post)
        {
            PostConstructor pos = new PostConstructor();
            pos.Id = post.Id;
            pos.Img = post.Img;
            pos.Cpf = post.Cpf;
            pos.Tipoproblema = post.Tipoproblema;
            pos.Localizacao = post.Localizacao;
            pos.Desc = post.Desc;
            pos.Tempohora = post.Tempohora;
            pos.Ativo = post.Ativo;                      
            poster.Add(pos);
        }


        public static void XmlSave()
        {

            XmlDrop();
            foreach (var item in poster)
            {
                XElement post =
                      new XElement("post",
                      new XElement("id", item.Id),
                      new XElement("img", item.Img),
                      new XElement("cpf", item.Cpf),
                      new XElement("tempohora", item.Tempohora),
                      new XElement("desc", item.Desc),
                      new XElement("tipoproblema", item.Tipoproblema),
                      new XElement("localizacao", item.Localizacao),
                      new XElement("ativo", item.Ativo));
                      
                XDocument doc = XDocument.Load(caminhoPost);

                doc.Root.Add(post);

                doc.Save(caminhoPost);
            }
        }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminhoPost);

            foreach (var item in doc.Descendants("post"))
            {
                PostConstructor postar = new PostConstructor();

                postar.Id = long.Parse(item.Element("id").Value);
                postar.Img = item.Element("img").Value;
                postar.Cpf = long.Parse(item.Element("cpf").Value);
                postar.Tempohora = item.Element("tempohora").Value;
                postar.Desc = item.Element("desc").Value;
                postar.Tipoproblema = item.Element("tipoproblema").Value;
                postar.Localizacao = item.Element("localizacao").Value;
                postar.Ativo = bool.Parse(item.Element("ativo").Value);

                poster.Add(postar);
            }
        }

        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminhoPost);

            XDocument xdoc = XDocument.Load(caminhoPost);

            foreach (var item in xdoc.Descendants("post"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/posts/post");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminhoPost);
        }

    }
}
