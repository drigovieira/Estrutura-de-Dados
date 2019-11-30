using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class ListCardapio
    {
        private static List<Cardapio> cardapio = new List<Cardapio>();

        public static void CardapioAdd(Cardapio dados)
        {
            Cardapio car = new Cardapio();
            car.Nome = dados.Nome;
            car.Categoria = dados.Categoria;
            car.Preco = dados.Preco;
            car.Qtd = dados.Qtd;
            car.Ingredientes = dados.Ingredientes;
            car.Image = dados.Image;
            car.Status = true;           
            cardapio.Add(car);
            cardapio[cardapio.IndexOf(car)].Id = cardapio.IndexOf(car);
        }
        public static Cardapio select(int index)
        {
            Cardapio lista = new Cardapio();
            foreach (var item in cardapio)
            {
                if (cardapio.IndexOf(item) == index)
                {
                    lista = item;
                }
            }
            return lista;
        }
        public static List<Cardapio> selectAll()
        {
            return cardapio;
        }
        public static List<Cardapio> searchName(string name)
        {
            List<Cardapio> lista = new List<Cardapio>();
            foreach(var item in cardapio)
            {
                if (item.Nome.ToLower().Contains(name.ToLower()))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
        public static void alter(Cardapio dados)
        {
            foreach(var items in cardapio)
            {
                
            }
        }
        public static void Delete(int index)
        {
            foreach(var item in cardapio)
            {
                if (cardapio.IndexOf(item) == index)
                {
                    cardapio.RemoveAt(index);
                }
            }
        }
        public static void Disable(int Id)
        {
            Cardapio car = new Cardapio();
            foreach(var item in cardapio)
            {
                if(cardapio.IndexOf(item) == Id)
                {
                    car.Status = false;
                }
            }
        }
    }
}
