using Pont_Finder.alimentos.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class Company
    {
        private string nome, nomeFantasia, email, rua, bairro, image;
        private List<string> categoria;
        private List<Funcionamento> funcionamentoEmp;
        private int numero, cep, ID, notaApurada;
        private long telComercial, cpf;
        private bool status, sttsCardapio, sttsEntrega;
        private float taxa;

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
        public bool SttsCardapio
        {
            get { return sttsCardapio; }
            set { sttsCardapio = value; }
        }
        public bool SttsEntrega
        {
            get { return sttsEntrega; }
            set { sttsEntrega = value; }
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public List<string> Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public long TelComercial
        {
            get { return telComercial; }
            set { telComercial = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public List<Funcionamento> FuncionamentoEmp
        {
            get { return funcionamentoEmp; }
            set { funcionamentoEmp = value; }
        }
        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public float Taxa
        {
            get { return taxa; }
            set { taxa = value; }
        }
        public int NotaApurada
        {
            get { return notaApurada; }
            set { notaApurada = value; }
        }
    }
}
