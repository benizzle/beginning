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

            float zahl1 = 24.2314f;
            float zahl2 = 1.12222223262313f;
            float ergebnis = zahl1 + zahl2;

            Console.WriteLine($"Mein Ergebnis ist {zahl1} + {zahl2} = {ergebnis}");


            int x,y,z;
            x = y = z = 50;

            Console.WriteLine(x + y + z);


            int ganzZahl = 0;
            double myDouble = 5.5;
            Console.WriteLine(myDouble);
            ganzZahl = (int)myDouble;
            Console.WriteLine(ganzZahl);
        }
    }
}