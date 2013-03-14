//draws a pyramid of letters from A to Z

using System;
 
class Anacci
{
    static void Main()
    {
        char first =  char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
 
        char next = second;
        for (int i = 0; i < height; i++)
        {
            if (i==0)
            {
                Console.WriteLine(first);
            }
            else
            {
                for (int widht = 0; widht <= i; widht++)
                {
                    if (widht==0||widht==(i))
                    {
                        Console.Write(next);
                        if (((first - 'A' + 1) + (second - 'A' + 1))>26)
                        {
                            next = (char)((((first - 'A' + 1) + (second - 'A' + 1)) % 26) + 'A' - 1); 
                        }
                        else
                        {
                            next = (char)((((first - 'A' + 1) + (second - 'A' + 1))) + 'A' - 1);
                        }
                         
                        if (next==('A'-1))
                        {
                            next = 'A';
                        }
                        first = second;
                        second = next;
                    }
                    else
                    {
                        Console.Write(" ");
                    }                   
                     
                }
                Console.WriteLine();
            }
        }
    }
}
 