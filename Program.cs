using System.Globalization;
using System.Net;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Passe die Methode "Fahren" so an, dass 
            //- bei einer Geschwindigkeit von 0 die Methode "steht" zurück gibt: Hinweis: return
            //- bei einer Geschwindigkeit von 1-10 "schleicht" zurück gibt
            //- bei einer Geschwindigkeit von 11-50 "fährt langsam" zurück gibt
            //- bei einer Geschwindigkeit von 51-100 "fährt schnell" zurück gibt
            //- bei einer Geschwindigkeit über 100 "rast" zurück gibt.

            //Bau die Ausgabe so, dass nach jedem Aufruf folgende Texte ausgegeben werden können. 
            //Das Auto steht.
            //Das Auto schleicht.
            //Das Auto fährt langsam.
            //Das Auto fährt schnell. 
            //Das Auto rast.
            */
        
            Console.WriteLine("Gebe deine Geschwindigkeit an!");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            string ergebnis = Fahren(eingabe);
            Console.WriteLine($"Das Auto {ergebnis}");
        }

        static string Fahren(int geschwindigkeit)
        {
            if(geschwindigkeit==0)
            {
                return "steht.";
            }
            else if(geschwindigkeit>0 && geschwindigkeit<11)
            {
                return "schleicht.";
            }
            else if(geschwindigkeit>10 && geschwindigkeit<51)
            {
                return "fährt langsam.";
            }
            else if(geschwindigkeit>50 && geschwindigkeit<101)
            {
                return "fährt schnell.";
            }
            else if(geschwindigkeit>100)
            {
                return "rast.";
            }
            else
            {
                return "Gibt's nicht!";
            }
        }
    }
}