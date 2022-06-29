using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imie:");
            string napis = Console.ReadLine();

            Console.WriteLine("Witaj " + napis);
            Console.WriteLine("Twoje imie ma długość: " + napis.Length.ToString());
            Console.WriteLine("Po śląsku nazywasz się: " + napis.Replace('a', 'o'));
            Console.WriteLine("Twój tajny nick to:" + napis.ToUpper());

            napis = napis.Replace('a', 'o');

            Console.WriteLine("Ile masz lat?");
            int wiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Urodziłeś/aś się w roku: " + (2022-wiek));

            // stringi z dolarem -> notacja nawiasowa
            // w nawiasach {} można wykonywać dowolne obliczenia
            Console.WriteLine($"Rok urodzenia: {2022-wiek}, a długość imienia: {napis.Length}");

            Console.ReadKey();

        }
    }
}
