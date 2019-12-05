using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.hospedagem
{
    class Empresa
    {
        //Atributo da Empresa

        private string nomeempresa, nomefantasia, endereco, email, descricao, ambiente, foto, tipo, logo;
        private int cep, estrelas, id;
        private bool ativo;
        private long cnpj, cpfadmin, telefone;



        //Get e Sets
        //Get e Sets Strings

        public string Nomeempresa
        {
            get { return nomeempresa; }
            set { nomeempresa = value; }
        }
        public string Nomefantasia
        {
            get { return nomefantasia; }
            set { nomefantasia = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string Ambiente
        {
            get { return ambiente; }
            set { ambiente = value; }
        }
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        //Get e Set Long

        public long CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public long CPFADMIN
        {
            get { return cpfadmin; }
            set { cpfadmin = value; }
        }
        public long Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        //Gets e Sets Ints
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        
        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public int Estrelas
        {
            get { return estrelas; }
            set { estrelas = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }


    }
}
