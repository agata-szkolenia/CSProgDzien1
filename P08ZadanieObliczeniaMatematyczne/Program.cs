using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieObliczeniaMatematyczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz działanie. możesz użyć jednego z operatorów + - * / %");
            string dzialanie = Console.ReadLine();

            char op ;
            if (dzialanie.Contains('+'))
                op = '+';
            else if (dzialanie.Contains('-'))
                op = '-';
            else if (dzialanie.Contains('*'))
                op = '*';
            else if (dzialanie.Contains('/'))
                op = '/';
            else if (dzialanie.Contains('%'))
                op = '%';
            else
            {
                Console.WriteLine("Nierozpoznany operator ");
                return;
            }

            int pozPodz = dzialanie.IndexOf(op);

            int liczba1 = Convert.ToInt32(dzialanie.Substring(0, pozPodz));
            int liczba2 = Convert.ToInt32(dzialanie.Substring(pozPodz + 1));

            int wynik;
            switch (op)
            {
                case '+': wynik = liczba1 + liczba2; break;
                case '-': wynik = liczba1 - liczba2; break;
                case '*': wynik = liczba1 * liczba2; break;
                case '/': wynik = liczba1 / liczba2; break;
                case '%': wynik = liczba1 % liczba2; break;
                default:
                    {
                        Console.WriteLine("Coś poszło nie tak");
                        return;
                    }
            }
            Console.WriteLine($"Wynik działania to {wynik}");
            Console.ReadKey();
        }
        
    }
}
