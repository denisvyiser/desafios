using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add(11);
            ints.Add(7);
            ints.Add(8);
            ints.Add(5);
            ints.Add(5);
            ints.Add(4);
            ints.Add(10);

            Console.WriteLine("List before Sort: {0} ", String.Join(";", ints));
            Sort(ints);
            Console.WriteLine("List after Sort: {0} ", String.Join(";", ints));

        }

        static List<int> Sort(List<int> lista, int i = 0)
        {
            if (i + 1 == lista.Count())
                return lista;
            if(lista[i + 1] > lista[i])
            {
                int current = lista[i];
                lista[i] = lista[i + 1];
                lista[i + 1] = current;
                i -= 1;
            }
            else
            {   
                i += 1;
            }
            return Sort(lista, i);
        }

        
    }

}
