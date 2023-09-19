using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() {11,22,33,44,55,66};

            int summeFromMethod = Sum(myList);

            Console.WriteLine("Summe: " + summeFromMethod);

        }

        static int Sum(List<int> myList)
        {
            int summe = 0;
            foreach(int x in myList)
            {
                summe += x;
            }
            return summe;
        }

        
    }
}