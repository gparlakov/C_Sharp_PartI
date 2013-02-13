//Write a program that reads an integer number n
//from the console and prints all the numbers in the
//interval [1..n], each on a single line.

using System;

class Program
{
    static void Main()
    {
        int n;
        char znak=' ';
        Console.Write("n=");
        while (!int.TryParse(Console.ReadLine(), out n)) { Console.WriteLine("n:"); }
        if (n < 0) { znak='-'; }
        n=Math.Abs(n);
        for (int i = 1; i <= n; i++)
        {
            if (znak == ' ')
            {
                Console.WriteLine(i);
            }
            else 
            {
                Console.WriteLine("{0}{1}",znak,i);
            }
        }
    }
}
