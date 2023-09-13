namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frage den Nutzer nach der ersten Zahl
            Console.WriteLine("Nenne eine Zahl!");
            string zahl1 = Console.ReadLine();
            
            //Fragen den Nutzer nach der zweiten Zahl
            Console.WriteLine("Nenne eine Zahl die du von " + zahl1 + " subtrahieren willst!");
            string zahl2 = Console.ReadLine();

            int ergebnis = Convert.ToInt16(zahl1) - Convert.ToInt16(zahl2);            
  
            //Gebe das Ergebnis auf der Console aus SUBTRAKTION
            Console.WriteLine($"Dein Ergbnis: {zahl1} - {zahl2} = {ergebnis}");
        }
    }
}