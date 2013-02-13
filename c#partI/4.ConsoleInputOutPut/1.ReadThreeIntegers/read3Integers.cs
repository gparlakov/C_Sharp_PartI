//Write a program that reads 3 integer numbers from
//the console and prints their sum.

using System;

class read3Integers
{
    static void Main()
    {
        int first, second, third;

        Console.WriteLine("Give me 3 integers - each on a new row:");
        while (!int.TryParse(Console.ReadLine(), out first)) { Console.Write("Integer:"); }
        while (!int.TryParse(Console.ReadLine(), out second)) { Console.Write("Integer:"); }
        while (!int.TryParse(Console.ReadLine(), out third)) { Console.Write("Integer:"); }
        Console.WriteLine("thir sum is {0}+{1}+{2}={3}",first,second,third,first+second+third);   
    }
}

