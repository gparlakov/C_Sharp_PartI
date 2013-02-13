using System;


class StringsFirst
{
    static void Main()
    {
        string PartI = "Hello ";
        string PartII = "World";
        object Whole = PartI + PartII;
        string FromObject = (string)Whole;//vajno - type casting ot object v string - ne stawa implicit(bez da mu ukajesh izri4no)
        Console.WriteLine("{0}\n{1}\n{2}\n{3}",PartI,PartII,Whole,FromObject); 
    }
}
