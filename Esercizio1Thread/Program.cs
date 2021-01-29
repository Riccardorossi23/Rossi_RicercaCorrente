using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercizio1Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            RiempiArray(ref array);
            Console.WriteLine("Inserisci numero da cercare");
            int n = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => RicercaNumero(n, array));
            thread.Start();
            Console.WriteLine("Inserisci un numero da cercare:");
            int n1 = int.Parse(Console.ReadLine());
            RicercaNumero(n1,array);


            Console.ReadLine();
        }
        public static void RicercaNumero(int n, int[] array)
        {
            for (int i = 0; i < 100; i++)
            {
                if (n == array[i])
                {
                    Console.WriteLine($"Trovato {array[i]} in posizione {i}");
                }
            
            }

        }
        static void RiempiArray(ref int[] array)
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                array[i] = r.Next(0, 100);

            }

        }
    }
}
    