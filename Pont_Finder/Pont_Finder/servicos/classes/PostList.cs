using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.servicos.classes
{
    class PostList
    {
        private static List<Post> posts = new List<Post>();
        public static void Add(Post post)
        {
            if (post.Image == null)
                post.Image = "..//..//servicos//data//images//posts//offImage.png";
           
            Post p = new Post();
            p.Id = post.Id;
            p.Titulo = post.Titulo;
            p.Valor = post.Valor;
            p.Descricao = post.Descricao;
            p.Ativo = post.Ativo;
            p.Image = post.Image;
            p.Cpf = post.Cpf;
            p.Cnpj = post.Cnpj;
            p.Data = post.Data;
            p.LikesList = post.LikesList;          
            posts.Add(p);
        }

        public static List<Post> selectAll()
        {
            List<Post> lista = new List<Post>();
            foreach (var post in posts)
            {
                Post p = new Post();
                p.Id = post.Id;
                p.Titulo = post.Titulo;
                p.Valor = post.Valor;
                p.Descricao = post.Descricao;
                p.Ativo = post.Ativo;
                p.Image = post.Image;
                p.Cpf = post.Cpf;
                p.Cnpj = post.Cnpj;
                p.Data = post.Data;
                p.LikesList = post.LikesList;
                lista.Add(p);
            }
            return lista;
        }

        public static int Tam
        {
            get { return posts.Count; }
        }

        public static Post SelectId(int id)
        {
            return posts[id];
        }

        public static Post thisSelectId(int id)
        {
            return posts[id];
        }

        public static void XmlLoad()
        {
            // XmiLi_Post xmlLi = new XmiLi_Post();
            // xmlLi.Load();

            string caminho = "..\\..\\servicos\\data\\posts.xml";

            XDocument doc = XDocument.Load(caminho);
            foreach (var item in doc.Descendants("Post"))
            {
                classes.Post post = new classes.Post();
                post.Id = int.Parse(item.Element("id").Value);
                post.Titulo = item.Element("titulo").Value;
                post.Valor = double.Parse(item.Element("valor").Value);
                post.Descricao = item.Element("descricao").Value;
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

                posts.Add(post);
            }
        }

        public static void XmlSave()
        {
            string caminho = "..\\..\\servicos\\data\\posts.xml";


            PostList.xmlDrop();

            foreach (var item in posts)
            {
                string like = "";
                foreach (var item2 in item.LikesList)
                {
                    like = like + item2[0] + "," + item2[1] + "*";
                }
                if (like.Length - 1 > 0)
                {
                    like = like.Remove(like.Length - 1);
                }


                XElement p =
                    new XElement("Post",
                    new XElement("id", item.Id),
                    new XElement("titulo", item.Titulo),
                    new XElement("valor", item.Valor),
                    new XElement("descricao", item.Descricao),
                    new XElement("ativo", item.Ativo),
                    new XElement("image", item.Image),
                    new XElement("cpf", item.Cpf),
                    new XElement("cnpj", item.Cnpj),
                    new XElement("data", item.Data),
                    new XElement("likes", like));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(p);
                doc.Save(caminho);
            }

        }


        public static void xmlDrop()
        {

            string caminho = "..\\..\\servicos\\data\\posts.xml";
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


       


        public static void DropList()
        {
            posts = null;
            posts = new List<Post>();
        }

        public static List<Post> thisPosts
        {
            get { return posts; }
        }

        public static List<Post> Posts
        {
            get {

                List<Post> lista = new List<Post>();
                foreach (var post in posts)
                {
                    Post p = new Post();
                    p.Id = post.Id;
                    p.Titulo = post.Titulo;
                    p.Valor = post.Valor;
                    p.Descricao = post.Descricao;
                    p.Ativo = post.Ativo;
                    p.Image = post.Image;
                    p.Cpf = post.Cpf;
                    p.Cnpj = post.Cnpj;
                    p.Data = post.Data;
                    p.LikesList = post.LikesList;
                    lista.Add(p);
                }
                return lista;
            }
        }

        public static List<Post> PostsAtivo
        {
            get
            {
                List<Post> lista = new List<Post>();
                foreach (var post in posts)
                {
                    if (post.Ativo)
                    {
                        Post p = new Post();
                        p.Id = post.Id;
                        p.Titulo = post.Titulo;
                        p.Valor = post.Valor;
                        p.Descricao = post.Descricao;
                        p.Ativo = post.Ativo;
                        p.Image = post.Image;
                        p.Cpf = post.Cpf;
                        p.Cnpj = post.Cnpj;
                        p.Data = post.Data;
                        p.LikesList = post.LikesList;
                        lista.Add(p);
                    }                 
                }
                return lista;
            }
        }






    }
}
