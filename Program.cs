using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //// Stack erstellen
        Stack<int> mystackname = new Stack<int>();
        mystackname.Push(100);
        mystackname.Push(22);
        mystackname.Push(34); /// Last in, first out
        
        //// Oberste Nummer anzeigen (Peek)
        Console.WriteLine("Top Number: " + mystackname.Peek()); /// 34
        
        /// Element entfernen (Pop)
        Console.WriteLine("Remove Number: " + mystackname.Pop()); /// 34 removed
        
        /// Die restliche Nummern anzeigen
        Console.WriteLine("Next Number: " + mystackname.Peek()); /// now 22
        
        /// Alle Elemente ausgeben
        Console.WriteLine("Inhalt des Stacks; ");
        foreach (int number in mystackname)
            {
            Console.WriteLine(number);
            }
    }
}