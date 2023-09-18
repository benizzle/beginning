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
            Console.WriteLine("Gebe einen Text ein");
            string eingabe = Console.ReadLine();
            
            Console.WriteLine(eingabe.Length);

            string[] splittedText = eingabe.Split('h');


            Console.WriteLine(splittedText.Length - 1);
        }
    }
}