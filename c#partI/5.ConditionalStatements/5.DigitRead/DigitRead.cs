//Write program that asks for a digit and depending on the input 
//shows the name of that digit (in English) using a switch statement.

using System;

class DigitRead
{
    static void Main()
    {
        byte digit;
        Console.WriteLine("Enter a digit (0-9):");
        while (!byte.TryParse(Console.ReadLine(), out digit) || (digit > 9)) { Console.WriteLine("0 to 9 please:"); }
        switch (digit) 
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            default: Console.WriteLine("Nine"); break;
        }
    }
}
