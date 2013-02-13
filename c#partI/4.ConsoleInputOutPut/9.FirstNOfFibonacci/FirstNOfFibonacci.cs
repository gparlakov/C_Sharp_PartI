//Write a program to print the first 100 members of
//the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21,
//34, 55, 89, 144, 233, 377, …

using System;

class Program
{
    static void Main()
    {
        byte n,counter;
        long fibonacci1,fibonacci2;
        /*user is asked to define how many of the members of 
         Fibonacci sequence to visualise because 
         with 100 it's too slow*/

        Console.WriteLine("We'll print the first n numbers of the Fibonacci numbers ");
        Console.WriteLine("It works fine up to 45-46. More and it gets veery slowwww");
        Console.Write("n:");
        while (!byte.TryParse(Console.ReadLine(), out n)) { Console.WriteLine("n:"); }      
        counter = 0;
        fibonacci1 = 0;
        fibonacci2 = 1;
        if (n >= 1) 
        {
            Console.WriteLine("Fibonacci number 1 is 1");
        }

        for (int i = 0; counter < n-1; i++)
        {
            if (i == (fibonacci2 + fibonacci1))
            {
                Console.WriteLine("Fibonacci number {0} is {1}",counter+2,i);
                fibonacci1 = fibonacci2;
                fibonacci2 = i;
                counter++;
            }
        }
    }
}

