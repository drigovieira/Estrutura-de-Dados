using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.socialist
{
    class Solicitado
    {
        private int
            postId;

        private long
            cpfUser;

        private DateTime
            data;

        public int PostId { get => postId; set => postId = value; }
        public long CpfUser { get => cpfUser; set => cpfUser = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
