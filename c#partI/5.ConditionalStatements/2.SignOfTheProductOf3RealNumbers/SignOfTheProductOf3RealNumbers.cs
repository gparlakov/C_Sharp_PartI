//Write a program that shows the sign (+ or -) 
//of the product of three real numbers without calculating it.
//Use a sequence of if statements.

using System;

    class SignOfTheProductOf3RealNumbers
    {
        static void Main()
        {
            float first, second, third;
            char sign = '-';
            Console.WriteLine("Enter three real numbers(decimal comma = ,) :");
            Console.WriteLine("First:");
            while (!float.TryParse(Console.ReadLine(), out first)) { Console.WriteLine("First:"); }
            Console.WriteLine("Second:");
            while (!float.TryParse(Console.ReadLine(), out second)) { Console.WriteLine("Second:"); }
            Console.WriteLine("Third:");
            while (!float.TryParse(Console.ReadLine(), out third)) { Console.WriteLine("Third:"); }
            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("({0}) * ({1}) * ({2}) = 0", first,second,third);
            }
            else
            {
                if (first < 0)
                {
                    if ((second < 0 && third > 0) || (second > 0 && third < 0))
                    {
                        sign = '+';
                    }
                }
                else
                {
                    if ((second < 0 && third < 0) || (second > 0 && third > 0))
                    {
                        sign = '+';
                    }
                }
                Console.WriteLine("The sign of ({0}) * ({1}) * ({2}) is {3} ", first, second, third, sign);
            }
            
        }
    }

