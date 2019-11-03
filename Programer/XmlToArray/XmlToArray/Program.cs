using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long[]> likes = new List<long[]>();

            string txt = "1,2*3,4*5,6";
            string[] user = txt.Split('*');

            foreach (var item in user)
            {
                string[] v = item.Split(',');

                long[] uu = {long.Parse(v[0]), long.Parse(v[1])};
                likes.Add(uu);
            }

            foreach (var item in likes)
            {
                Console.WriteLine("cpf " + item[0]);
                Console.WriteLine("like " + item[1]);
            }
            

           
          





            Console.ReadLine();
        }
    }
}
