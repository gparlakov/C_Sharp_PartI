//Write an expression that checks if given point (x, y)
//is within a circle K(O, 5).

using System;

class withinCircle
{
    static void Main()
    {
        int x, y;
        Console.WriteLine("Write the x and y  coordinates of the point in question.");
        Console.Write("X=");
        int.TryParse(Console.ReadLine(),out x);
        Console.Write("Y=");
        int.TryParse(Console.ReadLine(), out y);
        if (((x < -5) || (x > 5)) || ((y < -5) || (y > 5)))
        {
            Console.WriteLine("The point ({0},{1}) is OUTside ot the circle (0,5)", x, y);
        }
        else
        {
            Console.WriteLine("The point ({0},{1}) is INside ot the circle (0,5)", x, y);
        }

    }
}

