using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class Company
    {
        private string nome, nomeFantasia, email, categoria, rua, bairro;
        private int numero, cep, telComercial, ID;
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
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
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
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int TelComercial
        {
            get { return telComercial; }
            set { telComercial = value; }
        }
    }
}
