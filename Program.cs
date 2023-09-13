using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*For Loop - For Schleife
            for(int zaehlvariable=0;zaehlvariable<10;zaehlvariable++)
            {
                Console.WriteLine(zaehlvariable);
            }
            */

            /*For Each
            string[] emails = new string[]
            {
                "ben@tecalliance.net",
                "abc@tecalliance.net",
                "xyz@tecalliance.net"
            };
            foreach(string email in emails)
            {
                Console.WriteLine($"Die Email lautet: {email}");
            }
            for(int position=0;position<emails.Length;position++)
            {
                Console.WriteLine($"Die Email lautet: {emails[position]}");
            }
            */

            //While Bedingung
            List<int> myNumberList = new List<int>();

            Console.WriteLine("Sage mir wie viele Zahlen du in deine Liste hinzufügen möchtest!");
            int amountNumbers = Convert.ToInt32(Console.ReadLine());

            while(myNumberList.Count < amountNumbers)
            {
                Console.WriteLine("Gebe mir eine Zahl");
                myNumberList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //Summiere alle Zahlen auf
            int ergebnis = 0;
            foreach(int zahl in myNumberList)
            {
                ergebnis += zahl;
            }
            Console.WriteLine($"Das Ergebnis ist {ergebnis}");
        }
    }
}