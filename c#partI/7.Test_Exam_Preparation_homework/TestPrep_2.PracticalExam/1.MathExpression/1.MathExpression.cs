using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal constant = 128.523123123m;

        Console.WriteLine( "{0:0.000000}",(((n*n)+(1/(m*p))+1337)/(n-(constant*p)))+(decimal)(Math.Sin((int)m%180)) );
    }
}