using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1: Initialisiere 2 Zahlen und gebe die Summe auf der Console aus
            //Aufgabe 2: Lasse den Nutzer zwei Zahlen eingeben und gebe die Summe auf der Console aus
            //Aufgabe 3: Lasse den Nutzer eine Zahl eingeben und gebe alle Zahlen
            //           bis einschließlich der eingegeben Zahl aus
            //Aufgabe 4: Lasse den Nutzer eine Zahl eingeben und gebe nur die geraden Zahlen aus.
            //           (Hinweis: Modulo operator. => Geteilt durch 2,
            //                  wenn der Rest 0 ist, ist die Zahl gerade)
            //Aufgabe 5: Lasse den Nutzer eine Zahl eingeben und berechne von dieser Zahl die Fakultät.
            //Aufgabe 6a: Lasse den Nutzer einen Text eingeben und gebe den Text nur in Großbuchstaben aus
            //Aufgabe 6b: Gebe die Länge des Textes aus
            //Aufgabe 6c: Zähle wie oft der Buchstabe a vorkommt.
            //Aufgabe 6d: Gebe nur einen Teil des Textes aus. Ab Position 3, und dann die nächsten 5 Buchstaben

            //A5
            Console.WriteLine("Gebe eine Zahlen an: ");
            int eingabe = Convert.ToInt16(Console.ReadLine());

            int zaehler = 1;
            long ergebnis = 1;

            while(zaehler <= eingabe)
            {
                ergebnis *= zaehler;
                Console.WriteLine($"* {zaehler}");
                zaehler++;
            }
            
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");

        }
    }
}