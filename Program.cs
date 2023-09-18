using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wiederholung
            //Lasse vom Nutzer einen Text eingeben und gebe folgende Punkte aus
            //- Länge des Textes
            //- Anzahl  wie oft Buchstabe h auftaucht            

            Console.WriteLine("Gebe mir einen Text");
            string eingegebenerText = Console.ReadLine();
            int laengetext = eingegebenerText.Length;
            Console.WriteLine("Die Länge des Textes ist " + laengetext);
            
            //Möglichkeit 1
            //string[] splittedText = eingegebenerText.Split("h");
            
            //Möglichkeit 2
            int count = 0;
            for(int i = 0;i< eingegebenerText.Length;i++)
            {
                if(eingegebenerText[i] == 'h')
                {
                    count++;
                }
            }
            Console.WriteLine($"Es gibt {count} h's in deinem Text.");
           //Möglichkeit 2b
           foreach(char c in eingegebenerText)
           {
                if(c == 'h')
                {
                    count++;
                }
           }

           //Möglichkeit
           int numberofh = eingegebenerText.Count(c => c == 'h');
           Console.WriteLine($"Es gibt {numberofh} h's in deinem Text.");
        }
    }
}