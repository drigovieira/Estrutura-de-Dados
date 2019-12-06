using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.hospedagem.classes
{
    class reserveList
    {
        private static List<Reserva> reservas = new List<Reserva>();

        private static string caminho = "..\\..\\hospedagem\\data\\reservas.xml";

        public static void addReserva(Reserva reserva)
        {
            Reserva r = new Reserva();

            r.Id = reserva.Id;
            r.IdQuarto = reserva.IdQuarto;
            r.Usuario = reserva.Usuario;
            r.Data_inicial = reserva.Data_inicial;
            r.Data_final = reserva.Data_final;
            r.MetodoPagamento = reserva.MetodoPagamento;
            r.Valor = reserva.Valor;

            reservas.Add(r);
        }

        public static List<Reserva> selectAll()
        {
            List<Reserva> lista = new List<Reserva>();

            foreach (var item in reservas)
            {
                Reserva r = new Reserva();

                r.Id = item.Id;
                r.IdQuarto = item.IdQuarto;
                r.Usuario = item.Usuario;
                r.Data_inicial = item.Data_inicial;
                r.Data_final = item.Data_final;
                r.MetodoPagamento = item.MetodoPagamento;
                r.Valor = item.Valor;


                lista.Add(r);
            }

            return lista;
        }

        public static List<Reserva> SelectCpf(long cpf_user)
        {
            List<Reserva> lista_cpf = new List<Reserva>();

            Reserva r = new Reserva();

            foreach (var item in reservas)
            {
                if (cpf_user == item.Usuario)
                {
                    r.Id = item.Id;
                    r.IdQuarto = item.IdQuarto;
                    r.Usuario = item.Usuario;
                    r.Data_inicial = item.Data_inicial;
                    r.Data_final = item.Data_final;
                    r.MetodoPagamento = item.MetodoPagamento;
                    r.Valor = item.Valor;

                    lista_cpf.Add(r);
                }
            }

            return lista_cpf;
        }

    }
}
