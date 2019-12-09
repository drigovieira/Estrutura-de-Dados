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
    }
}
