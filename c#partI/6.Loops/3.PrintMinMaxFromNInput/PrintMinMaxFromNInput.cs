//Write a program that reads from the console a sequence
//of N integer numbers and returns the minimal and maximal of them.

using System;

class PrintMinMaxFromNInput
{
    static void Main()
    {
        int N,min,max,next;
        min = max = next = 0;
        Console.WriteLine("Give N numbers.I'll give their MAX and MIN.");
        do
        {
            Console.WriteLine("Integer N:");
        } while (!int.TryParse(Console.ReadLine(), out N));
        for (int i = 0; i < N; i++)
        {
            do
            {
                Console.WriteLine("Integer[{0}]",i+1);
            } while (!int.TryParse(Console.ReadLine(), out next)); ;

            if (i == 0) 
            {
                min = max = next;
            }
            if (next > max)
            {
                max = next;
            }
            else 
            {
                if (next < min) 
                {
                    min = next;
                }
            }
        
        }
        Console.WriteLine("Min: {0}, MAX: {1}",min,max);
    }
}