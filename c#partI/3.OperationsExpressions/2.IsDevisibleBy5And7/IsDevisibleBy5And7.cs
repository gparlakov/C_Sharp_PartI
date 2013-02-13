//Write a boolean expression that checks for given
//integer if it can be divided (without remainder) by 7
//and 5 in the same time.
using System;

class IsDevisibleBy5And7
{
    static void Main()
    {
        int number = 0;
        Console.WriteLine("Write an integer to check whether it's devisible by 5 and 7 at the same time.");
        int.TryParse(Console.ReadLine(),out number);
        if ((number % 7 == 0) && (number % 5 == 0))
        {
            Console.WriteLine("Yes, {0} is devisible by 5 and 7 at the same time.",number);
        }
        else
        {
            Console.WriteLine("No, {0} is not devisible by 5 and 7 at the same time.",number);
        }
    }
}

