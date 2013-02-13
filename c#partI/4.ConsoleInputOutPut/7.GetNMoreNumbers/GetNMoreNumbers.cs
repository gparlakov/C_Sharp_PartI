//Write a program that gets a number n and after that
//gets more n numbers and calculates and prints their
//sum.

using System;

class Program
{
    static void Main()
    {
        int n, sum, nextNumber;
        Console.Write("n=");
        sum = 0;
        while (!int.TryParse(Console.ReadLine(), out n)) { Console.WriteLine("n:"); }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Number {0} of {1}:",i+1,n);
            while (!int.TryParse(Console.ReadLine(), out nextNumber)) { Console.WriteLine("next number:"); }            
            sum += nextNumber;
        }
        Console.WriteLine("Sum is {0}",sum);
    }

}

