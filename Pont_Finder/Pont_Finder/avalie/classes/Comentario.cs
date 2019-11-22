using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.avalie.classes
{
    class Comentario
    {
        long
            userCpf,
            postId;
        string
            comment,
            resposta;
        bool
            status;

        public long UserCpf { get => userCpf; set => userCpf = value; }
        public long PostId { get => postId; set => postId = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Resposta { get => resposta; set => resposta = value; }
        public bool Status { get => status; set => status = value; }
    }
}
