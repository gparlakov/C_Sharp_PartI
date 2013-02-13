//We are given 5 integer numbers. Write a program that checks 
//if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;


class IsSubSumZero
{
    static void Main()
    {
        int first, second, third, fourth, fifth;
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

        if ((first + second + third + fourth + fifth) == 0)                                                           //
        {
            Console.WriteLine("Sum ({0})+({1})+({2})+({3})+({4})=0",first,second,third,fourth,fifth);
        }                                                                                                             //sum of five

        if ((first + second + third + fourth) == 0)                                                                     //
        {
            Console.WriteLine("Sum ({0})+({1})+({2})+({3})=0", first, second, third, fourth);
        }
        if ((first + second + third + fifth) == 0) 
        {
            Console.WriteLine("Sum ({0})+({1})+({2})+({3})=0", first, second, third, fifth);
        }
        if (( second + third + fourth + fifth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})+({2})+({3})=0",second, third, fourth, fifth);
        }
                                                                                                                         //sum of four

        if ((first + second + third) == 0)                                                                              // 
        {
            Console.WriteLine("Sum ({0})+({1})+({2})=0", first, second, third);
        }
        if ((first + second + fourth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})+({2})=0", first, second, fourth);
        }
        if ((first + second + fifth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})+({2})=0", first, second, fifth);
        }
        if ((second +third + fifth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})+({2})=0", first, third, fifth);
        }
        if ((second + third + fourth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})+({2})=0", second, third, fourth);
        }                                                                                              
        
        
                                                                                                                        // sum of three

        if ((first + second) == 0)                                                                                      //sum of two
        {
            Console.WriteLine("Sum ({0})+({1})=0", first, second);
        } 
        if ((first + third) == 0) 
        {
            Console.WriteLine("Sum ({0})+({1})=0", first, third); 
        }
        if ((first + fourth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", first, fourth);
        } 
        if ((first + fifth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", first, fifth);
        }
        
        if ((second + third) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", second,third);
        }
        if ((second + fourth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", second, fourth);
        }
        if ((second + fifth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", second, fifth);
        }

        if ((third + fourth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", third, fourth);
        }
        if ((third + fifth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", third, fifth);
        }
        if ((fifth + fourth) == 0)
        {
            Console.WriteLine("Sum ({0})+({1})=0", fifth, fourth);
        }




    }
}
