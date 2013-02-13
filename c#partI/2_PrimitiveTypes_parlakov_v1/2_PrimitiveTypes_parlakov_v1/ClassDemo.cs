using System;


class Program
{
    static void Main()
    {
        int symbolWithNumber = 67;
        Console.WriteLine((char)symbolWithNumber);
        char firstsymbol = 'a';
        Console.WriteLine("code for {0} is {1:X}.",firstsymbol,(int)firstsymbol);  // izwejda coda za simvola w 16-na brojna sistema
        Console.WriteLine( "code for {0} is {1}.", ++firstsymbol, Convert.ToString((int)firstsymbol,16) );    
    }
}

