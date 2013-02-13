//1. Write an expression that checks if given integer is
//odd or even.

using System;

class OddEven
{
    static void Main()
    {
        int number = 0;
        Console.WriteLine("Write an integer to check whether it's odd or even(default=0).");
        int.TryParse(Console.ReadLine(), out number);
        if (number % 2 != 0)
        {
            Console.WriteLine("{0} is ODD",number);
        }
        else
        {
            Console.WriteLine("{0} is EVEN",number);
        }
        
    }
}

