using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.socialist
{
    class MensagemList
    {
        private static List<Mensagem> mensagens = new List<Mensagem>();

        public static List<Mensagem> Mensagens { get => mensagens; set => mensagens = value; }
    }
}
