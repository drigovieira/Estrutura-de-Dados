using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder.alimentos.classes
{
    class EvaluationList
    {
        private static List<Evaluation> avaliacao = new List<Evaluation>();
        public static List<Company> TopList(List<Company> FiltroList)
        {
            List<Company> topList = new List<Company>();
            Company temp;
            int count = 0;
            foreach (var quant in FiltroList)
            {
                count++;
                if (count == 5) { break; }
            }
            for (int cont = 0; cont < count; cont++)
            {
                temp = new Company();
                foreach (var i in FiltroList)
                {
                    if (topList.Contains(i)) { }
                    else if (i.Like > temp.Like)
                    {
                        temp = i;
                    }
                }
                topList.Add(temp);
            }
            return topList;
        }
        public static List<Evaluation> selectEvaluation()
        {
            return avaliacao;
        }
        public static void AddAvaliacao(int nota, int indexEmp, long Cpf, string tipo)
        {
            Evaluation ava = new Evaluation();
            ava.Nota = nota;
            ava.IndexEmp = indexEmp;
            ava.Cpf = Cpf;
            ava.Tipo = tipo;
            avaliacao.Add(ava);
            avaliacao[avaliacao.IndexOf(ava)].Id = avaliacao.IndexOf(ava);
        }
        public static void DelAvaliacao(long CPF, int ID)
        {
            try
            {                
                foreach(var rem in avaliacao)
                {                    
                        if (rem.Cpf == CPF && rem.IndexEmp == ID)
                        {
                            avaliacao.Remove(rem);
                        }
                }
            }
            catch { }
        }
        public static Evaluation select(long CPF)
        {
            Evaluation eva = new Evaluation();
            foreach(var i in avaliacao)
            {
                if (i.Cpf == CPF) eva = i;
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
        public static List<Evaluation> selectAll()
        {
            return avaliacao;
        }
        public static void XmlLoad()
        {
            string caminho = "..\\..\\alimentos\\data\\evaluation.xml";
            XDocument doc = XDocument.Load(caminho);
            
            foreach(var item in doc.Descendants("evaluation"))
            {
                Evaluation ava = new Evaluation();
                ava.Id = int.Parse(item.Element("id").Value);
                ava.IndexEmp = int.Parse(item.Element("idEmpresa").Value);
                ava.Nota = int.Parse(item.Element("nota").Value);
                ava.Tipo = item.Element("tipo").Value;
                avaliacao.Add(ava);
            }
        }
        public static void XmlSave()
        {
            XmlDrop();
            string caminho = "..\\..\\alimentos\\data\\evaluation.xml";
            foreach(var item in avaliacao)
            {
                XElement xava =
                    new XElement("evaluation",
                    new XElement("id", item.Id),
                    new XElement("idEmpresa", item.IndexEmp),
                    new XElement("nota", item.Nota),
                    new XElement("tipo", item.Tipo));
                XDocument doc = XDocument.Load(caminho);
                doc.Root.Add(xava);
                doc.Save(caminho);
            }

        }
        public static void XmlDrop()
        {
            string caminho = "..\\..\\alimentos\\data\\evaluation.xml";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("evaluation"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/EvaluationList/evaluation");
                node.ParentNode.RemoveChild(node);
            }
            xmldoc.Save(caminho);
        }
    }
}
