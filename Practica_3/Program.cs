using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        pila.Push(5);
        pila.Push(10);
        pila.Push(15);

        pila.Pop();
        pila.Pop();

        Console.WriteLine("Estado final de la pila:");

        foreach (int num in pila)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}
