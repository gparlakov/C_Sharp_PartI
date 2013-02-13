using System;



class HexFromInt
{
    static void Main()
    {
        int Integer = 254;
        int hexFromInt = 0xfe;
        Console.WriteLine("The Hexadecimal representation of 254 is {0}",Convert.ToString(Integer, 16) );
        Console.WriteLine("{0:X} or {0:x}",hexFromInt);
    }
}

