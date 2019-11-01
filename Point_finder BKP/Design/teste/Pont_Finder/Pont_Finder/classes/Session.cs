using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder
{
    class Session
    {
        private static string email;
        private static string senha;

 
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
    }
}
