//Write a program that reads the coefficients a, b and
//c of a quadratic equation ax2+bx+c=0 and solves it
//(prints its real roots).

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
