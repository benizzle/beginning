using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nutzer soll Zahl eingeben. Anzahl an Sekunden
            //In Tage Stunden Minuten Sekunden konvertieren
            //90.061 = 1 tag 1 stunde 1 minute 1 sekunde 86400

            Console.WriteLine("Gebe eine Zahl ein!");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            int tag = eingabe / 86400;
            int stunde = (eingabe / 3600) - tag;
            int minute = (eingabe / 60) - (stunde*60);
            int sekunde = eingabe % 60;

            Console.WriteLine($"Ergebnis: {tag} Tage {stunde} Stunden {minute} Minuten und {sekunde} Sekunden");
        }
    }
}