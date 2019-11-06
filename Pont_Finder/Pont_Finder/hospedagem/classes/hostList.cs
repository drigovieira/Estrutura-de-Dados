using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.hospedagem
{
    class hostList
    {
        private static List<Empresa> empresas = new List<Empresa>();

        public static void addEmpresa(Empresa empresa) //Adiciona uma empresa a lista
        {
            Empresa e = new Empresa();

            e.Nomeempresa = empresa.Nomeempresa;
            e.Nomefantasia = empresa.Nomefantasia;
            e.CNPJ = empresa.CNPJ;
            e.Endereco = empresa.Endereco;
            e.Cep = empresa.Cep;
            e.Telefone = empresa.Telefone;
            e.Email = empresa.Email;
            e.Foto = empresa.Foto;
            e.Tipo = empresa.Tipo;
            e.Estrelas = empresa.Estrelas;
            e.Descricao = empresa.Descricao;
            e.Ambiente = empresa.Ambiente;
            e.Ativo = empresa.Ativo;

            empresas.Add(e);
        }

        public static object[] select(int index) //Busca usuario pelo index
        {
            string nomeempresa = empresas[index].Nomeempresa;
            string nomefantasia = empresas[index].Nomefantasia;
            long cnpj = empresas[index].CNPJ;
            string endereco = empresas[index].Endereco;
            int cep = empresas[index].Cep;
            int telefone = empresas[index].Telefone;
            string email = empresas[index].Email;
            string foto = empresas[index].Foto;
            string tipo = empresas[index].Tipo;
            int estrelas = empresas[index].Estrelas;
            string descricao = empresas[index].Descricao;
            string ambiente = empresas[index].Ambiente;
            bool ativo = empresas[index].Ativo;

            object[] vetor = { nomeempresa, nomefantasia, cnpj, cep, telefone, email, foto, tipo, estrelas, descricao, ambiente, ativo };
            return vetor;

        }

        public static List<Empresa> selectAll()
        {
            List<Empresa> lista = new List<Empresa>();
            foreach (var item in empresas)
            {
                Empresa e = new Empresa();

                e.Nomeempresa = item.Nomeempresa;
                e.Nomefantasia = item.Nomefantasia;
                e.CNPJ = item.CNPJ;
                e.Endereco = item.Endereco;
                e.Cep = item.Cep;
                e.Telefone = item.Telefone;
                e.Email = item.Email;
                e.Foto = item.Foto;
                e.Tipo = item.Tipo;
                e.Estrelas = item.Estrelas;
                e.Descricao = item.Descricao;
                e.Ambiente = item.Ambiente;
                e.Ativo = item.Ativo;

                lista.Add(e);
            }
            return lista;
        }
    }
}
