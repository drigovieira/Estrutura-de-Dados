using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.avalie
{
    class PostConstructor
    {

        private string
            desc,
            localizacao,
            tipoproblema,
            img,
            nome,
            tempohora,
            imgperfil;
        private long 
            cpf,
            id;
        private bool
            ativo,
            resolved;

        private List<long[]>
            likes = new List<long[]>();


        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }


        public string Img
        {
            get { return img; }
            set { img = value; }
        }



        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }



        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }

        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }

        }
        

        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        public string Tipoproblema
        {
            get { return tipoproblema; }
            set { tipoproblema = value; }

        }

        public string Tempohora
        {
            get { return tempohora; }
            set { tempohora = value; }
        }

        public bool Resolved
        {
            get { return resolved; }
            set { resolved = value; }
        }

        public string Imgperfil
        {
            get { return imgperfil; }
            set { imgperfil = value; }
        }


        //LIKETEMPORARIO

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
