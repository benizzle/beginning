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
            //Erstelle ein array das Zahlen beinhaltet
            //Es sollen 5 Zahlen eingegeben werden können
            //Befülle das Array in einer Schleife durch den Nutzer
            //Gebe am Ende die:
            //  - die kleinste Zahl aus
            //  - die größte Zahl 
            //  - den Durchschnitt

            int zahl = 5;

            int[] arr = new int[zahl];

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"Befülle Feld {i+1} von {zahl}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Welche Zahl willst du ausgeben? Kleinste, Groesste oder den Durchschnitt?");
            string txt = Console.ReadLine();
            if(txt == "Kleinste")
            {
                Console.WriteLine(arr.Min());
            }
            else if(txt == "Groesste")
            {
                Console.WriteLine(arr.Max());
            }
            else if(txt == "Durchschnitt")
            {
                Console.WriteLine(arr.Average());
            }

        }
    }
}