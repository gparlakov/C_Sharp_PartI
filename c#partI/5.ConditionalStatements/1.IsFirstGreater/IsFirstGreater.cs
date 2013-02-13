//Write an if statement that examines two integer variables and exchanges 
//their values if the first one is greater than the second one.

using System;

class IsFirstGreater
{
    static void Main()
    {
        int first, second, buffer;
        Console.WriteLine("Enter two integers :");
        Console.WriteLine("First:");
        while (!int.TryParse(Console.ReadLine(), out first)) { Console.WriteLine("First Integer:"); }
        Console.WriteLine("Second:");
        while (!int.TryParse(Console.ReadLine(), out second)) { Console.WriteLine("Second Integer:"); }
        if (first > second)
        {
            buffer = first;
            first = second;
            second = buffer;
            Console.WriteLine("Now first is {0}, and second is {1}", first, second);
        }
        else
        {
            Console.WriteLine("Now first is {0}, and second is {1}", first, second);
        }

    }
}

