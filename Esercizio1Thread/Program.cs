using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Console.WriteLine("Inserisci numero da cercare");
            int n = int.Parse(Console.ReadLine());

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
                Console.WriteLine("Ricerca Completata");
            }

        }
        static void RiempiArray(int[] numeri)
        {


            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                numeri[i] = r.Next(0, 100);

            }

        }
    }
}
    