using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 0;
        if (n == 1)
        {
            Console.WriteLine(t1);
        }
        else if (n == 2)
        {
            Console.WriteLine(t2);
        }
        else if (n == 3)
        {
            Console.WriteLine(t3);
        }

        else
        {
            for (BigInteger i = 4; i <= n; i++)
            {
                result = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = result;
            }
            Console.WriteLine(result);
        }

    }
}

