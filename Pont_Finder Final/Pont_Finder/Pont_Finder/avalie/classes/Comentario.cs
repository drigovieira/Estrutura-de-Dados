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
            postId,
            idcoment;

        string
            data,
            comment,
            imgUser,
            username;
           
        bool
            ativo;

        private List<long[]>
           likes = new List<long[]>();

        public long UserCpf { get => userCpf; set => userCpf = value; }
        public long PostId { get => postId; set => postId = value; }
        public long Idcoment { get => idcoment; set => idcoment = value; }
        public string Data { get => data; set => data = value; }
        public string Comment { get => comment; set => comment = value; }
        public string ImgUser { get => imgUser; set => imgUser = value; }
        public string Username { get => username; set => username = value; }
        public bool Ativo { get => ativo; set => ativo = value; }





        public void like(short valor, long cpf)
        {
            int verify = this.vLike(cpf);
            if (verify == -1)
            {
                long[] v = new long[2];
                v[0] = valor;
                v[1] = cpf;
                likes.Add(v);
            }
            else
            {
                foreach (var item in likes)
                {
                    if (cpf == item[1])
                    {
                        item[0] = valor;
                        break;
                    }
                }
            }
        }

        public long Likes
        {
            get
            {
                if (likes.Count == 0)
                {
                    return 0;
                }
                else
                {
                    long total = 0;

                    foreach (var item in likes)
                    {
                        total += item[0];
                    }
                    return total;
                };
            }
        }

        public long Joinha
        {
            get
            {
                if (likes.Count == 0)
                {
                    return 0;
                }
                else
                {
                    long total = 0;

                    foreach (var item in likes)
                    {
                        if (item[0] == 1)
                        {
                            total++;
                        }

                    }
                    return total;
                };
            }
        }
        public long DeJoinha
        {
            get
            {
                if (likes.Count == 0)
                {
                    return 0;
                }
                else
                {
                    long total = 0;

                    foreach (var item in likes)
                    {
                        if (item[0] == -1)
                        {
                            total++;
                        }

                    }
                    return total;
                };
            }
        }




        public int vLike(long cpf)
        {
            int cont = -1;
            foreach (var item in likes)
            {
                if (item[1] == cpf)
                {
                    cont++;
                    return cont;
                }
            }
            return cont;
        }

        public long userLike(long cpf)
        {
            int vlike = this.vLike(cpf);
            if (vlike == -1)
            {
                return 0;
            }
            else
            {
                return likes[vlike][0];
            }
        }


        public List<long[]> LikesList
        {
            get { return likes; }
            set { likes = value; }
        }



    }
}
