﻿using System;
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
        public static void AddAvaliacao(int nota, int indexEmp, int indexClient, string tipo)
        {
            Evaluation ava = new Evaluation();
            ava.Nota = nota;
            ava.IndexEmp = indexEmp;
            ava.IndexClient = indexClient;
            ava.Tipo = tipo;
            avaliacao.Add(ava);
            avaliacao[avaliacao.IndexOf(ava)].Id = avaliacao.IndexOf(ava);
        }
        public static void DelAvaliacao(int ID)
        {
            try
            {                
                foreach(var rem in avaliacao)
                {                    
                        if (rem.Id == ID)
                        {
                            avaliacao.Remove(rem);
                        }
                }
            }
            catch { }
        }
        public static Evaluation select(int ID)
        {
            Evaluation eva = new Evaluation();
            foreach(var i in avaliacao)
            {
                if (i.IndexClient == ID) eva = i;
            }
            return eva;
        }
        public static void ApuraAvaliacao(int indexEmp)
        {
            int valor1 = 0;
            int valor2 = 0;
            foreach(var i in avaliacao)
            {
                if(i.IndexEmp == indexEmp)
                {
                    if (i.Tipo.Equals("like")) {
                        valor1 += i.Nota;
                    }
                    else
                    {
                        valor2 += i.Nota;
                    }
                }                
            }
            CompanyList.AttEvaluation(indexEmp, "like", valor1);
            CompanyList.AttEvaluation(indexEmp, "deslike", valor2);
        }
    }
}
