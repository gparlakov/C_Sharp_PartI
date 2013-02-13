//Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class SquareEquationSolution
{
    static void Main()
    {
        double a, b, c, d;

        Console.WriteLine("We'll fint the real roots of the ax2+bx+c=0 equation");
        Console.Write("a=");
        while (!double.TryParse(Console.ReadLine(), out a)) { Console.WriteLine("a:"); }
        Console.Write("b=");
        while (!double.TryParse(Console.ReadLine(), out b)) { Console.WriteLine("b:"); }
        Console.Write("c=");
        while (!double.TryParse(Console.ReadLine(), out c)) { Console.WriteLine("c:"); }

        if (a == 0)
        {
            Console.WriteLine("x1=x2={0}", -c / b);
        }
        else
        {
            if (Math.Pow(b, 2) >= 4 * a * c)
            {
                d = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
                Console.WriteLine("x(1) = {0}, x(2)={1}", (-b + d) / 2 * a, (-b - d) / 2 * a);
            }
            else
            {
                Console.WriteLine("There aren't any real roots of this equasion.");
            }
        }

    }
}
