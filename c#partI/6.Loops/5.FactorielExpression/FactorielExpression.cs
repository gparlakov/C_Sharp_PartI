//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class NFactorielDevidedByKFactoiriel
{
    static void Main()
    {
        BigInteger partFactoriel,nFactoriel  = 1;
        uint N, K;
        Console.WriteLine("Give N and K (1<N<K). We'll do N!*K!/(K-N)!");
        do
        {
            Console.WriteLine("Integer N:(N>1)");
        } while (!uint.TryParse(Console.ReadLine(), out N) || N <= 1);
        do
        {
            Console.WriteLine("Integer K:(K>N)");
        } while (!uint.TryParse(Console.ReadLine(), out K) || K <= N);

        for (int y = 2; y <= N; y++)
        {
            nFactoriel *= y;
        }

        partFactoriel = K - N + 1;                      // K!/(K-N)!= (K-N+1)*(K-N+2)*...*(K-N+N=K)
        for (uint i = K - N + 2; i <= K; i++)   
        {
            partFactoriel *= i;
        }
        Console.WriteLine("N!*K!/(K-N)! = {0}",partFactoriel*nFactoriel); //N!*K!/(K-N)! 

    }
}