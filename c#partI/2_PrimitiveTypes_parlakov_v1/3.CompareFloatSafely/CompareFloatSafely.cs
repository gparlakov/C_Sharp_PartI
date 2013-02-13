using System;




class CompareFloatSafely
{
    static void Main()
    {
        float firstFloat =  5.00000001f;
        float secondFloat = 5.00000002f;

        Console.WriteLine(5.00000001);
        Console.WriteLine(5.00000002);
        Console.WriteLine("Dali pyrwoto e po-malko: {0}",Math.Abs(firstFloat - secondFloat) < 0.000001); 
        /* Ideqta e 4e proverqwame absolutnata stojnost na razlikata da dwete-> w slu4aq |-0.00000001|*/
    }
}

