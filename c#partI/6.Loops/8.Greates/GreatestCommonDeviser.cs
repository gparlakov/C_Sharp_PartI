//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDeviser
{
    static void Main()
    {
        int firstN, secondN,lastDenum;
        do
        {
            Console.WriteLine("First Number:(> Second number) ");
        } while (!int.TryParse(Console.ReadLine(), out firstN));
        do
        {
            Console.WriteLine("Second Number:(<= First Number) ");
        } while (!int.TryParse(Console.ReadLine(), out secondN)||secondN>=firstN);
        
        do
        {            
            lastDenum = firstN % secondN;
            firstN = secondN;
            if (lastDenum > 0)
            {
                secondN = lastDenum;                //secondN will store the result if it's not 0
            }
            
        } while (lastDenum != 0);
        Console.WriteLine("Greatest common divisor is {0}",secondN);
    }
}