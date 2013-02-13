//Write an expression that calculates trapezoid's area
//by given sides a and b and height h. 

using System;



class Program
{
    static void Main()
    {
        float a,b,h;
        Console.WriteLine("Please give the a = AB b = CD and height of the Trapezoid");
        Console.Write("a=");
        float.TryParse(Console.ReadLine(), out a);
        Console.Write("b=");
        float.TryParse(Console.ReadLine(), out b);
        Console.Write("h=");
        float.TryParse(Console.ReadLine(), out h);
        Console.WriteLine("Trapezoid's area is {0} cm2", ((a+b)*h)/2);
    }
}

