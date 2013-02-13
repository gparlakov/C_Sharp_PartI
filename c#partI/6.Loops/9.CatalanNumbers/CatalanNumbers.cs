//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//C(n)=(2n)!/[n!(n+1)!)]  n>=0;

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        
        BigInteger factorielN = 1, productN = 1;   //poductN holds (n+2)*(n+3)*(n+4)*(n+5)*(n+6)*(n+7)*...........(n+n-1)(n+n)---- n-2 times
       
        for (int N = 0; N < 35; N++)        //will display first 35 numbers - can be modified 
        {
            productN = factorielN = 1;
            for (int i = 1; i < N; i++)           //N-1 times
            {
                productN *= (i+1 + N);
                factorielN *= i + 1;
            }
            Console.WriteLine("C({1}) = {0}", productN / factorielN, N);
        }

    }
}

