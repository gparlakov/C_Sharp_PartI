﻿using System;

class Program
{
    static void Main()
    {
        string n = Console.ReadLine();
        char nextChar = '-';
        int sum = 0;
        do
        {
            sum = 0;
            for (int i = 0; i < n.Length; i++)
			{
                nextChar = n[i];
                if (nextChar>='0'&&nextChar<='9')
                {
                    sum += nextChar - '0';
                }
                else if (nextChar == '-' || nextChar == '.')
                {
                    continue; 
                }                
            }
            n = Convert.ToString(sum);
        } while (sum > 9) ;
        Console.WriteLine(n);
    }
}