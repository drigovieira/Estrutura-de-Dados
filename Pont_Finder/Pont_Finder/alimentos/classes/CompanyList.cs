using Pont_Finder.alimentos.classes;
using System;
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
            emp.Cpf = comp.Cpf;
            emp.Categoria = comp.Categoria;
            emp.Cep = comp.Cep;
            emp.TelComercial = comp.TelComercial;
            emp.Status = true;
            emp.Image = comp.Image;
            emp.FuncionamentoEmp = comp.FuncionamentoEmp;
            emp.SttsCardapio = comp.SttsCardapio;
            emp.SttsEntrega = comp.SttsEntrega;
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
        public static void alter(int ID, Company comp)
        {
            //percorre a lista com uma variável Company
            foreach (var emps in company)
            {
                if (emps.Id == ID)
                {
                    //pega o index da lista do usuário em questão
                    int index = company.IndexOf(emps);
                    //substitui na lista company                   
                    company[index].Nome = comp.Nome;
                    company[index].NomeFantasia = comp.NomeFantasia;
                    company[index].Email = comp.Email;
                    company[index].Rua = comp.Rua;
                    company[index].Numero = comp.Numero;
                    company[index].Bairro = comp.Bairro;
                    company[index].Categoria = comp.Categoria;
                    company[index].Cep = comp.Cep;
                    company[index].Cpf = comp.Cpf;
                    company[index].TelComercial = comp.TelComercial;
                    company[index].Status = true;
                    company[index].Image = comp.Image;
                    company[index].FuncionamentoEmp = comp.FuncionamentoEmp;
                    company[index].SttsCardapio = comp.SttsCardapio;
                    company[index].SttsEntrega = comp.SttsEntrega;
                    company[index].Id = comp.Id;
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

            foreach (var item in doc.Descendants("alimentos"))
            {
                Company empresa = new Company();
                empresa.Nome = item.Element("nome").Value;
                empresa.NomeFantasia = item.Element("nomeFantasia").Value;
                empresa.Email = item.Element("email").Value;
                empresa.Rua = item.Element("rua").Value;
                empresa.Bairro = item.Element("bairro").Value;
                empresa.Image = item.Element("image").Value;
                List<string> categorias = new List<string>();
                string[] tempCat = item.Element("categorias").Value.Split(',');
                foreach(var i in tempCat)
                {
                    categorias.Add(i);
                }
                empresa.Categoria = categorias;
                List<Funcionamento> funcionamento = new List<Funcionamento>();                
                string[] tempFuncio = item.Element("funcionamento").Value.Split('*');
                string[] tempFuncioSub;
                foreach (var a in tempFuncio)
                {
                    Funcionamento temp = new Funcionamento();
                    tempFuncioSub = a.Split(',');
                    temp.Dia = tempFuncioSub[0];
                    temp.HoraInicio = DateTime.Parse(tempFuncioSub[1]);
                    temp.HoraFim = DateTime.Parse(tempFuncioSub[2]);
                    funcionamento.Add(temp);
                }
                empresa.FuncionamentoEmp = funcionamento;
                empresa.Numero = int.Parse(item.Element("numero").Value);
                empresa.Cep = int.Parse(item.Element("cep").Value);
                empresa.Id = int.Parse(item.Element("id").Value);
                empresa.TelComercial = long.Parse(item.Element("telComercial").Value);
                empresa.Cpf = long.Parse(item.Element("cpf").Value);                
                empresa.Status = bool.Parse(item.Element("status").Value);
                empresa.SttsCardapio = bool.Parse(item.Element("statusCardapio").Value);
                empresa.SttsEntrega = bool.Parse(item.Element("statusEntrega").Value);
                CompanyList.CompAdd(empresa);
            }
        }
        public static void XmlSave()
        {
            XmlDrop();
            string categorias = "";
            foreach (var item in company)
            {                
                foreach (var i in item.Categoria) {
                    if (categorias.Equals(""))
                    {
                        categorias = i;
                    }
                    else
                    {
                        categorias += ","+i;
                    }                    
                }
                string funcio = "";
                foreach (var a in item.FuncionamentoEmp)
                {                    
                    if (funcio.Equals(""))
                    {
                        funcio = a.Dia + "," + a.HoraInicio.ToString() + "," + a.HoraFim.ToString();
                    }
                    else
                    {
                        funcio += "*"+ a.Dia +","+ a.HoraInicio.ToString() + "," + a.HoraFim.ToString();
                    }
                }
                XElement xemp =
                      new XElement("alimentos",
                      new XElement("nome", item.Nome),
                      new XElement("nomeFantasia", item.NomeFantasia),
                      new XElement("email", item.Email),
                      new XElement("rua", item.Rua),
                      new XElement("bairro", item.Bairro),
                      new XElement("image", item.Image),
                      new XElement("categorias", categorias),
                      new XElement("funcionamento", funcio),
                      new XElement("numero", item.Numero),
                      new XElement("cep", item.Cep),
                      new XElement("id", item.Id),
                      new XElement("telComercial", item.TelComercial),
                      new XElement("cpf", item.Cpf),
                      new XElement("status", item.Status),
                      new XElement("statusCardapio", item.SttsCardapio),
                      new XElement("statusEntrega", item.SttsEntrega));

                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xemp);
                doc.Save(caminho);
            }
        }
        public static void XmlDrop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("alimentos"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/modulos/alimentos");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }
        public static int verifEmp(long cpf)
        {
            int variaveis = -1;
            foreach (var item in company)
            {
                if (item.Cpf == cpf)
                {
                    variaveis = item.Id;            
                }
            }
            return variaveis;
        }
    }
}
