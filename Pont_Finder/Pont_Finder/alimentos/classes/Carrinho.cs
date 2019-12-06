using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos.classes
{
    class Carrinho
    {
        private static List<Cardapio> lista = new List<Cardapio>();

        public static void Add(object[] item)
        {
            Cardapio cad = new Cardapio();
            cad.Id = int.Parse(item[0].ToString());
            cad.Nome = item[1].ToString();
            cad.Image = item[2].ToString();
            List<string> ingr = new List<string>();
            foreach (var i in item[3].ToString().Split('/'))
            {
                ingr.Add(i);
            }
            cad.Ingredientes = ingr;
            cad.Preco = float.Parse(item[4].ToString());
            cad.Qtd = float.Parse(item[5].ToString());
            lista.Add(cad);
        }
        public static void Remove(int ID)
        {
            foreach (var rem in selectAll())
            {
                if (rem.Id == ID)
                {
                    lista.Remove(rem);
                }
            }
        }
        public static void Drop()
        {
            lista.Clear();
        }
        public static List<Cardapio> selectAll()
        {
            return lista;
        }
    }
}
