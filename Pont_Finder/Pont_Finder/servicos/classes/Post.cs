using System;
using System.Collections.Generic;

namespace Pont_Finder.servicos.classes
{
    class Post
    {

        private int
            id;

        private long
            cpf,
            cnpj;

        private string
            titulo,
            descricao,
            image;

        private double
            valor;

        private bool
            ativo;
           
        private DateTime
            data;

        private List<long[]>
            likes = new List<long[]>();

        public Post()
        {
            ativo = true;
            cpf = Session.Cpf;
            //cnpj = -1;
            //data = DateTime.Now;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
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

        public long
            Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

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

