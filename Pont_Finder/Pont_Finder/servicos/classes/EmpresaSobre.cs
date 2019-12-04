using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class EmpresaSobre
    {
        private string
            slogan,
            sobre,
            descricao,
            site,
            politicaPrivacidade,
            imageCapa;

        public string Slogan { get => slogan; set => slogan = value; }
        public string Sobre { get => sobre; set => sobre = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Site { get => site; set => site = value; }
        public string PoliticaPrivacidade { get => politicaPrivacidade; set => politicaPrivacidade = value; }
        public string ImageCapa { get => imageCapa; set => imageCapa = value; }
    }
}
