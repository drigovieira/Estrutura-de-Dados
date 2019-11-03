using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.servicos.classes
{
    class XmiLi_Post
    {
        private string caminho = "..\\..\\servicos\\data\\posts.xml";

        public XElement Full
        {
            get { return XElement.Load(caminho); }
        }


        public void Save()
        {          
            XmiLi_Post xmlLi = new XmiLi_Post();
            xmlLi.Drop();
            foreach (var item in PostList.selectAll())
            {
                xmlLi.Add(item);
            }
        }



        //private List<long[]> likes = new List<long[]>();

        public void Load()
        {
            XDocument doc = XDocument.Load(caminho);
            foreach (var item in doc.Descendants("Post"))
            {
                classes.Post post = new classes.Post();

                post.Id = int.Parse(item.Element("id").Value);
                post.Titulo = item.Element("titulo").Value;
                post.Valor = double.Parse(item.Element("valor").Value);
                post.Detalhes = item.Element("detalhes").Value;
                //post.Descricao = item.Element("descricao").Value;
                post.Ativo = bool.Parse(item.Element("ativo").Value);
                post.Image = item.Element("image").Value;
                post.Cpf = long.Parse(item.Element("cpf").Value);
                post.Cnpj = long.Parse(item.Element("cnpj").Value);
                post.Data = DateTime.Parse(item.Element("data").Value);
             
                string sLikes = item.Element("likes").Value;              
                string[] userLike = sLikes.Split('*');
                
                foreach (var like in userLike)
                {
                    if (like != "")
                    {
                        string[] v = like.Split(',');
                        post.like(short.Parse(v[0]), long.Parse(v[1]));
                    }
                  
                }
                
                PostList.Add(post);
           }
        }

        public void Add(Post post)
        {
            string like = "";
            foreach (var item in post.LikesList)
            {
                like = like + item[0] + "," + item[1] + "*";
            }
            if (like.Length - 1 > 0)
            {
                like = like.Remove(like.Length - 1);
            }
            

            XElement p =
                new XElement("Post",
                new XElement("id", post.Id),
                new XElement("titulo", post.Titulo),
                new XElement("valor", post.Valor),
                new XElement("detalhes", post.Detalhes),
                new XElement("detalhes", post.Descricao),
                new XElement("ativo", post.Ativo),
                new XElement("image", post.Image),
                new XElement("cpf", post.Cpf),
                new XElement("cnpj", post.Cnpj),
                new XElement("data", post.Data),
                new XElement("likes", like));

            XDocument doc = XDocument.Load(caminho);
            doc.Root.Add(p);
            doc.Save(caminho);
        }


        public void Drop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("Post"))
            {
                XmlNode node = xmldoc.SelectSingleNode("PostList/Post");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);

        }

    }
}
