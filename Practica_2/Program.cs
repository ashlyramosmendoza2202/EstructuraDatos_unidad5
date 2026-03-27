using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        pila.Push(1);
        pila.Push(2);
        pila.Push(3);

        while (pila.Count > 0)
        {
            pila.Pop();
        }

        Console.WriteLine("La pila está vacía: " + (pila.Count == 0));

        Console.ReadLine();
    }
}