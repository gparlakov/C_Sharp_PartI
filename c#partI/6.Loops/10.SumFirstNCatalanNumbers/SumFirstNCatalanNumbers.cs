//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//C(n)=(2n)!/[n!(n+1)!)]  n>=0;
//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int N, secondN;
        BigInteger factorielN = 1, productN = 1,sum=1;   //poductN holds (n+2)*(n+3)*(n+4)*(n+5)*(n+6)*(n+7)*...........(n+n-1)(n+n)---- n-2 times
        Console.WriteLine("Output first N Catalan Numbers. C(N)");
        do
        {
            Console.WriteLine("Number N: ");
        } while (!int.TryParse(Console.ReadLine(), out N));
        secondN = N;
        for (N = 0; N < secondN; N++)
        {
            productN = factorielN = 1;
            for (int i = 1; i < N; i++)           //N-1 times
            {
                productN *= (i + 1 + N);
                factorielN *= i + 1;
            }
            Console.WriteLine("C({1}) = {0}", productN / factorielN, N );
            sum += (productN / factorielN);
        }
        Console.WriteLine("First N Catalan numbers's sum is = {0}",sum);
    }
}

