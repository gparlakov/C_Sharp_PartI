//Write a program that prints all the numbers from 1 to N

using System;

class Print1ToN
{
    static void Main()
    {
        int N;
        do
        {
            Console.WriteLine("Integer N:");
        } while (!int.TryParse(Console.ReadLine(), out N));
        Console.WriteLine("Numbers from 1 to {0}:", N);
        for (int i = 1; i <= N; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }
}