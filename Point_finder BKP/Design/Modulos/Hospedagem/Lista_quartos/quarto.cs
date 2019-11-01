using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_quartos
{
    class quarto
    {
        //atributos
        private int id;
        private int QtdPessoa;
        private int QtdQuarto;
        private string NomeQuarto;
        private string Servicos;
        private double ValorDiaria;

        //metodos
        public string nomequarto
        {
            get { return NomeQuarto; }
            set { NomeQuarto = value; }
        }
        public double valordiaria
        {
            get { return ValorDiaria; }
            set { ValorDiaria = value; }
        }
        public int qtdquartos
        {
            get { return QtdQuarto; }
            set { QtdQuarto = value; }
        }
        public string servicos
        {
            get { return Servicos; }
            set { Servicos = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int qtdpessoas
        {
            get { return QtdPessoa; }
            set { QtdPessoa= value; }
        }
    }

}
