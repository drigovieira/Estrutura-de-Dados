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
            categoria; //servicos, uma lista de (tipo) servicos que a empresa pode prestar

        private long
            cnpj, //cnpj da empresa
            cpf; //cpf do usiario que cadastrou a empresa

        private bool
            status;

        public string Nome { get => nome; set => nome = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Image { get => image; set => image = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public long Cnpj { get => cnpj; set => cnpj = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public bool Status { get => status; set => status = value; }
    }
}
