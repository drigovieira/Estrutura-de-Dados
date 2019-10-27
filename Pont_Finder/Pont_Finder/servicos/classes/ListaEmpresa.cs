using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class ListaEmpresa
    {
        private static List<Empresa> listaEmpresa = new List<Empresa>();

        public static void Add(Empresa comp)
        {
            Empresa tmp = new Empresa();
            tmp.Nome = comp.Nome;
            tmp.NomeFantasia = comp.NomeFantasia;
            tmp.Email = comp.Email;
            tmp.TipoServico = comp.TipoServico;
            tmp.Senha = comp.Senha;
            tmp.Cnpj = comp.Cnpj;
            tmp.Endereco = comp.Endereco;
            tmp.Telefone = comp.Telefone;
            tmp.Status = true;
            listaEmpresa.Add(tmp);
        }

        public static List<Empresa> selectAll()
        {
            List<Empresa> lista = new List<Empresa>();
            foreach (var item in listaEmpresa)
            {
                Empresa tmp = new Empresa();
                tmp.Nome = item.Nome;
                tmp.NomeFantasia = item.NomeFantasia;
                tmp.Email = item.Email;
                tmp.TipoServico = item.TipoServico;
                tmp.Senha = item.Senha;
                tmp.Cnpj = item.Cnpj;
                tmp.Endereco = item.Endereco;
                tmp.Telefone = item.Telefone;
                tmp.Status = item.Status;
                listaEmpresa.Add(tmp);
            }
            return lista;
        }
    }
}
