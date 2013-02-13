//Write a program that prints all the numbers from
//1 to N, that are not divisible by 3 and 7 at the same time.

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
        Console.WriteLine("Numbers from 1 to {0}:",N);
        for (int i = 1; i <= N; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write("{0} ", i);
            }
        }
        
        Console.WriteLine("\nMissing numbers that are devisible by 7 AND 3 are:");
        for (int i = 1; i <= N; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}