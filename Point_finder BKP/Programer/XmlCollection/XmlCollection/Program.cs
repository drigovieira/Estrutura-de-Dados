using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlCollection
{
    class Program
    {
        static void Main(string[] args)
        {
       
            XmlLi xmlli = new XmlLi();
            UserList userList = new UserList();
            User user = new User();
            
            foreach (var item in xmlli.select())
            {
                user.Nome = item[1];
                user.Email = item[2];
                user.Senha = item[3];
                user.Cpf = long.Parse(item[4]);
                user.Ativo = bool.Parse(item[5]);
                userList.userAdd(user);
            }

            xmlli.Drop();

            //comeco do programa carregando string[] v = { id, nome, email, senha, cpf, ativo };

            string str = "Nome: {0} \nEmail: {1} \nSenha: {2} \nCPF: {3} \nStatus: {4} \n";
            foreach (var item in userList.selectAll())
            {
                Console.WriteLine(String.Format(str, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo));
            }

            Console.WriteLine("Salvar Xml");
            Console.ReadKey();



          
     

            //final do programa salvando...

            int cont = 0;
            foreach (var item in userList.selectAll())
            {        
                xmlli.Add(cont, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo);
                cont++;
            }
            
            Console.WriteLine("Dados Salvos");
            
            Console.ReadKey();

        }
    }
}
