using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder
{
    class Session
    {
        private static int id = -1;
        private static string nome;
        private static string email;
        private static string senha;
        private static long cpf;
        private static string image;
        private static bool logado = false;

        public static bool Online
        {
            get
            {
                return logado;
            }
        }

        public static void Deslogar()
        {
            id = -1;
            nome = null;
            email = null;
            senha = null;
            cpf = -1;
            image = null;
            logado = false;
        }

        public static int Id
        {
            get { return Session.id; }
            set { Session.id = value; }
        }
        public static string Nome
        {
            get { return Session.nome; }
            set { Session.nome = value; }
        }
        public static string Email
        {
            get { return Session.email; }
            set { Session.email = value; }
        }
        public static string Senha
        {
            get { return Session.senha; }
            set { Session.senha = value; }
        }
        public static long Cpf
        {
            get { return Session.cpf; }
            set { Session.cpf = value; }
        }

        public static string Image
        {
            get { return image; }
            set { image = value; }
        }


        public static bool Login(string xEmail, string xSenha)
        {
            foreach (var item in UserList.thisUsers())
            {
                if (item.Email.Equals(xEmail) && item.Senha.Equals(xSenha))
                {
                    nome = item.Nome;
                    email = item.Email;
                    senha = item.Senha;
                    cpf = item.Cpf;
                    image = item.Image;
                    logado = true;
                    return true;
                }
            }
            Session.Deslogar();
            return false;           
        }

    }
}
