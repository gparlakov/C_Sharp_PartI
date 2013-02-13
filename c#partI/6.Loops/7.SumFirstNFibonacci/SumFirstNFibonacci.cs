//Write a program that reads a number N and calculates the sum of the first N members of the 
//sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class SumFirstNFibonacci
{
    static void Main()
    {
        uint N,lastFibo,currentFibo,nextFibo;                                     //hold 3 fibo numbers
        ulong sum = 0;
        Console.WriteLine("The sum of the first N fionacci numbers ");
        do
        {
            Console.WriteLine("Integer N: ");   
        } while (!uint.TryParse(Console.ReadLine(),out N));

        lastFibo = 0;
        currentFibo = 1;

        for (uint i = 1; i < N; i++)
        {
            sum += currentFibo;
            nextFibo = lastFibo + currentFibo;              
            lastFibo = currentFibo;
            currentFibo = nextFibo;
        }
        Console.WriteLine("The sum of the first N fionacci numbers is {0}",sum);
    }
}