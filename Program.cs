using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Das ist ein Text";
            Console.WriteLine(text);
            int zahl = 21;
            Console.WriteLine(zahl);
            double kommazahl = 21.3;
            Console.WriteLine(kommazahl);
            float weitereFlieskommaZahl = 21.333F;
            Console.WriteLine(weitereFlieskommaZahl);
            decimal flieskomma = 24.4M;
            Console.WriteLine(flieskomma);
            
            bool wahrheitswert = true;
            Console.WriteLine(wahrheitswert);
            bool anders = false;
            Console.WriteLine(anders);
            
            char buchstabe = (char)48;
            Console.WriteLine(buchstabe);

            //ASCII Chart 48 = 0
            long langezahl = 123456753156456456;
            Console.WriteLine(langezahl);
            short kurzezahl = 30000;
            Console.WriteLine(kurzezahl);

            uint positivezahl = 123;
            Console.WriteLine(positivezahl);

            
            string[] myArray = new string[10];
            myArray[0] = "erster Wert";
            myArray[9] = "letzter Wert";

            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[9]);

            List<string> myList = new List<string>();
            
            myList.Add("Benni");

            Console.WriteLine(myList[0]);

        }
    }
}