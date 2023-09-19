using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Erstelle ein Array mit folgenden Zahlen [20,50,11,2,49]
                Gebe die Werte innerhalb des Arrays nacheinander aus
                Gebe die Werte innerhalb des Arrays rückwärts aus
                Gebe die Werte in einer sortierten Reihenfolge aus ([20,50,11,2,49] => [2,11,20,49,50]) (Sort Ascending)
                Gebe die Werte in einer sortierten Reihenfolge rückwärts aus ([20,50,11,2,49] => [50,49,20,11,2]) (Sort Descending)
            */

            int[] myArray = {20,50,11,2,49};

            Console.WriteLine("Ausgabe nacheinander");
            for(int i=0; i<myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            /*
            Console.WriteLine("Ausgabe nacheinander mit FOREACH");
            foreach(int x in myArray)
            {
                Console.WriteLine(x);
            }
            */

            Console.WriteLine("Ausgabe rückwärts");
            for(int i=myArray.Length-1; i>=0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            
            Array.Sort(myArray);
            Console.WriteLine("Ausgabe sortiert nacheinander");
            for(int i=0;i<myArray.Length;i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("Ausgabe sortiert rückwärts");
            for(int i=myArray.Length-1; i>=0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            
        }
    }
}