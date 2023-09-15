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

            string a = "30";
            string b = "20";

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

        static int AdditionWithReturn(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);

            return numero1 + numero2;
        }
        static void Addition(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 + zahl2);
        }
        static void Addition(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 + numero2);
        }

        static void Subtract(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 - zahl2);
        }
        static void Subtract(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 - numero2);
        }

        static void Multiply(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 * zahl2);
        }
        static void Multiply(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 * numero2);
        }

        static void Division(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 / zahl2);
        }
        static void Division(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 / numero2);
        }
    }
}