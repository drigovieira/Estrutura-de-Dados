﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class CompanyList
    {
        private List<Company> company = new List<Company>();
        public void CompAdd(Company comp)
        {
            Company emp = new Company();
            emp.Nome = comp.Nome;
            emp.NomeFantasia = comp.NomeFantasia;
            emp.Email = comp.Email;
            emp.TipoServico = comp.TipoServico;
         
            emp.Endereco = comp.Endereco;
            emp.Cep = comp.Cep;
            emp.Cnpj = comp.Cnpj;
            emp.Status = true;

            company.Add(emp);
        }
        //falta arrumar o método select.
        public Company select(int index)
        {
            Company emp = new Company();
            emp.Nome = company[index].Nome;
            emp.NomeFantasia = company[index].NomeFantasia;
            emp.Email = company[index].Email;
            emp.TipoServico = company[index].TipoServico;  
            emp.Endereco = company[index].Endereco;
            emp.Cep = company[index].Cep;
            emp.Cnpj = company[index].Cnpj;
            emp.Status = company[index].Status;
            return emp;
        }
        public void CompDel(string cnpj)
        {
            //formata a string que ta com marcara pra long, só numeros
            long cnpjConvert = Convert.ToInt64(String.Join("", System.Text.RegularExpressions.Regex.Split(cnpj, @"[^\d]")));
            // percorre a lista com uma variável company
            foreach (var emps in company)
            {
                if (emps.Cnpj == cnpjConvert)
                {
                    int index = company.IndexOf(emps);
                    company[index].Status = false;
                    break;
                }
            }            
        }
        public void alter(string cnpj, Company comp)
        {
            long cnpjConvert = Convert.ToInt64(String.Join("", System.Text.RegularExpressions.Regex.Split(cnpj, @"[^\d]")));
            //percorre a lista com uma variável Company
            foreach (var emps in company)
            {
                if (emps.Cnpj == cnpjConvert)
                {
                    //pega o index da lista do usuário em questão
                    int index = company.IndexOf(emps);
                    //substitui na lista company
                    company[index].NomeFantasia = comp.NomeFantasia;
                    company[index].Email = comp.Email;
                    company[index].TipoServico = comp.TipoServico;
  
                    company[index].Endereco = comp.Endereco;
                    company[index].Cep = comp.Cep;
                    company[index].Cnpj = comp.Cnpj;
                    break;
                }
            }
        }
        public List<Company> selectAll()
        {
            List<Company> lista = new List<Company>();
            //seleciona tudo e armazena em uma lista
            foreach (var item in company)
            {
                Company emp = new Company();                
                emp.Nome = item.Nome;
                emp.NomeFantasia = item.NomeFantasia;
                emp.Email = item.Email;
                emp.TipoServico = item.TipoServico;
                emp.Endereco = item.Endereco;
                emp.Cep = item.Cep;
                emp.Cnpj = item.Cnpj;
                emp.Status = item.Status;
                lista.Add(emp);
            }
            return lista;
        }
    }
}
