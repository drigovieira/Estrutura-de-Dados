using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder
{
    class UserList
    {
        //instanciando
        /*
           UserList userList = new UserList();
        */

        
        private static List<User> users = new List<User>();

        public static void userAdd(User user)
        {
            User u = new User();
            u.Nome = user.Nome;
            u.Email = user.Email;
            u.Senha = user.Senha;
            u.Cpf = user.Cpf;
            u.Ativo = user.Ativo;
            users.Add(u);

            //adicionar um usuario
            /*
                User user = new User();
                user.Nome = "guilherme";
                user.Email = "jho@gmail.com";
                user.Senha = "123";
                user.Cpf = 458;
                user.Ativo = true;
                userList.userAdd(user);
            */
        }

        public static object[] select(int index)
        {
            string nome = users[index].Nome;
            string email = users[index].Email;
            string senha = users[index].Senha;
            long cpf = users[index].Cpf;
            bool ativo = users[index].Ativo;

            object[] vetor = { nome, email, senha, cpf, ativo };
            return vetor;

            //buscar um usuario pelo index
            //retorna um objeto vetor com as informacoes do usuario
            /*
            string str = "Nome: {0} \nEmail: {1} \nSenha: {2} \nCPF: {3} \nStatus: {4} \n";
            Console.WriteLine(String.Format(str, userList.select(i)));
            */
        }


        public static void userDel(int index)
        {
            users[index].Ativo = false;

            //tornar usuario inativo
            /*
             userList.userDel(1);
            */
        }

        public static int Tam
        {
            get { return users.Count; }

            //ver total de itens da lista
            /*
             userList.Tam
            */
        }

        public static void alter(int index, User u)
        {
            users[index].Nome = u.Nome;
            users[index].Email = u.Email;
            users[index].Senha = u.Senha;
            users[index].Cpf = u.Cpf;
            users[index].Ativo = u.Ativo;

            //altera um usuario
            /*
             user.Nome = "chagas";
             user.Email = "chagas@gmail.com";
             user.Senha = "321";
             user.Cpf = 854;
             user.Ativo = true;
             userList.alter(0, user);
            */
        }

       

        public static List<User> selectAll()
        {
            List<User> lista = new List<User>();
            foreach (var item in users)
            {
                User u = new User();
                u.Nome = item.Nome;
                u.Email = item.Email;
                u.Senha = item.Senha;
                u.Cpf = item.Cpf;
                u.Ativo = item.Ativo;
                lista.Add(u);
            }
            return lista;

            //executa uma busca completa
            //retorna uma copia da lista principal
            /*
             string str = "Nome: {0} \nEmail: {1} \nSenha: {2} \nCPF: {3} \nStatus: {4} \n";
             foreach (var item in userList.selectAll())
            {
                Console.WriteLine(String.Format(str, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo));
            }
            */
        }      

        //novos métodos
        public static User selectCpf(long cpf)
        {
            User user = new User();
            foreach (var item in users)
            {
                if (cpf == item.Cpf)
                    return item;
            }
            return user;
        }


        public static void Add(User user)
        {
            User u = new User();
            u.Nome = user.Nome;
            u.Email = user.Email;
            u.Senha = user.Senha;
            u.Cpf = user.Cpf;
            u.Image = user.Image;
            u.Ativo = user.Ativo;
            users.Add(u);
        }

        public static List<User> Users()
        {
            List<User> lista = new List<User>();
            foreach (var item in users)
            {
                User u = new User();
                u.Nome = item.Nome;
                u.Email = item.Email;
                u.Senha = item.Senha;
                u.Cpf = item.Cpf;
                u.Image = item.Image;
                u.Ativo = item.Ativo;
                lista.Add(u);
            }
            return lista;
        }
        public static List<User> thisUsers()
        {
            return users;
        }

        public static void XmlLoad()
        {
            string caminho = "..\\..\\data\\usuarios.xml";
            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("user"))
            {
                User user = new User();
                user.Nome = item.Element("nome").Value;
                user.Email = item.Element("email").Value;
                user.Senha = item.Element("senha").Value;
                user.Cpf = long.Parse(item.Element("cpf").Value);
                user.Image = item.Element("image").Value;
                user.Ativo = bool.Parse(item.Element("ativo").Value);
                UserList.Add(user);
            }
        }
        public static void XmlSave()
        {
            UserList.XmlDrop();
            string caminho = "..\\..\\data\\usuarios.xml";
            foreach (var item in users)
            {
                XElement xuser =
                      new XElement("user",
                      new XElement("nome", item.Nome),
                      new XElement("email", item.Email),
                       new XElement("senha", item.Senha),
                      new XElement("cpf", item.Cpf),
                      new XElement("image", item.Image),
                      new XElement("ativo", item.Ativo));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xuser);
                doc.Save(caminho);
            }
        }

        public static void XmlDrop()
        {
            string caminho = "..\\..\\data\\usuarios.xml";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("user"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/userList/user");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }

        



    }
}
