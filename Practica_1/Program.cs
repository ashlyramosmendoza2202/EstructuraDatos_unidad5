using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> miPila = new Stack<int>();

        miPila.Push(10);
        miPila.Push(20);
        miPila.Push(30);
        miPila.Push(40);

        Console.WriteLine("Contenido de la pila:");
        foreach (int n in miPila)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();
    }
}