using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.eventos.classes
{
    class Empresa_List
    {

        public static List<CaEmpresa> poster = new List<CaEmpresa>();

        public static void PostAddEmpresa(CaEmpresa post)
        {
            CaEmpresa pos = new CaEmpresa();

            pos.Nome = post.Nome;
            pos.Nome_Fantasia = post.Nome_Fantasia;
            pos.Email = post.Email;
            pos.Senha = post.Senha;
            pos.Cnpj = post.Cnpj;
            pos.Telefone = post.Telefone;
            pos.Endereco = post.Endereco;
            pos.Modulo = "eventos";

            poster.Add(pos);
        }

        public static string[] select(int index)
        {

            string nome = poster[index].Nome;
            string nome_Fantasia = poster[index].Nome_Fantasia;
            string email = poster[index].Email;
            string senha = poster[index].Senha;
            string cnpj = poster[index].Cnpj;
            string telefone = poster[index].Telefone;
            string endereco = poster[index].Endereco;
            string modulo = poster[index].Modulo;
            string[] vetor = { nome, nome_Fantasia, email, senha, cnpj, telefone, endereco, modulo };
            return vetor;

        }


        public static void del(int index)
        {
            poster[index].Nome = "";
            poster[index].Nome_Fantasia = "";
            poster[index].Email = "";
            poster[index].Senha = "";
            poster[index].Cnpj = "";
            poster[index].Telefone = "";
            poster[index].Endereco = "";
            poster[index].Modulo = "";
            


        }

    }
}
