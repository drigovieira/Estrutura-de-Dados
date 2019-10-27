using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem.classes
{
    class hostList
    {
        private static List<Empresa> empresas = new List<Empresa>();

        public static void addEmpresa(Empresa empresa)
        {
            Empresa e = new Empresa();

            e.Nomeempresa = empresa.Nomeempresa;
            e.Nomefantasia = empresa.Nomefantasia;
            e.CNPJ = empresa.CNPJ;
            e.Endereco = empresa.Endereco;
            e.Cep = empresa.Cep;
            e.Telefone = empresa.Telefone;
            e.Email = empresa.Email;




            empresas.Add(e);
        }
    }
}
