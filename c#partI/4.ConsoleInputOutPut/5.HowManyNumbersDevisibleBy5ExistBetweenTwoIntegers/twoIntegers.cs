//Write a program that reads two positive integer
//numbers and prints how many numbers p exist
//between them such that the reminder of the division
//by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;
  class twoIntegers
    {
        static void Main()
        {
            int firstInt, secondInt, buffer;
            int counter = 0;
            Console.WriteLine("Enter two integers and see how many devisible by 5 numbers are ther between them");
            Console.Write("First Integer:");
            while (!int.TryParse(Console.ReadLine(), out firstInt)) { Console.WriteLine("Integer:"); }
            Console.Write("Second Integer:");
            while (!int.TryParse(Console.ReadLine(), out secondInt)) { Console.WriteLine("Integer:"); }
            /*If firstInt is bigger than second we change their places in order for the 'for' to work*/
            
            if((firstInt-secondInt) > 0)                                                                            
            {
                buffer=firstInt;
                firstInt=secondInt;
                secondInt=buffer;
            }

            for (int i = firstInt+1; i < secondInt; i++)
            {
                if ((i % 5 == 0) && (i!=0))
                {
                    counter++;
                }
            }
            Console.WriteLine("There are {0} numbers devisible by 5 between {1} and {2}",counter,firstInt,secondInt);

        }
    }

