using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.eventos.Classes
{
    class Eventos_List
    {
        private static string caminhoPost = "..\\..\\eventos\\Data\\Postagem_Eventos.xml";

        private static List<CoEvento> poster = new List<CoEvento>();


        public static CoEvento PosterId(long postId)
        {
            CoEvento pos = new CoEvento();

            foreach (var item in poster)
            {
                if (item.Id == postId)
                {
                    pos.Id = item.Id;
                    pos.IdEmp = item.IdEmp;
                    pos.IngressosTotal = item.IngressosTotal;
                    pos.IngressoDispinivel = item.IngressoDispinivel;
                    pos.Nome = item.Nome;
                    pos.Imagem1 = item.Imagem1;
                    pos.Imagem2 = item.Imagem2;
                    pos.Imagem3 = item.Imagem3;
                    pos.Imagem4 = item.Imagem4;
                    pos.Categoria = item.Categoria;
                    pos.Descricao = item.Descricao;
                    pos.Data = item.Data;
                    pos.Horario = item.Horario;
                    pos.Local = item.Local;
                    pos.Idade = item.Idade;
                    pos.Valor = item.Valor;
                    pos.Patrocinadores = item.Patrocinadores;
                    pos.Ativo = item.Ativo;
                    pos.LikesList = item.LikesList;
                    return pos;
                }
            }
            return pos;
        }

        public static List<CoEvento> thisPoster
        {
            get { return poster; }
        }



        public static List<CoEvento> Poster
        {
            get
            {
                List<CoEvento> posts = new List<CoEvento>();

                foreach (var item in poster)
                {
                    CoEvento pos = new CoEvento();
                    pos.Id = item.Id;
                    pos.IdEmp = item.IdEmp;
                    pos.IngressosTotal = item.IngressosTotal;
                    pos.IngressoDispinivel = item.IngressoDispinivel;
                    pos.Nome = item.Nome;
                    pos.Imagem1 = item.Imagem1;
                    pos.Imagem2 = item.Imagem2;
                    pos.Imagem3 = item.Imagem3;
                    pos.Imagem4 = item.Imagem4;
                    pos.Categoria = item.Categoria;
                    pos.Descricao = item.Descricao;
                    pos.Data = item.Data;
                    pos.Horario = item.Horario;
                    pos.Local = item.Local;
                    pos.Idade = item.Idade;
                    pos.Valor = item.Valor;
                    pos.Patrocinadores = item.Patrocinadores;
                    pos.Ativo = item.Ativo;
                    pos.LikesList = item.LikesList;

                    posts.Add(pos);
                }
                return posts;
            }
        }

        public static List<CoEvento> thisPosterAtivo
        {
            get
            {
                List<CoEvento> posts = new List<CoEvento>();
                foreach (var item in poster)
                {
                    if (item.Ativo == true)
                        posts.Add(item);                   
                }
                return posts;
            }
        }

        public static List<CoEvento> PosterAtivo
        {
            get
            {
                List<CoEvento> posts = new List<CoEvento>();

                foreach (var item in poster)
                {
                    if (item.Ativo)
                    {
                        CoEvento pos = new CoEvento();
                        pos.Id = item.Id;
                        pos.IdEmp = item.IdEmp;
                        pos.IngressosTotal = item.IngressosTotal;
                        pos.IngressoDispinivel = item.IngressoDispinivel;
                        pos.Nome = item.Nome;
                        pos.Imagem1 = item.Imagem1;
                        pos.Imagem2 = item.Imagem2;
                        pos.Imagem3 = item.Imagem3;
                        pos.Imagem4 = item.Imagem4;
                        pos.Categoria = item.Categoria;
                        pos.Descricao = item.Descricao;
                        pos.Data = item.Data;
                        pos.Horario = item.Horario;
                        pos.Local = item.Local;
                        pos.Idade = item.Idade;
                        pos.Valor = item.Valor;
                        pos.Patrocinadores = item.Patrocinadores;
                        pos.Ativo = item.Ativo;
                        pos.LikesList = item.LikesList;
                        posts.Add(pos);
                    }
                }
                return posts;
            }
        }

        public static List<CoEvento> Posts { get => poster; set => poster = value; }
        public static void PostAdd(CoEvento post)
        {
            CoEvento pos = new CoEvento();

            pos.Id = post.Id;
            pos.IdEmp = post.IdEmp;
            pos.IngressosTotal = post.IngressosTotal;
            pos.IngressoDispinivel = post.IngressoDispinivel;
            pos.Nome = post.Nome;
            pos.Imagem1 = post.Imagem1;
            pos.Imagem2 = post.Imagem2;
            pos.Imagem3 = post.Imagem3;
            pos.Imagem4 = post.Imagem4;
            pos.Categoria = post.Categoria;
            pos.Descricao = post.Descricao;
            pos.Data = post.Data;
            pos.Horario = post.Horario;
            pos.Local = post.Local;
            pos.Idade = post.Idade;
            pos.Valor = post.Valor;
            pos.Patrocinadores = post.Patrocinadores;
            pos.Ativo = post.Ativo;

            pos.LikesList = post.LikesList;
            poster.Add(pos);
        }

        public static CoEvento thisPostId(long postId)
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
                      new XElement("postagem",
                      new XElement("id", item.Id),
                      new XElement("idEmp", item.IdEmp),
                      new XElement("ingresso_total", item.IngressosTotal),
                      new XElement("ingresso_disponivel", item.IngressoDispinivel),
                      new XElement("nome", item.Nome),
                      new XElement("imagem1", item.Imagem1),
                      new XElement("imagem2", item.Imagem2),
                      new XElement("imagem3", item.Imagem3),
                      new XElement("imagem4", item.Imagem4),
                      new XElement("descricao", item.Descricao),
                      new XElement("categoria", item.Categoria),
                      new XElement("data", item.Data),
                      new XElement("horario", item.Horario),
                      new XElement("local", item.Local),
                      new XElement("idade", item.Idade),
                      new XElement("valor", item.Valor),
                      new XElement("patrocinadores", item.Patrocinadores),
                      new XElement("ativo", item.Ativo),
                      new XElement("likes", like));

                XDocument doc = XDocument.Load(caminhoPost);

                doc.Root.Add(post);

                doc.Save(caminhoPost);
            }
        }

        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminhoPost);

            foreach (var item in doc.Descendants("postagem"))
            {
                CoEvento postar = new CoEvento();

                postar.Id = long.Parse(item.Element("id").Value);
                postar.IdEmp = long.Parse(item.Element("idEmp").Value);
                postar.IngressosTotal = int.Parse(item.Element("ingresso_total").Value);
                postar.IngressoDispinivel = int.Parse(item.Element("ingresso_disponivel").Value);
                postar.Nome = (item.Element("nome").Value);
                postar.Imagem1 = (item.Element("imagem1").Value);
                postar.Imagem2 = (item.Element("imagem2").Value);
                postar.Imagem3 = (item.Element("imagem3").Value);
                postar.Imagem4 = (item.Element("imagem4").Value);
                postar.Descricao = (item.Element("descricao").Value);
                postar.Categoria = (item.Element("categoria").Value);
                postar.Data = (item.Element("data").Value);
                postar.Horario = item.Element("horario").Value;
                postar.Local = item.Element("local").Value;
                postar.Idade = (item.Element("idade").Value);
                postar.Valor = (item.Element("valor").Value);
                postar.Patrocinadores = item.Element("patrocinadores").Value;
                postar.Ativo = bool.Parse(item.Element("ativo").Value);

                string sLikes = item.Element("likes").Value;
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

            foreach (var item in xdoc.Descendants("postagem"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/postagens/postagem");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminhoPost);
        }
    }
}
