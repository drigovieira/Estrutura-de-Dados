using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class Empresa
    {
        private string
            nome,
            nomeFantasia,
            email,
            telefone,
            endereco, //endereco no formato -> rua, numero, cidade, cep
            image,
            servicos; //servicos, uma lista de (tipo) servicos que a empresa pode prestar

        private long
            cnpj, //cnpj da empresa
            cpf; //cpf do usiario que cadastrou a empresa

        private bool
            status;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Servicos
        {
            get { return servicos; }
            set { servicos = value; }
        }

        public long Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
