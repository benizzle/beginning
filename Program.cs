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
            //Frage den Nutzer wie viele Texte er in einem Array speichern will.
            //Initialsiere das Array in der gewünschten größe
            //Lasse den Nutzer das Array nacheinander mit Texten befüllen
            //Gebe die Texte mit mindestens 20 Zeichen aus, fülle den Text mit Leerzeichen auf von links wenn kleiner 

            Console.WriteLine("Wie viele Texte willst du speichern?");
            int gr = Convert.ToInt16(Console.ReadLine());

            string[] arr = new string[gr];
            int i = 0;

            while(i < gr)
            {
                Console.WriteLine("Bitte befüllen!");
                arr[i] = Console.ReadLine();
                i++; 
            }
            
            int z = 0;

            while(z < gr)
            {
                Console.WriteLine(arr[z].PadLeft(20, ' '));
                z++;
            }
        }
    }
}