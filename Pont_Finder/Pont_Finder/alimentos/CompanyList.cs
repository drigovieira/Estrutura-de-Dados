using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class CompanyList
    {
        private static List<Company> company = new List<Company>();
        public static void CompAdd(Company comp)
        {
            Company emp = new Company();
            emp.Nome = comp.Nome;
            emp.NomeFantasia = comp.NomeFantasia;
            emp.Email = comp.Email;
            emp.Rua = comp.Rua;
            emp.Numero = comp.Numero;
            emp.Bairro = comp.Bairro;
            emp.Categoria = comp.Categoria;
            emp.Cep = comp.Cep;
            emp.TelComercial = comp.TelComercial;
            emp.Status = true;
            company.Add(emp);
            company[company.IndexOf(emp)].Id = company.IndexOf(emp);
        }
        //falta arrumar o método select.
        public static int select(Company item)
        {            
            int index = 0;
            foreach(var select in company)
            {
                if(select.Equals(item))
                {
                    index = company.IndexOf(item);
                }
            }
            return index;
        }
        /*public void CompDel(string cnpj)
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
        }*/
        public static void alter(string cnpj, Company comp)
        {
            long cnpjConvert = Convert.ToInt64(String.Join("", System.Text.RegularExpressions.Regex.Split(cnpj, @"[^\d]")));
            //percorre a lista com uma variável Company
            foreach (var emps in company)
            {
                if (emps.Id == cnpjConvert)
                {
                    //pega o index da lista do usuário em questão
                    int index = company.IndexOf(emps);
                    //substitui na lista company
                    company[index].NomeFantasia = comp.NomeFantasia;
                    company[index].Email = comp.Email;
                    company[index].Rua = comp.Rua;
                    company[index].Numero = comp.Numero;
                    company[index].Bairro = comp.Bairro;
                    company[index].Cep = comp.Cep;
                    break;
                }
            }
        }
        public static List<Company> selectAll()
        {
            return company;
        }
        public static List<Company> SearchName(string name)
        {
            List<Company> lista = new List<Company>();
            foreach (var emps in company)
            {
                if (emps.Nome.ToLower().Contains(name.ToLower()))
                {
                    lista.Add(emps);
                }
            }
            return lista;
        }
        public static List<Company> SearchCategoria(string categoria)
        {
            List<Company> lista = new List<Company>();
            foreach (var emps in company)
            {
                if (emps.Categoria.ToLower().Contains(categoria.ToLower()))
                {
                    lista.Add(emps);
                }
            }
            return lista;
        }
        public static List<Company> SearchFiltro(string name, string categoria)
        {
            List<Company> lista = new List<Company>();
            foreach (var emps in company)
            {
                if (emps.Nome.ToLower().Contains(name.ToLower()) && emps.Categoria == categoria)
                {
                    lista.Add(emps);
                }
            }
            return lista;
        }
    }
}
