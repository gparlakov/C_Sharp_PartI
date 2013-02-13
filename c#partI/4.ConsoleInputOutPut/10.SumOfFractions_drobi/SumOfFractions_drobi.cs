//Write a program to calculate the sum (with accuracy
//of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumOfFractions_drobi
{
    static void Main()
    {
        double sum=1;
        double check;
        check = 1d;
        bool flag = false;
        
        for (int i = 2; flag!=true; i++)
        {
            check=(double)1/i;
            if (i % 2 == 0)
            {
                sum += check;
            }
            else
            {
                sum -= check;
            }

            if(check<=0.001)
            {
                flag = true;
            }
            Console.WriteLine("{0:0.000000}",check);
        }
        Console.WriteLine("Sum of 1+1/2-1/3+1/4-1/5...... is {0:0.000}",sum);
    }
}

