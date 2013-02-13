//* Write a program that calculates for given N how
//many trailing zeros present at the end of the number N!.

using System;

class HowManyZeroesInFactorielGiven
{
    static void Main()
    {
        int N,sum=0,powerOfFive=5;
        Console.WriteLine("Give me N(integer >0).\nI'll tell you how many trailing zeroes are there in its factoral :)");
        do
        {
            Console.WriteLine("Number N: ");
        } while (!int.TryParse(Console.ReadLine(), out N));
        
        do
        {
            sum += (N / powerOfFive);
            powerOfFive *= 5;
            
        } while (powerOfFive<=N);

        Console.WriteLine("Numer of trailing '0' in {0}! is {1}",N,sum);

    }
}