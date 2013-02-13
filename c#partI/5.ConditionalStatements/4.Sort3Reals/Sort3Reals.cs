//Sort 3 real values in descending order using nested if statements.

using System;

class Sort3Reals
{
    static void Main(string[] args)
    {
        float first, second, third;
        
        Console.WriteLine("Enter three real numbers(decimal comma = ,) :");
        Console.WriteLine("First:");
        while (!float.TryParse(Console.ReadLine(), out first)) { Console.WriteLine("First:"); }
        Console.WriteLine("Second:");
        while (!float.TryParse(Console.ReadLine(), out second)) { Console.WriteLine("Second:"); }
        Console.WriteLine("Third:");
        while (!float.TryParse(Console.ReadLine(), out third)) { Console.WriteLine("Third:"); }

        if (first > second)
        {
            if (first > third)
            {
                if (second > third)
                {
                    Console.WriteLine("The ascending order is {0} {1} {2}", third, second, first);
                }
                else 
                {
                    Console.WriteLine("The ascending order is {0} {1} {2}", second, third, first);   
                }
            }
            else
            {
                Console.WriteLine("The ascending order is {0} {1} {2}", second, first, third);
            }
        }
        else //first<=second
        {
            if (first < third)
            {
                if (second < third)
                {
                    Console.WriteLine("The ascending order is {0} {1} {2}", first, second, third);
                }
                else
                {
                    Console.WriteLine("The ascending order is {0} {1} {2}", first, third, second);
                }
            }
            else // first >= third
            {
                Console.WriteLine("The ascending order is {0} {1} {2}", third, first, second);
            }
        }
    }
}
