//Write a program that, for a given two integer numbers N and X, calculates the 
//sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        byte N, X;
        BigInteger factorielDevided,nMinus1Factoriel=1,sumPart=1;
        double sum = 1;

        Console.WriteLine("S = 1 + 1!/X + 2!/X2 + … + N!/XN");
        do
        {
            Console.WriteLine("Integer N:");
        } while (!byte.TryParse(Console.ReadLine(), out N));
        do
        {
            Console.WriteLine("Integer (Not Zero) X:");
        } while (!byte.TryParse(Console.ReadLine(), out X)||X==0);

        for (int i = 2; i < N; i++)
        {
            nMinus1Factoriel *= i;   //(N-1)!
        }
        factorielDevided = nMinus1Factoriel;

        // S= 1 + 1!/X + 1*2/X*2 + … + (N-1)!N/X*N = 1+ 1!/X+ 1!/X + 2!/X + 3!/X +.....+ (N-1)!/X = 1+ (1 + 1! + 2! + 3! +....+ (N-1)!)/X

        for (int i = N; i > 1; i--)
        {
            sumPart += factorielDevided;
            factorielDevided /= i - 1;                                  //sumPart holds ( 1 + 1! + 2! + 3! +....+ (N-1)! )
        }
        sum += (double)sumPart / X;
        Console.WriteLine(sum);
    }
}