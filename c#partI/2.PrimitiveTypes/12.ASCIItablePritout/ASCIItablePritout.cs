using System;
using System.Text;



class ASCIItablePritout
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("({0})",(char)i);
            if (i % 25 == 0)                    //po 25 simwola na red 
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();       
    }

}