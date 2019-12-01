﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.alimentos
{
    class CompanyList
    {
        private static List<Company> company = new List<Company>();
        private static string caminho = "..\\..\\data\\empresas.xml";
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
            emp.Image = comp.Image;
            emp.FuncionamentoEmp = comp.FuncionamentoEmp;
            company.Add(emp);
            company[company.IndexOf(emp)].Id = company.IndexOf(emp);
        }
        //falta arrumar o método select.
        public static Company select(int id)
        {
            Company empresa = new Company();
            foreach(var select in company)
            {
                if(company.IndexOf(select) == id)
                {
                    empresa = select;
                }
            }
            return empresa;
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
                if (emps.Categoria.Contains(categoria.ToLower()))
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
                if (emps.Nome.ToLower().Contains(name.ToLower()) && emps.Categoria.Contains(categoria))
                {
                    lista.Add(emps);
                }
            }
            return lista;
        }
        public static void XmlLoad()
        {
            XDocument doc = XDocument.Load(caminho);

            /*foreach (var item in doc.Descendants("alimentos"))
            {
                Company empresa = new Company();
                empresa.Nome = item.Element("nome").Value;
                empresa.NomeFantasia = item.Element("nomeFantasia").Value;
                empresa.Email = item.Element("email").Value;
                empresa.Telefone = item.Element("telefone").Value;
                empresa.Endereco = item.Element("endereco").Value;
                empresa.Categoria = item.Element("service").Value;
                empresa.Cnpj = long.Parse(item.Element("cnpj").Value);
                empresa.Cpf = long.Parse(item.Element("cpf").Value);
                empresa.Image = item.Element("image").Value;
                empresa.Status = bool.Parse(item.Element("status").Value);
                CompanyList.CompAdd(empresa);
            }*/
        }
        public static void XmlSave()
        {
            XmlDrop();
            /*foreach (var item in listaEmpresa)
            {
                XElement xemp =
                      new XElement("servico",
                      new XElement("nome", item.Nome),
                      new XElement("nomeFantasia", item.NomeFantasia),
                      new XElement("email", item.Email),
                      new XElement("telefone", item.Telefone),
                      new XElement("endereco", item.Endereco),
                      new XElement("service", item.Categoria),
                      new XElement("cnpj", item.Cnpj),
                      new XElement("cpf", item.Cpf),
                      new XElement("image", item.Image),
                      new XElement("status", item.Status));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xemp);
                doc.Save(caminho);
            }*/
        }
        public static void XmlDrop()
        {
            /*XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("servico"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/modulos/servico");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);*/
        }
    }
}
