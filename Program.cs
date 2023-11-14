using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_nizovi_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Koliko brojeva zelite ");
            int x = Convert.ToInt32(Console.ReadLine());
            int br = 0;
            int[] niz1 = new int[x];
            int[] niz2 = new int[x];
            int call = 0;
            Console.WriteLine("\nPolje 1");
            for (int i = 0; i < x; i++)
            {
                {
                    Console.Write((i + 1) );
                    niz1[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nPolje 2");
            for (int i = 0; i < x; i++)
            {
                    Console.Write((i + 1));
                    niz2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < x; i++)
            {
                {
                    if (niz1[i] == niz2[i])
                    {
                        br++;
                    }
                }
            }
            Console.WriteLine("\n" + br + " Input ima istu vrijednost");
            Console.ReadKey();
        }
    }
}