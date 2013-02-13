//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NFactorielDevidedByKFactoiriel
{
    static void Main()
    {
        BigInteger partFactoriel=1;
        uint N, K;
        Console.WriteLine("Give N and K (1<K<N). We'll do N!/K!");
        do
        {
            Console.WriteLine("Integer K:(K>1)");
        } while (!uint.TryParse(Console.ReadLine(), out K) || K <= 1);
        do
        {
            Console.WriteLine("Integer N:(N>K)");
        } while (!uint.TryParse(Console.ReadLine(), out N) || N <= K);
        partFactoriel=K+1;
        for (uint i = K + 2; i <= N; i++)   //N!/K! = 1*2*3*....*K*K+1*K+2.....*N/1*2*3*....*K = K+1*K+2*K+3....N-1*N
			{
			 partFactoriel*=i;
			}
        Console.WriteLine(partFactoriel);
        
    }
}