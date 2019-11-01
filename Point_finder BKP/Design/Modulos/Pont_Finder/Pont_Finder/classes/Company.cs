using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class Company
    {
        private string
            nome,
            nomeFantasia,
            email,
            tipoServico,
            endereco,
            tipo;

        private long cnpj;
        private int cep;
        private bool status;

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
        public string TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }
       
        public long Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
       
        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }       
    }
}
