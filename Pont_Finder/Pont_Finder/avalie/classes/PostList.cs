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
                    pos.Nome = item.Nome;
                    pos.Img = item.Img;
                    pos.Cpf = item.Cpf;
                    pos.Imgperfil = item.Imgperfil;
                    pos.Tipoproblema = item.Tipoproblema;
                    pos.Localizacao = item.Localizacao;
                    pos.Desc = item.Desc;
                    pos.Tempohora = item.Tempohora;
                    pos.Ativo = item.Ativo;
                    pos.Resolved = item.Resolved;
                    pos.LikesList = item.LikesList;
                    return pos;
                }               
            }
            return pos;
        }

        public static List<PostConstructor> thisPoster
        {
            get { return poster; }
        }

        public static PostConstructor ForId(long id)
        {
            foreach (var item in poster)
            {
                if (item.Id == id)
                {
                    PostConstructor post = new PostConstructor();

                    post.Id = item.Id;
                    post.Nome = item.Nome;
                    post.Img = item.Img;
                    post.Cpf = item.Cpf;
                    post.Imgperfil = item.Imgperfil;
                    post.Tipoproblema = item.Tipoproblema;
                    post.Localizacao = item.Localizacao;
                    post.Desc = item.Desc;
                    post.Tempohora = item.Tempohora;
                    post.Ativo = item.Ativo;
                    post.Resolved = item.Resolved;
                    post.LikesList = item.LikesList;
                    return post;
                }
            }
            return null;
        }



        public static List<PostConstructor> Poster
        {
            get {
                List<PostConstructor> posts = new List<PostConstructor>();

                foreach (var item in poster)
                {
                    PostConstructor pos = new PostConstructor();
                    pos.Id = item.Id;
                    pos.Nome = item.Nome;
                    pos.Img = item.Img;
                    pos.Cpf = item.Cpf;
                    pos.Imgperfil = item.Imgperfil;
                    pos.Tipoproblema = item.Tipoproblema;
                    pos.Localizacao = item.Localizacao;
                    pos.Desc = item.Desc;
                    pos.Tempohora = item.Tempohora;
                    pos.Ativo = item.Ativo;
                    pos.Resolved = item.Resolved;
                    pos.LikesList = item.LikesList;
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
                        pos.Nome = item.Nome;
                        pos.Img = item.Img;
                        pos.Cpf = item.Cpf;
                        pos.Imgperfil = item.Imgperfil;
                        pos.Tipoproblema = item.Tipoproblema;
                        pos.Localizacao = item.Localizacao;
                        pos.Desc = item.Desc;
                        pos.Tempohora = item.Tempohora;
                        pos.Ativo = item.Ativo;
                        pos.Resolved = item.Resolved;
                        pos.LikesList = item.LikesList;
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
            pos.Nome = post.Nome;
            pos.Img = post.Img;
            pos.Cpf = post.Cpf;
            pos.Imgperfil = post.Imgperfil;
            pos.Tipoproblema = post.Tipoproblema;
            pos.Localizacao = post.Localizacao;
            pos.Desc = post.Desc;
            pos.Tempohora = post.Tempohora;
            pos.Ativo = post.Ativo;
            pos.Resolved = post.Resolved;
            pos.LikesList = post.LikesList;
            poster.Add(pos);
        }


        public static PostConstructor thisPostId(long postId)
        {
            foreach (var item in poster)
            {
                if (postId == item.Id)
                    return item;              
            }
            return null;
        }

        public static void XmlSave()
        {

            XmlDrop();



            foreach (var item in poster)
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


                XElement post =
                      new XElement("post",
                      new XElement("id", item.Id),
                      new XElement("nome", item.Nome),
                      new XElement("img", item.Img),
                      new XElement("cpf", item.Cpf),
                      new XElement("imgperfil", item.Imgperfil),
                      new XElement("tempohora", item.Tempohora),
                      new XElement("desc", item.Desc),
                      new XElement("tipoproblema", item.Tipoproblema),
                      new XElement("localizacao", item.Localizacao),
                      new XElement("ativo", item.Ativo),
                      new XElement("resolvido", item.Resolved),
                      new XElement("like", like));

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
                postar.Nome = item.Element("nome").Value;
                postar.Img = item.Element("img").Value;
                postar.Cpf = long.Parse(item.Element("cpf").Value);
                postar.Imgperfil = item.Element("imgperfil").Value;
                postar.Tempohora = item.Element("tempohora").Value;
                postar.Desc = item.Element("desc").Value;
                postar.Tipoproblema = item.Element("tipoproblema").Value;
                postar.Localizacao = item.Element("localizacao").Value;
                postar.Ativo = bool.Parse(item.Element("ativo").Value);
                postar.Resolved = bool.Parse(item.Element("resolvido").Value);

                string sLikes = item.Element("like").Value;
                string[] userLike = sLikes.Split('*');

                foreach (var like in userLike)
                {
                    if (like != "")
                    {
                        string[] v = like.Split(',');
                        postar.like(short.Parse(v[0]), long.Parse(v[1]));
                    }
                }


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





        public static List<PostConstructor> top()
        {
            long[] ids = new long[poster.Count];
            long[] likes = new long[poster.Count];

            int cont = 0;
            foreach (var item in poster)
            {
                ids[cont] = item.Id;
                likes[cont] = item.Joinha;
                cont++;
            }

            for (int i = 0; i < likes.Length; i++)
            {
                for (int j = 0; j < likes.Length; j++)
                {
                    if (likes[i] < likes[j])
                    {
                        long like = likes[i];
                        likes[i] = likes[j];
                        likes[j] = like;

                        long id = ids[i];
                        ids[i] = ids[j];
                        ids[j] = id;
                    }
                }
            }

            List<PostConstructor> top = new List<PostConstructor>();
            foreach (var item in ids)
            {
                top.Add(ForId(item));
            }
            top.Reverse();

            return top;
        }









    }
}
