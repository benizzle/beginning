using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string example_text = " This is a test ";

            Console.WriteLine(example_text.ToLower());
            Console.WriteLine(example_text.ToUpper());
            Console.WriteLine(example_text.Trim());
            Console.WriteLine(example_text.Contains(This));
            Console.WriteLine(example_text.CopyTo());
            Console.WriteLine(example_text.Count());
            Console.WriteLine(example_text.EndsWith(" "));
            Console.WriteLine(example_text.Equals(" This is a test "));
            Console.WriteLine(example_text.Insert(5, "ABCD"));
            Console.WriteLine(example_text.OrderBy());
            Console.WriteLine(example_text.PadLeft(30, '_'));
            Console.WriteLine(example_text.Remove(3, 6));
            Console.WriteLine(example_text.Replace('i', 'ä'));
            Console.WriteLine(example_text.Reverse().ToArray());
            Console.WriteLine(example_text.Substring(5, 10));

            int example_number = 56;
            example_number.equals();
            */

            Console.WriteLine("Gebe mir deinen Namen!");
            string name = Console.ReadLine();

            if (name.Length > 10)
            {
                Console.WriteLine("Oh der Name ist aber lang");
            }
            else if (name.Length > 5)
            {
                Console.WriteLine("Der Name ist mittellang");
            }
            else
            {
                Console.WriteLine("Der ist ja kurz");
            }   
        }
    }
}