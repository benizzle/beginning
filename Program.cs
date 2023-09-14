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

            //Aufgabe 7: Frage den Nutzer nach einem Text und ersetze im Text alle vorkommenden „U“ und „u“ durch „G“ und „g“
            //Aufgabe 8: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 20 Stellen mit einem y von links auf
            //Aufgabe 9: Frage den Nutzer nach einer Eingabe mit Semikolons ( ; ) und Splitte die Eingabe an diesem Zeichen. Gebe die einzelnen Werte auf der Console aus.
            //Aufgabe 10: Frage den Nutzer nach einer Eingabe und überprüfe die Texteingabe des Nutzers, ob die Zeichen „abc“ in der Eingabe enthalten sind. Gebe true oder false auf der Konsole aus.
            
            //A7

            Console.WriteLine("Schreibe einen tollen Text!");
            string eingabe = Console.ReadLine();


            string ergebnis = eingabe.Replace('U', 'G');
            ergebnis = ergebnis.Replace('u', 'g');

            Console.WriteLine($"Ergebnis: {ergebnis}");
        }
    }
}