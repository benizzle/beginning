using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Willst du addieren [+] oder subtrahieren [-]?");
            string eingabe = Console.ReadLine();

            int a = 30;
            int b = 20;
            int e = 0;

            if(eingabe == "+" || eingabe == "addieren")
            {
                e = a + b;
                Console.WriteLine($"Ergebnis: {a} + {b} = {e}");
            }
            if(eingabe == "-" || eingabe == "subtrahieren")
            {
                e = a - b;
                Console.WriteLine($"Ergebnis: {a} - {b} = {e}");
            }
                
        }
    }
}