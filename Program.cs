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
            
            string eingabe = "";

            do{
            Console.WriteLine("Willst du addieren [+], subtrahieren [-], multiplizieren [*] oder dividieren [/]?");
            eingabe = Console.ReadLine();
            }while(eingabe != "+" && eingabe != "-" && eingabe != "*" && eingabe != "/");

            int a = 30;
            int b = 20;

            switch(eingabe)
            {
                case "+":
                    Addition(a,b);
                    break;
                case "-":
                    Subtract(a,b);
                    break;
                case "*":
                    Multiply(a,b);
                    break;
                case "/":
                    Division(a,b);
                    break;
                default:
                    Console.WriteLine("Ich kenne diesen Befehl nicht!");
                    break;
            }

        }
        static void Addition(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 + zahl2);
        }

        static void Subtract(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 - zahl2);
        }

        static void Multiply(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 * zahl2);
        }

        static void Division(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 / zahl2);
        }
    }
}