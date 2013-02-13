//Write a program that finds the biggest of three integers using nested if statements.

using System;

class Program
{
    static void Main()
    {
        int first, second, third;
        Console.WriteLine("Enter three integers :");
        Console.WriteLine("First:");
        while (!int.TryParse(Console.ReadLine(), out first)) { Console.WriteLine("First Integer:"); }
        Console.WriteLine("Second:");
        while (!int.TryParse(Console.ReadLine(), out second)) { Console.WriteLine("Second Integer:"); }
        Console.WriteLine("Third:");
        while (!int.TryParse(Console.ReadLine(), out third)) { Console.WriteLine("Third Integer:"); }


        if (first > second)
        {
            if (first > third)
            {
                Console.WriteLine("The biggest of the three is {0}", first);
            }
            else
            {
                Console.WriteLine("The biggest of the three is {0}", third);
            }
        }
        else
        {
            if (second > third)
            {
                Console.WriteLine("The biggest of the three is {0}", second);
            }
            else
            {
                Console.WriteLine("The biggest of the three is {0}", third);
            }
        }
    }
}

