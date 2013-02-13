using System;

class Program
{
    static void Main()
    {
        int? intNull= null;
        double? dblNull = null;

        Console.WriteLine("The null integer ({0}), and double ({1}).",intNull,dblNull);
        intNull++;
        dblNull++;
        Console.WriteLine("intNull++ = ({0}), dblNull++ = ({1})", intNull, dblNull);
        Console.WriteLine("intNull+5 = ({0}), dblNull+5 = ({1})", intNull+5, dblNull+5);
        Console.WriteLine("intNull=5 ({0}), dblNull=5 ({1})", intNull=5, dblNull=5);
    }
}

