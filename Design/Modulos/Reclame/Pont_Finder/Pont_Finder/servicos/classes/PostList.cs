using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            XmiLi_Post xmlLi = new XmiLi_Post();
            xmlLi.Load();
        }

        public static void XmlSave()
        {
            XmiLi_Post xmlLi = new XmiLi_Post();
            xmlLi.Save();
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
