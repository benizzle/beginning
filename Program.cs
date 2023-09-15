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
            string eingabe = Console.ReadLine();
            }while(eingabe != "+" && eingabe != "-" && eingabe != "*" && eingabe != "/");

            int a = 30;
            int b = 20;
            int e = 0;

            switch(eingabe)
            {
                case "+":
                    Console.WriteLine(a+b);
                    break;
                case "-":
                    Console.WriteLine(a-b);
                    break;
                case "*":
                    Console.WriteLine(a*b);
                    break;
                case "/":
                    Console.WriteLine(a/b);
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

        static void Multiplication(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 * zahl2);
        }

        static void Division(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 / zahl2);
        }
    
    }
}