//Write an expression that checks if given positive
//integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class prostoChislo
{
    static void Main()
    {

        byte n;
        Console.WriteLine("What is n (0-100)?");
        do
        {
            byte.TryParse(Console.ReadLine(), out n);
            if (n == 1 || n == 0)
            {
                Console.WriteLine("It's not prime(according to \"sequence A000040 in OEIS\")");
                break;
            }
            if (n>100)
            {
                Console.WriteLine("0-100 please");
            }
        } while ((n > 100) || (n<=1));
        if (n > 1)
        {
            if (n > 7)
            {
                Console.WriteLine("Is {0} prime ? {1}", n, (!((n % 2 == 0) || (n % 3 == 0) || (n % 5 == 0) || (n % 7 == 0))));
            }
            else
            {
                Console.WriteLine("Is {0} prime ? {1}", n, ( (n == 2) || (n  == 3) || (n  == 5) || (n  == 7)) );
            }
        }
    }
}

