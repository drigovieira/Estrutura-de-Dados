using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class ServiceList
    {
        private static List<Service> services = new List<Service>();

        public static void Add(Service service)
        {
            Service s = new Service();
            s.Id = service.Id;
            s.Tipo = service.Tipo;
            s.Valor = service.Valor;
            s.Detalhes = service.Detalhes;
            s.Sugestoes = s.Sugestoes;
            s.Visualizacoes = service.Visualizacoes;
            s.Like = service.Like;
            s.Avaliacao = service.Avaliacao;
            s.Ativo = service.Ativo;
            s.Image = service.Image;
            services.Add(s);
        }

        public static List<Service> selectAll()
        {
            List<Service> lista = new List<Service>();
            foreach (var item in services)
            {
                Service s = new Service();
                s.Id = item.Id;
                s.Tipo = item.Tipo;
                s.Valor = item.Valor;
                s.Detalhes = item.Detalhes;
                s.Sugestoes = item.Sugestoes;
                s.Visualizacoes = item.Visualizacoes;
                s.Like = item.Like;
                s.Avaliacao = item.Avaliacao;
                s.Ativo = item.Ativo;
                s.Image = item.Image;
                lista.Add(s);
            }
            return lista;
        }

        public static int Tam
        {
            get { return services.Count; }
        }
    }
}
