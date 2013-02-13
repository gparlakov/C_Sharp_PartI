using System;

class TwoValuesExchange
{
    static void Main()
    {
        int first = 5;
        int second = 10;
        int buffer = 0;
        Console.WriteLine("first is {0}, second {1}",first,second);
        buffer = first;
        first = second;
        second = buffer;
        Console.WriteLine("first is {0}, second {1}",first,second);
    }
}

