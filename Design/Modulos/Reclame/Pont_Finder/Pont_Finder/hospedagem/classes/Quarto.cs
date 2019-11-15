using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.hospedagem
{ 
    class Quarto
    {

        string nome_quarto, servicos, status, foto;
        int id, qtd_pessoas, qtd_disponivel;
        double valor_diario;
        long cnpj_empresa;
        bool ativo;

        //Gets e sets Strings

        public string NomeQuarto
        {
            get { return nome_quarto; }
            set { nome_quarto = value;}
        }
        public string Servicos
        {
            get { return servicos; }
            set { servicos = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Foto
        {
            get { return foto; }
            set { foto = value;}
        }

        //Gets e Sets Ints
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Qtd_Pessoas
        {
            get { return qtd_pessoas; }
            set { qtd_pessoas = value; }
        }
        public int Qtd_Disponivel
        {
            get { return qtd_disponivel; }
            set { qtd_disponivel = value; }
        }

        //Get e Set Double
        public double Valor_Diario
        {
            get { return valor_diario; }
            set { valor_diario = value; }
        }

        //Get e Set Long
        public long Cnpj_Empresa
        {
            get { return cnpj_empresa; }
            set { cnpj_empresa = value; }
        }

        //Get e Set Bool
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    } 
}
