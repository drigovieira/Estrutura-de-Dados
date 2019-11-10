using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.eventos.Classes
{
    class CoEvento
    {
        private int id;
        private string imagem1;
        private string imagem2;
        private string imagem3;
        private string imagem4;
        private string categoria;
        private string descricao;
        private string data;
        private string horario;
        private string local;
        private string idade;
        private string valor;
        private string patrocinadores;
        private string modulo;
        private bool ativo;

        public int Id
        {
            get { return id; }
            set { id = value; }
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
