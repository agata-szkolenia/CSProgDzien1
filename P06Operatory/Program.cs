using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * / + -
            // % modulo czyli reszta z dzielenia

            int a = 10;
            int b = 3;
            Console.WriteLine(a/b);
            Console.WriteLine(10.0/3);
            Console.WriteLine(10 % 3);

            a++;
            ++a;
            a--;
            --a;

            a = 10;
            Console.WriteLine(a++); //najpierw oddaj wartość a potem je zwiększ o 1
            a = 10;
            Console.WriteLine(++a); // najpierw a zwiększ o 1 a dopiero potem oddaj wartość 

            // dwie poniższe linie są dokładnie równoważne
            a = a + 20;
            a += 20;

            // bool
            // < <= > >= == !=     
            Console.WriteLine(1 < 2);

            // łączenie warunków (operatory w kolejności wykonywania):
            // negacja          !
            // AND              &
            // XOR              ^    (albo albo, alternatywa wyłączna)
            // OR               |
            // warunkowy AND    &&  (leniwe wyliczanie)
            // warunkowy OR     ||  (leniwe wyliczanie)

            //uwaga na efekty uboczne leniwych operatorów:

            int? x = null;   // 'oszukiwanie', int normalnie jest typem nienullowalnym
            Console.WriteLine(x == null || x > 2 );

            x = 12; // a co jeśli x=7?
            Console.WriteLine(x>10 && x++ <20);
            Console.WriteLine(x);

            // operator konkatenacji
            Console.WriteLine("5" + "4");


            Console.ReadKey();
        }
    }
}
