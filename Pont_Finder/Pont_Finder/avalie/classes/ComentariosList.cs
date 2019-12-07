using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.avalie.classes
{
    class ComentariosList
    {
        private static string caminhoPost = "..\\..\\avalie\\data\\postagens.xml";

        private static List<Comentario> poster = new List<Comentario>();


        public static Comentario PosterId(long postId)
        {
            Comentario pos = new Comentario();
            pos.Idcoment = -1;
            foreach (var item in poster)
            {
                if (item.Idcoment == postId)
                {

                    pos.UserCpf = item.UserCpf;
                    pos.PostId = item.PostId;
                    pos.Idcoment = item.Idcoment;
                    pos.Data = item.Data;
                    pos.Comment = item.Comment;
                    pos.ImgUser = item.ImgUser;
                    pos.Username = item.Username;
                    pos.Ativo = item.Ativo;
                    pos.LikesList = item.LikesList;
                    return pos;
                }
            }
            return pos;
        }

        public static List<Comentario> thisPoster
        {
            get { return poster; }
        }

        public static List<Comentario> Poster
        {
            get
            {
                List<Comentario> posts = new List<Comentario>();

                foreach (var item in poster)
                {
                    Comentario pos = new Comentario();
                    pos.UserCpf = item.UserCpf;
                    pos.PostId = item.PostId;
                    pos.Idcoment = item.Idcoment;
                    pos.Data = item.Data;
                    pos.Comment = item.Comment;
                    pos.ImgUser = item.ImgUser;
                    pos.Username = item.Username;
                    pos.Ativo = item.Ativo;
                    pos.LikesList = item.LikesList;
                    posts.Add(pos);
                }
                return posts;
            }
        }

        public static List<Comentario> PosterAtivo
        {
            get
            {
                List<Comentario> posts = new List<Comentario>();

                foreach (var item in poster)
                {
                    if (item.Ativo)
                    {
                        Comentario pos = new Comentario();
                        pos.UserCpf = item.UserCpf;
                        pos.PostId = item.PostId;
                        pos.Idcoment = item.Idcoment;
                        pos.Data = item.Data;
                        pos.Comment = item.Comment;
                        pos.ImgUser = item.ImgUser;
                        pos.Username = item.Username;
                        pos.Ativo = item.Ativo;
                        pos.LikesList = item.LikesList;
                        posts.Add(pos);
                    }
                }
                return posts;
            }
        }


        public static void PostAdd(Comentario post)
        {
            Comentario pos = new Comentario();
            pos.UserCpf = post.UserCpf;
            pos.PostId = post.PostId;
            pos.Idcoment = post.Idcoment;
            pos.Data = post.Data;
            pos.Comment = post.Comment;
            pos.ImgUser = post.ImgUser;
            pos.Username = post.Username;
            pos.Ativo = post.Ativo;
            pos.LikesList = post.LikesList;
            poster.Add(pos);
        }


        public static Comentario thisPostId(long postId)
        {
            foreach (var item in poster)
            {
                if (postId == item.Idcoment)
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


                XElement mensagem =
                         new XElement("comentarios",
                         new XElement("id", item.PostId),
                         new XElement("idcoment", item.Idcoment),
                         new XElement("nome", item.Username),
                         new XElement("imguser", item.ImgUser),
                         new XElement("cpf", item.UserCpf),
                         new XElement("comment", item.Comment),
                         new XElement("ativo", item.Ativo),
                         new XElement("likes", like),
                         new XElement("data", item.Data));

                XDocument doc = XDocument.Load(caminhoPost);
                doc.Root.Add(mensagem);
                doc.Save(caminhoPost);
            }
        }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminhoPost);
            foreach (var item in doc.Descendants("comentarios"))
            {
                Comentario itens = new Comentario();

                itens.Idcoment = long.Parse(item.Element("idcoment").Value);
                itens.PostId = long.Parse(item.Element("id").Value);
                itens.UserCpf = long.Parse(item.Element("cpf").Value);
                itens.Username = item.Element("nome").Value;
                itens.ImgUser = item.Element("imguser").Value;
                itens.Comment = (item.Element("comment").Value);
                itens.Data = item.Element("data").Value;
                itens.Ativo = bool.Parse(item.Element("ativo").Value);


                string sLikes = item.Element("likes").Value;
                string[] userLike = sLikes.Split('*');

                foreach (var like in userLike)
                {
                    if (like != "")
                    {
                        string[] v = like.Split(',');
                        itens.like(short.Parse(v[0]), long.Parse(v[1]));
                    }
                }

                poster.Add(itens);
            }
        }

            public static void XmlDrop()
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(caminhoPost);
                XDocument xdoc = XDocument.Load(caminhoPost);
                foreach (var item in xdoc.Descendants("comentarios"))
                {
                    XmlNode node = xmldoc.SelectSingleNode("comentario/comentarios");
                    node.ParentNode.RemoveChild(node);
                }
                xmldoc.Save(caminhoPost);
            }


        }
    }


