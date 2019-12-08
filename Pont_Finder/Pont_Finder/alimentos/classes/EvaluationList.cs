using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos.classes
{
    class EvaluationList
    {
        private static List<Evaluation> avaliacao = new List<Evaluation>();

        /*public static List<ProfileCompany> TopList(List<ProfileCompany> FiltroList)
        {
            List<ProfileCompany> topList = new List<ProfileCompany>();
            ProfileCompany temp;
            int count = 0;
            foreach (var quant in FiltroList)
            {
                count++;
                if (count == 5) { break; }
            }
            for (int cont = 0; cont < count; cont++)
            {
                temp = new ProfileCompany();
                foreach (var i in FiltroList)
                {
                    if (topList.Contains(i)) { }
                    else if (i.NotaApurada > temp.NotaApurada)
                    {
                        temp = i;
                    }
                }
                topList.Add(temp);
            }
            return topList;
        }*/
        public static List<Evaluation> selectEvaluation()
        {
            return avaliacao;
        }
        public static void AddAvaliacao(int nota, int indexEmp, int indexClient)
        {
            Evaluation ava = new Evaluation();
            ava.Nota = nota;
            ava.IndexEmp = indexEmp;
            ava.IndexClient = indexClient;
            avaliacao.Add(ava);
        }
        public static void ApuraAvaliacao(int indexEmp)
        {
            float mediaNota = 0;
            int count = 0;
            foreach (var itemAva in avaliacao)
            {
                if (itemAva.IndexEmp == indexEmp)
                {
                    mediaNota += itemAva.Nota;
                    count = count + 1;
                }
            }
            /*foreach (var itemEmp in perfil)
            {
                if (itemEmp.CodigoCompany == indexEmp)
                {
                    perfil[perfil.IndexOf(itemEmp)].NotaApurada = mediaNota / count;
                }
            }*/
        }
    }
}
