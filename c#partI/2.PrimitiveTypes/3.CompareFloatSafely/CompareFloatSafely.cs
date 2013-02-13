using System;

class CompareFloatSafely
{
    static void Main()
    {
        float firstFloat =      5.0000001f;
        double firstDouble =    5.0000001;
        float secondFloat =     5.0000002f;
        double secondDouble =   5.0000002;
        float thirdFloat =      5.000001f;
        float fourthFloat =     5.000002f;
        
        Console.WriteLine(firstFloat);
        Console.WriteLine(secondFloat);
        Console.WriteLine(thirdFloat);
        Console.WriteLine(fourthFloat);
        Console.WriteLine("Is the first lesser than the second ? {0}",firstFloat <  secondFloat );
        Console.WriteLine("Is the third lesser than the fourth? {0}",thirdFloat<fourthFloat);
        /*7 знака точност - по-нататък float не работи добре*/
        Console.WriteLine("{0}\n{1}",firstDouble,secondDouble);
        Console.WriteLine("Again the first and second using double: {0}",firstDouble<secondDouble);

        /*only to compare if two numbers are equal we use the absolute of their difference*/
        float one = 5.000001f;
        float two = 5.000002f;
        Console.WriteLine("are the numbers equal:{0}",Math.Abs(one-two)>=float.Epsilon);



    }
}

