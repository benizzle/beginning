﻿using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 11: Frage den Nutzer nach einer Zahl und zähle von dieser Rückwärts bis 0
            //Aufgabe 12: Laufe mit einer For-Schleife über die Namen der Azubis & Studenten. Wenn der Name des Azubis ein „e“ enthält, gebe den Namen aus, ansonsten nicht.
            //Aufgabe 12b: Wiederhole das Ganze und lass den Nutzer einen Buchstaben bestimmen, nach dem gesucht wird.
            //Aufgabe 13: Frage den Nutzer  wie viele Einträge er in einem int-Array haben möchte. Initialisiere ein int-Array von dieser Größe und befülle dieses Int Array in einer Schleife, 
            //              indem du den Nutzer jedes Mal frägst, welche Zahl eingetragen werden soll.  
            //              Gebe anschließend alle Zahlen nacheinander nochmal aus
            //Aufgabe 13b: Gehe das Int-array durch und gebe den Maximal-Wert aus, Minimal-Wert und den Durchschnitt.

            //A13

            Console.WriteLine("Wie groß soll dein int-Array sein?");
            int numm = Convert.ToInt16(Console.ReadLine());

            int[] myarray = new int[]{};

            for(int i=0; i < numm; i++)
            {
                Console.WriteLine("Nenne eine weiter Zahl zum füllen!");
                int next = Convert.ToInt32(Console.ReadLine());
                myarray[i] = next;
            }


            

            
        }
    }
}