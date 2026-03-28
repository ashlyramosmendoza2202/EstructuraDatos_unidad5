using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> cola = new Queue<int>();

        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        int suma = 0;

        foreach (int num in cola)
        {
            suma = suma + num;
        }

        Console.WriteLine("La suma es: " + suma);

        Console.ReadLine();
    }
}