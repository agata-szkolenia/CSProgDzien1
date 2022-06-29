using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wersja 1
            Console.WriteLine("Podaj pierwszą liczbę:");
            int liczba1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int wynik = liczba1 + liczba2;
            Console.WriteLine($"Suma tych liczb to: {wynik}, i zajmuje {wynik.ToString().Length} znak/ów/i");


            // wersja 2 
            const char SEP = '/'; //stała, separator
            Console.WriteLine($"Podaj dwie liczby rozdzielone znakiem '{SEP}'");
            string napis = Console.ReadLine();

            // "312/423"
            //  0123456
            //     3   

            liczba1 = Convert.ToInt32(napis.Substring(0,napis.IndexOf(SEP)));
            liczba2 = Convert.ToInt32(napis.Substring(napis.IndexOf(SEP)+1));

            wynik = liczba1 + liczba2;
            Console.WriteLine($"Suma tych liczb to: {wynik}, i zajmuje {wynik.ToString().Length} znak/ów/i");


            Console.ReadKey();

         
        }
    }
}
