using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fila> fila = new List<Fila>();
            fila.Add(new Fila(11, false));
            fila.Add(new Fila(7, true));
            fila.Add(new Fila(8, false));
            fila.Add(new Fila(5, false));
            fila.Add(new Fila(3, false));
            fila.Add(new Fila(4, false));
            fila.Add(new Fila(10,true));

            Console.WriteLine("List before Sort: [{0} ", String.Join("];", fila.Select(c=> $"Position: {c.Position}, Preferencial: {c.IsPrefencial}")));
            Sort(fila);
            Console.WriteLine("List after Sort: [{0} ", String.Join("];", fila.Select(c => $"Position: {c.Position}, Preferencial: {c.IsPrefencial}")));

            }

        static List<Fila> Sort(List<Fila> lista, int i = 0)
        {

            if (i > 0)
            {
                if ((lista[i].IsPrefencial && !lista[i - 1].IsPrefencial && i < lista.Count()) || (lista[i].Position > lista[i-1].Position && lista[i].IsPrefencial && lista[i-1].IsPrefencial))
                {
                    var current = new Fila(lista[i - 1].Position, lista[i - 1].IsPrefencial);
                    lista[i - 1] = lista[i];
                    lista[i] = current;

                    i -= 1;
                }
                else if (i + 1 == lista.Count())
                    return lista;
                else
                {
                    if ((lista[i + 1].Position > lista[i].Position && !lista[i + 1].IsPrefencial && !lista[i].IsPrefencial && i > 0) ||

                           (lista[i + 1].Position > lista[i].Position && lista[i + 1].IsPrefencial && lista[i].IsPrefencial && i > 0))
                    {
                        var current = new Fila(lista[i].Position, lista[i].IsPrefencial);
                        lista[i] = lista[i + 1];
                        lista[i + 1] = current;
                        i -= 1;
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }
            else
            {
                i += 1;
            }
            return Sort(lista, i);
        }        
    }
    public class Fila
    {
        public Fila(int position, bool isPrefencial)
        {
            Position = position;
            IsPrefencial = isPrefencial;
        }

        public int Position { get; set; }

        public bool IsPrefencial { get; set; }
    }
}
