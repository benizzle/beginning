using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int myNum = 9;
            double myDoubleNum = 8.99;
            char myLetter = 'A';
            bool myBoolean = false;
            string myText = "Hello World";
            */

            /*
            float zahl1 = 24.2314f;
            float zahl2 = 1.12222223262313f;
            float ergebnis = zahl1 + zahl2;

            Console.WriteLine($"Mein Ergebnis ist {zahl1} + {zahl2} = {ergebnis}");


            int x,y,z;
            x = y = z = 50;

            Console.WriteLine(x + y + z);
            */

            /*
            int ganzZahl = 0;
            double myDouble = 5.5;
            Console.WriteLine(myDouble);
            ganzZahl = (int)myDouble;
            Console.WriteLine(ganzZahl);

            
            double doubleZahl = 3.56666665647383857;
            float floatZahl = 0;
            Console.WriteLine(doubleZahl);
            floatZahl = float(doubleZahl);
            Console.WriteLine(doubleZahl);
            */

            /*
            int zahl1 = 50;
            int zahl2 = 100;

            int ergebnis1 = zahl1 + zahl2;
            int ergebnis2 = zahl1 - zahl2;

            int ergebnis3 = zahl1 * zahl2;
            int ergebnis4 = zahl1 / zahl2;

            int ergebnis5 = zahl1 % zahl2;

            zahl1++;

            zahl2--;

            zahl1 += 10;
            */

            int zahl1 = 50;
            int zahl2 = 30;
            int zahl3 = 200;

            int ergebnis1 = zahl2 + zahl1;
            Console.WriteLine(ergebnis1);
            
            // ++ vor Variable erhöht zuerst und ++ nach Zahl wird erst zugewiesen und dann erhöht
            int ergebnis2 = ++zahl1;
            Console.WriteLine(ergebnis2);

            int ergebnis3 = zahl1 % zahl2;
            Console.WriteLine(ergebnis3);

            int ergebnis4 = zahl3 % zahl1;
            Console.WriteLine(ergebnis4);

            int ergebnis5 = zahl2 + zahl2 * 2;
            Console.WriteLine(ergebnis5);

            int ergebnis6 = (zahl2 + zahl2) * 2;
            Console.WriteLine(ergebnis6);

            double double1 = 50.50;
            double double2 = 30.30;

            double doubleergebnis = double1 / double2;
            Console.WriteLine(doubleergebnis);

            float float1 = 50.50f;
            float float2 = 30.30f;

            double floatergebnis = float1 / float2;
            Console.WriteLine(floatergebnis);

        }
    }
}