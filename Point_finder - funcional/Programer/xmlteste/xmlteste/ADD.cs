using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlteste
{
    class ADD
    {
        UsuData UZ = new UsuData();
        LOAD lod = new LOAD();
        string caminho = "..\\..\\data\\usuarios.xml";


        public void Adicionar()
        {
            lod.Listar();

            Console.WriteLine("ID: ");
            UZ.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            UZ.Nome = (Console.ReadLine());
            Console.WriteLine("Email: ");
            UZ.Email = (Console.ReadLine());
            Console.WriteLine("Senha: ");
            UZ.Senha = (Console.ReadLine());
            Console.WriteLine("CPF: ");
            UZ.Cpf = long.Parse(Console.ReadLine());


            UsuData usud = new UsuData();



            XDocument docadd = XDocument.Load(caminho);
            XElement usu = new XElement("usuario",
                new XAttribute("id", UZ.Id),
                new XElement("nome", UZ.Nome),
                new XElement("email", UZ.Email),
                new XElement("senha", UZ.Senha),
                new XElement("cpf", UZ.Cpf));

            docadd.Root.Add(usu);
            docadd.Save(caminho);
            Console.ReadLine();
        }

    }
}
