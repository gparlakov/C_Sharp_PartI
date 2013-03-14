//parse  number of excel  to int column A4 =  14 (given the lenght of the string 
// input 1 line : 2
// input 2 line : A
// input 3 line : 4
using System;

class Exel_Columns
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int power = n - 1;
        char[] chars = new char[n];

        ulong sum = 0;
        for (int i = 0; i < n; i++)
        {
            chars[i] = char.Parse(Console.ReadLine());
            sum += (ulong)(chars[i] - 'A' + 1) * (ulong)Math.Pow(26, power);
            power--;

        }
        Console.WriteLine(sum);
    }
}

