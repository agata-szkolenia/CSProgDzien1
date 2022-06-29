using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZmienneITypyDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int liczbaCałkowita;
            //liczbaCałkowita = 100;

            // komentarz do końca linii
            /*
             * komentarz
             * wielolinijkowy
             */ 

            int liczbaCalkowita = 100; // komentarz

            //01101101 -> 0*128+1*64+1*32+0*16+1*8+1*4+0*2+1*1=109

            //12.34567  0.000000001234567 12345670000000000000000000.0
            float malaZmiennoprzecinkowa;
            double sredniaZmiennoprezecinkowa;
            decimal duzaZmiennoprzecinkowa;

            liczbaCalkowita = 123_456_890; // system dziesiętny
            liczbaCalkowita = 0xFF; // ==255 system szestnastkowy
            liczbaCalkowita = 0b_01101101; // ==109 system binarny

            malaZmiennoprzecinkowa = 1.2f; //1.2F
            sredniaZmiennoprezecinkowa = 1.2d; //1.2D
            duzaZmiennoprzecinkowa = 1.2m; //1.2M

            // zakres widoczności zmiennych
            // w obrębie klamer {} w których została zadeklarowana
            // 

            string napis = "Ala ma kota";
            char znak = 'K';
            //'\n' '\t' '\\' znaki specjalne enter, tabulator, \

            bool wartoscLogiczna = true; // false
        }
        
    }
}
