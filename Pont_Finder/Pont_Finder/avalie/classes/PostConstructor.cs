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
            tempohora;
        private long 
            cpf,
            id;
        private bool
            ativo,
            resolved;


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
        

    }
}
