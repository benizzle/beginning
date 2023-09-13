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

            //For Each
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
        }
    }
}