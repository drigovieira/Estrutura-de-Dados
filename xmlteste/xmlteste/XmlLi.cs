using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlteste
{
    class XmlLi
    {
        //instanciando
        /*
         XmlLi xmlli = new XmlLi();
        */

        private string caminho = "..\\..\\data\\usuarios.xml";


        public XElement Full
        {
            get { return XElement.Load(caminho); }
            //retorna o xml
            /*
             Console.WriteLine(xmlli.Full);
            */
        }

        public void Add(int id, string nome, string email, string senha, long cpf)
        {
            UsuData user = new UsuData();
            
            user.Id = id;
            user.Nome = nome;
            user.Email = email;
            user.Senha = senha;
            user.Cpf = cpf;
         
            XElement usu = 
                new XElement("usuario",
                new XElement("id", user.Id),
                new XElement("nome", user.Nome),
                new XElement("email", user.Email),
                new XElement("senha", user.Senha),
                new XElement("cpf", user.Cpf),
                new XElement("ativo", "true"));

            XDocument doc = XDocument.Load(caminho);
            doc.Root.Add(usu);
            doc.Save(caminho);

            //usado para adicionar um usuario ao xml
            /*
            xmlli.Add(11, "jhonn", "jhon@gmail", "19374", 32859734);
            */

        }

        public void Edit(int id, string nome, string email, string senha)
        {
            var doc = XDocument.Load(caminho);
            var node = doc.Descendants("usuario").FirstOrDefault(usuario => usuario.Element("id").Value == id+"");

            node.SetElementValue("nome", nome);
            node.SetElementValue("email", email);
            node.SetElementValue("senha", senha);

            doc.Save(caminho);

            //editar um usuario por id
            /*
             xmlli.Edit(11, "jhonn", "jho@gmail", "a17");
            */
        }

        public List<string[]> select()
        {

            List<string[]> users = new List<string[]>();

            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("usuario"))
            {
                if (item.Element("ativo").Value == "true")
                {       
                    string id = "id: " + item.Element("id").Value;
                    string nome = "nome: " + item.Element("nome").Value;
                    string email = "email: " + item.Element("email").Value;
                    string senha = "senha: " + item.Element("senha").Value;
                    string cpf = "cpf: " + item.Element("cpf").Value;

                    string[] v = { id, nome, email, senha, cpf };

                    users.Add(v);
                }
            }
            return users;


            //retorna todos os usuarios em string
            /*
              foreach (var item in xmlli.select())
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("---------------");
            }
            */
        }

    }
}
