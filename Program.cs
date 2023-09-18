using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "MissiSsiPpi";
            Console.WriteLine($"Vorkommnisse zählen bei {word}");

            int countm = word.Count(c => c == 'm' || c == 'M');
            int counti = word.Count(c => c == 'i' || c == 'I');
            int counts = word.Count(c => c == 's' || c == 'S');
            int countp = word.Count(c => c == 'p' || c == 'P');

            Console.WriteLine($"m und M: {countm}");
            Console.WriteLine($"i und I: {counti}");
            Console.WriteLine($"s und S: {counts}");
            Console.WriteLine($"p und P: {countp}");
        }
    }
}