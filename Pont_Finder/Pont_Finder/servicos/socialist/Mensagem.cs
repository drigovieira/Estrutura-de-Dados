using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.socialist
{
    class Mensagem
    {
        private long
            de,
            para;

        private int
            postId;

        private string
            msg;

        private DateTime
            data;

        public long De { get => de; set => de = value; }
        public long Para { get => para; set => para = value; }
        public string Msg { get => msg; set => msg = value; }
        public DateTime Data { get => data; set => data = value; }
        public int PostId { get => postId; set => postId = value; }
    }
}
