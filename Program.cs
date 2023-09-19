using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nutzer soll Zahl eingeben. Anzahl an Sekunden
            //In Tage Stunden Minuten Sekunden konvertieren
            //90.061 = 1 tag 1 stunde 1 minute 1 sekunde
            /*
            Console.WriteLine("Gebe eine Zahl ein!");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            int tage = eingabe / 86400;
            int stunde = (eingabe - (tage*86400)) / 3600;
            int minute = ((eingabe - (tage*86400)) - (stunde*3600)) / 60;
            int sekunde = eingabe % 60;

            Console.WriteLine($"Ergebnis: {tage} Tage {stunde} Stunden {minute} Minuten und {sekunde} Sekunden");
            */

            Console.WriteLine("Gebe eine Zahl ein!");
            int amountSeconds = Convert.ToInt32(Console.ReadLine());

            int amountDays = amountSeconds / 24 / 60 / 60;
            int restSeconds = amountSeconds % (24 * 60 * 60);
            int amountHours = restSeconds / 60 / 60;
            restSeconds = restSeconds % (60 * 60);
            int amountMinutes = restSeconds / 60;
            restSeconds = restSeconds % 60;

            Console.WriteLine($"Ergebnis: {amountDays} Tage {amountHours} Stunden {amountMinutes} Minuten und {restSeconds} Sekunden");
        }
    }
}