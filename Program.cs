using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Aufgabe: Fizz-Buzz-Spiel

            Schreibe ein Programm, das eine Zahlenfolge von 1 bis zu einer vom Benutzer festgelegten Obergrenze ausgibt. Dabei gelten folgende Regeln:
            Wenn die Zahl durch 3 teilbar ist, gib "Fizz" aus anstelle der Zahl.
            Wenn die Zahl durch 5 teilbar ist, gib "Buzz" aus anstelle der Zahl.
            Wenn die Zahl sowohl durch 3 als auch durch 5 teilbar ist, gib "FizzBuzz" aus anstelle der Zahl.
            In allen anderen Fällen gib einfach die Zahl selbst aus.
            Hier sind einige Beispiele:
            Wenn die Obergrenze 15 ist, sollte die Ausgabe wie folgt aussehen:
            Deine Aufgabe besteht darin, den Code zu schreiben, der diese Regeln befolgt und die Zahlenfolge bis zur vom Benutzer festgelegten Obergrenze ausgibt. Viel Erfolg!
            */
            
            Console.WriteLine("Nenne eine Zahl!");
            int eingabe = Convert.ToInt16(Console.ReadLine());

            for(int i=2;i<=eingabe;i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            
        }
    }
}