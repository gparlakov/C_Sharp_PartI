using System;

class Program
{
    static void Main()
    {
        //DateTime start = DateTime.Now;
        byte[] numbers = new byte[5];
        int devisors = 0;
        byte least = 0;
        for (int i = 0; i < 5; i++)
		{
            numbers[i] = byte.Parse(Console.ReadLine());
        }

        least =numbers[0];
        for (int i = 1; i < 5; i++)         //places the least number in numbers[0] - first position of the array "numbers"
        {
            if (numbers[i] < least)
            {
                least = numbers[i];
                numbers[i] = numbers[0];
                numbers[0] = least;
            }
        }

        for (int i = 1; i <= 10000; i++)    //take the least of the numbers and gradually multiply it with 1,2,4...10000 until 
        {                                   //you find the number that is devisible by at least 3 of the numbers =
            devisors = 1;                   // the count starts from 1 because it will always be devisible by itself multiplied by 1,2,4....
            for (int y = 1; y < 5; y++)
            {
                if ( ((numbers[0]*i) % numbers[y])==0)
                {
                    devisors++;
                }  
            }
            if (devisors>=3)
            {
                Console.WriteLine(numbers[0]*i);
                break;
            }
        }
        //Console.WriteLine(DateTime.Now-start);
    }
}
