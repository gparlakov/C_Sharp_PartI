//Write a boolean expression that returns if the bit at
//position p (counting from 0) in a given integer
//number v has value of 1. Example: v=5; p=1  false.

using System;



class isBitP1
{
    static void Main()
    {
        int integer, bitP;
        int mask = 1;
        bool check;
        Console.WriteLine("We'll check whether integer v, whose bit at position p (counting from 0) has value of 1.");
        
        Console.Write("v=");
        while (!int.TryParse(Console.ReadLine(), out integer)) { Console.WriteLine("integer please "); }
        
        Console.Write("p=");
        while (!int.TryParse(Console.ReadLine(), out bitP)) { Console.WriteLine("integer please "); }

        mask = mask << bitP;
        mask = mask & integer;
        mask = mask >> bitP;
        check = (mask == 1);
        {
            Console.WriteLine(check);
        }
    }
}
