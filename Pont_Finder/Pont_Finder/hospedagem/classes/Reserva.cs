using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.hospedagem.classes
{
    class Reserva
    {
        private int id, id_quarto;
        private long cpf_user;
        private DateTime data_inicial, data_final;
        private double valor;
        private string metodo_pagamento;
        bool status;


        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public long Usuario
        {
            get { return cpf_user; }
            set { cpf_user = value; }
        }

        public int  Id
        {
            get{ return id;}
            set { id = value; }
        }

        public int IdQuarto
        {
            get { return id_quarto; }
            set { id_quarto = value; }
        }

        public double Valor
        { 
            get { return valor; }
            set { valor = value; }
        }

        public string MetodoPagamento
        {
            get { return metodo_pagamento; }
            set { metodo_pagamento = value; }
        }

        public DateTime Data_inicial
        {
            get { return data_inicial; }
            set { data_inicial = value; }
        }

        public DateTime Data_final
        {
            get { return data_final; }
            set { data_final = value; }
        }
    }
}
