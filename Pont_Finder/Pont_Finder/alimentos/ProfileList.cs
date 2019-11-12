﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class ProfileList
    {
        private static List<ProfileCompany> perfil = new List<ProfileCompany>();
        private static List<Evaluation> avaliacao = new List<Evaluation>();

        //Adicionando Atribudos adicionais vinculados a empresa
        public static void ProfileAdd(ProfileCompany emp)
        {
            ProfileCompany profComp = new ProfileCompany();

            profComp.Especialidade = emp.Especialidade;
            profComp.Contato = emp.Contato;
            profComp.HoraInicio = emp.HoraInicio;
            profComp.HoraFim = emp.HoraFim;
            profComp.Telefone = emp.Telefone;
            profComp.Cep = emp.Cep;
            profComp.Cel = emp.Cel;
            profComp.CodigoCompany = emp.CodigoCompany;
            perfil.Add(profComp);
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
            foreach (var itemEmp in perfil)
            {
                if (itemEmp.CodigoCompany == indexEmp)
                {
                    perfil[perfil.IndexOf(itemEmp)].NotaApurada = mediaNota / count;
                }
            }
        }
        public static List<ProfileCompany> selectAll()
        {
            return perfil;
        }
        public static List<Evaluation> selectEvaluation()
        {
            return avaliacao;
        }
        public static List<ProfileCompany> TopList(List<ProfileCompany> FiltroList)
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
        }

        public static List<ProfileCompany> profileList(List<Company> referenceProfile, string categoria)
        {
            List<ProfileCompany> Perfis = new List<ProfileCompany>();
            CompanyList comp = new CompanyList();
            foreach (var id in referenceProfile)
            {
                if (id.Categoria.Equals(categoria))
                {
                    foreach (var item in perfil)
                    {
                        if (id.Id == item.CodigoCompany)
                        {
                            Perfis.Add(item);
                        }
                    }
                }
            }
            return Perfis;
        }
    }
}
