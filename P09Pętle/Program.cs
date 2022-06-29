using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Pętle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            // for - pętla przydatna kiedy wiem dokładnie ile razy ma się wykonać
            //for (i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine($"kolejny obrót pętli for {i}");
            //}
            //Console.WriteLine($"Po wyjściu z pętli zmienna sterująca ma wartość {i}");

            // zadanie: wypisz liczby parzyste od 0 do 100
            //for (i = 0; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            // zadanie: tabliczka mnożenia
            // Console.WriteLine();  <- tylko enter
            // Console.Write('\n');  <- tylko enter
            for (i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"\t{i*j}");
                }
                Console.WriteLine();
            }
            // zadanie do domu: wypisać macierz 10x10 jednostkową (jednynki na przekątnej)

            // while - elastyczna, bardziej wymagająca od programisty (można łatwo wpaść w nieskończoną pętlę)
            
            i = 0; //ustaw środowisko przed wejściem do pętli
            while (i<10) // sprawdź warunek wejścia
            {
                //coś rób
                Console.WriteLine($"kolejny obrót pętli for {i}");
                
                i++; //zmieniaj zmienną sterującą
            }

            // czekaj na literę 'a' od użytkownika
            bool zakończ = false;
            char znak;
            while (!zakończ)
            {
                znak = Console.ReadKey().KeyChar;  // jak wydobyć znak z ReadKey()
                zakończ = znak == 'a';
            }

            // zadanie:
            // wypisuj kolejne potęgi 2 aż przekroczysz milion
            Console.WriteLine("\n\nWypisuj kolejne potęgi 2 aż przekroczysz milion");
            i = 1;
            while (i < 1E6)
            {
                Console.WriteLine(i);
                i *= 2;
            }
            Console.WriteLine(i);

            // pętla która na pewno wykona się co najmniej 1 raz
            // warunek jest sprawdzany po wykonaniu bloku kodu
            i = 1;
            do
            {
                Console.WriteLine(i);
                i *= 2;
            } while (i < 1E6);
            Console.WriteLine(i);

            // break - wyjście z pętli
            // continue - przerywa ten jeden obrót pętli i wraca do nagłówka

            for (i = 0; i < 10; i++)
            {
                if (i % 3 == 0) continue;
                Console.WriteLine(i);
            }

            while (true)
            {
                if (Console.ReadKey().KeyChar == 'a') break;
            }

            Console.WriteLine("\nPress any key to continue....");
            Console.ReadKey();
        }
    }
}
