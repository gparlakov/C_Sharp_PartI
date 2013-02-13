//Write a program that reads the radius r of a circle
//and prints its perimeter and area.

using System;

class ReadRadiusGivePerimeter
{
    static void Main()
    {
        float radius;

        Console.WriteLine("Please give the radius of circle for perimeter:");
        while (!float.TryParse(Console.ReadLine(), out radius)) { Console.Write("Number:"); }
        Console.WriteLine("Perimeter of circle with radius={0} is {1,-2:f}",radius,Math.PI*radius*2);
    }
}

