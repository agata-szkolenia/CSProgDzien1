using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Napisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "Ala ma kota i ma psa i ma królika";

            Console.WriteLine(napis.Length);  // długość napisu, property, wywołujemy bez nawiasów
            Console.WriteLine(napis + " i świnkę morską też"); // łaczenie napisów +
            Console.WriteLine(napis.ToUpper() + " " + napis.ToLower()); //zmiana wielkości liter

            Console.WriteLine(napis.Substring(5)); // od indeksu 5, do końca (numerujemy od 0)
            Console.WriteLine(napis.Substring(5,3)); // od indeksu 5, 3 znaki

            Console.WriteLine(napis.Contains("ala")); // czy zawiera? (case sensitive)
            Console.WriteLine(napis.IndexOf("ma")); // gdzie znalazł? 
            Console.WriteLine(napis.IndexOf("tyranozaur")); // jeśli nie znajdzie to -1
            Console.WriteLine(napis.Replace("ma","będzie miała"));

            string brzydkiNapis = "    Okoń    dla     Wrocławia    ";
            Console.WriteLine(brzydkiNapis.Trim());  // usuwanie spacji z początku i/lub końca
            Console.WriteLine(brzydkiNapis.Replace("  ", " ")); // kasowanie nadmiaru spacji w środku

            // zadanie:
            // na którym miejscu jest DRUGIE "ma" w napisie?
            int pierwszeWystąpienie = napis.IndexOf("ma");
            Console.WriteLine(napis.IndexOf("ma",pierwszeWystąpienie+1));

            Console.ReadKey();
        }
    }
}
