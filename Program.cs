namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frage den Nutzer nach der ersten Zahl
            Console.WriteLine("Nenne eine Zahl:");
            string ersteZahl = Console.ReadLine();

            //Fragen den Nutzer nach der zweiten Zahl
            Console.WriteLine("Nenne eine weitere Zahl:");
            string zweiteZahl = Console.ReadLine();
            
            int zahl1 = Convert.ToInt16(ersteZahl);
            int zahl2 = Convert.ToInt16(zweiteZahl);
            int ergebnis = zahl1 + zahl2;

            //Gebe das Ergebnis auf der Console aus
            Console.WriteLine($"Das Ergebnis ist: {zahl1} + {zahl2} = {ergebnis}");
        }
    }
}