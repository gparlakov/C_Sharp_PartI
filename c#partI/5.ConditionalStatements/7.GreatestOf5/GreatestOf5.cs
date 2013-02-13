//Write a program that finds the greatest of given 5 variables.

using System;



class Program
{
    static void Main()
    {
        int first, second, third,fourth,fifth;
        Console.WriteLine("Enter five integers :");
        Console.WriteLine("First:");
        while (!int.TryParse(Console.ReadLine(), out first)) { Console.WriteLine("First Integer:"); }
        Console.WriteLine("Second:");
        while (!int.TryParse(Console.ReadLine(), out second)) { Console.WriteLine("Second Integer:"); }
        Console.WriteLine("Third:");
        while (!int.TryParse(Console.ReadLine(), out third)) { Console.WriteLine("Third Integer:"); }
        Console.WriteLine("Fourth:");
        while (!int.TryParse(Console.ReadLine(), out fourth)) { Console.WriteLine("Fourth Integer:"); }
        Console.WriteLine("Fifth");
        while (!int.TryParse(Console.ReadLine(), out fifth)) { Console.WriteLine("Fifth Integer:"); }
        if(first > second)
        {
            if (first>third)
            {
                if (first>fourth) 
                {
                    if (first > fifth) 
                    {
                        Console.WriteLine("The greatest is {0}",first);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",fifth);
                    }
                }
                else
                {
                    if (fourth>fifth)
                    {
                        Console.WriteLine("The greatest is {0}",fourth);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",fifth);
                    }
                }
            }
            else // first>second and first <=third
            {
                if(third < fourth) 
                {
                    if (fourth <fifth)
                    {
                        Console.WriteLine("The greatest is {0}",fifth);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",fourth);
                    }
                }
                else
                {
                    if (third<fifth)
                    {
                        Console.WriteLine("The greatest is {0}",fifth);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",third);
                    }
                }
            }
        }
        else //first < second
        {
            if(second<third)
            {
                if(third < fourth) 
                {
                    if (fourth<fifth) 
                    {
                        Console.WriteLine("The greatest is {0}",fifth);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",fourth);
                    }
                }
                else //first <second && second < third && third > fourt
                {
                    if (third < fifth) 
                    {
                        Console.WriteLine("The greatest is {0}",fifth);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",third);
                    }
                }
            }
            else //first <second  && second > third
            {
                if (second < fourth)
                {
                    if (second < fifth)
                    {
                        Console.WriteLine("The greatest is {0}",fifth);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",second);
                    }
                }
                else //first< sec && sec >sec > third && sec > fourth
                {
                    if (second>fifth)
                    {
                        Console.WriteLine("The greatest is {0}",second);
                    }
                    else
                    {
                        Console.WriteLine("The greatest is {0}",fifth);   
                    }
                }
            }
        }
    }
}

