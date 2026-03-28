using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> cola = new Queue<int>();

        cola.Enqueue(1);
        cola.Enqueue(2);
        cola.Enqueue(3);
        cola.Enqueue(4);
        cola.Enqueue(5);

        Console.WriteLine("Contenido de la cola:");

        foreach (int num in cola)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}