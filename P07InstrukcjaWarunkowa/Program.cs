using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjaWarunkowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            // najprostsza forma
            if (3>a)
            {
                Console.WriteLine("Coś poszło nie tak :(");
            }

            // pełna forma
            if (3>a)
            {
                Console.WriteLine("blok if - warunek wejściowy spełniony");
                a++;
            }
            else
            {
                Console.WriteLine("blok else - warunek wejściowy niespełniony");
                a--;
            };

            // jedyna słuszna forma zagnieżdżania if
            if (a>4)
            {
                Console.WriteLine("pierwszy blok");
            }
            else if (a < -10)
            {
                Console.WriteLine("drugi blok");
            }
            else if (a == 0)
            {
                Console.WriteLine("trzeci blok");
            }
            else
            {
                Console.WriteLine("cała reszta przypadków");
            }

            a = (a < 10) ? 5 : 7;  // operator zwracający wartość 5 lub 7 w zależności czy a<10 czy nie
            if (a < 10)
                a = 5;
            else
                a = 7;

            switch (a) 
            {
                case 20: // jeśli a=20 to wykonaj pierwszy blok kodu (do break)
                    Console.WriteLine("poniedziałak");
                    Console.WriteLine("tralala");
                    break;
                case -17: // jeśli a=-17 to wykonaj drugi blok kodu (do break)
                    Console.WriteLine("wtorek"); 
                    break;
                default: // wszystkie inne przypadki, default nie jest obowiązkowy
                    Console.WriteLine("nie wiem"); 
                    break;
            }

            Console.WriteLine("Dalsza częśc programu");
            Console.ReadKey();
        }
    }
}
