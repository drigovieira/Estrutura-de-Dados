using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.eventos.Classes
{
    class CoEvento
    {
        private bool
            ativo;
        public int
            ingressosTotal,
            ingressosDisponivel;
        public long
            cnpj, id;
        public string
            nome,
            categoria,
            descricao,
            data,
            horario,
            local,
            idade,
            valor,
            patrocinadores,
            modulo,
            imagem1,
            imagem2,
            imagem3,
            imagem4;

        private List<long[]>
          likes = new List<long[]>();




        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IngressosTotal
        {
            get { return ingressosTotal; }
            set { ingressosTotal = value; }
        }

        public int IngressoDispinivel
        {
            get { return ingressosDisponivel; }
            set { ingressosDisponivel = value; }
        }

        public long Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Imagem1
        {
            get { return imagem1; }
            set { imagem1 = value; }
        }

        public string Imagem2
        {
            get { return imagem2; }
            set { imagem2 = value; }
        }

        public string Imagem3
        {
            get { return imagem3; }
            set { imagem3 = value; }
        }

        public string Imagem4
        {
            get { return imagem4; }
            set { imagem4 = value; }
        }


        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Patrocinadores
        {
            get { return patrocinadores; }
            set { patrocinadores = value; }
        }

        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
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
