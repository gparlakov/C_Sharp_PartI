//Write a program that gets two numbers from the
//console and prints the greater of them. Don’t use if
//statements.

using System;

class GreaterOfTwoNumbersWithoutIf
{
    static void Main()
    {
        int firstNumber, secondNumber;
        Console.WriteLine("Two numbers:");
        Console.Write("First :");
        while (!int.TryParse(Console.ReadLine(), out firstNumber)) { Console.WriteLine("Integer:"); }
        Console.Write("Second :");
        while (!int.TryParse(Console.ReadLine(), out secondNumber)) { Console.WriteLine("Integer:"); }
        
        Console.WriteLine((firstNumber >secondNumber) ? firstNumber : secondNumber);
    }
}

