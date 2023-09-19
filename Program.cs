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
            
            Console.WriteLine("Gebe einen Text ein und trenne mit ';'");
            string eingabe = Console.ReadLine();

            string[] myArray = eingabe.Split(';');
            
            //besser
            foreach(string c in myArray)
            {
                Console.WriteLine(c);
            }

            //oder
            for(int index=0; index < myArray.Length; index++)
            {
                Console.WriteLine(myArray[index]);
            }

        }
    }
}