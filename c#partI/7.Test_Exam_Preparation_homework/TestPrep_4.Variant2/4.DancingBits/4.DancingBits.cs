using System;
class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int count = 0, outputCount = 0;

        string concatenated = "";
        for (int i = 0; i < n; i++)
        {
            concatenated += Convert.ToString(int.Parse(Console.ReadLine()), 2);
        }
        //Console.WriteLine(concatenated);
        for (int i = 0; i < concatenated.Length; i++)
        {
            count = 0;
            for (int index = i; index < concatenated.Length; index++)
            {
                if (index >= concatenated.Length)
                {
                    break;
                }
                if (concatenated[i] == concatenated[index])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count > k)
            {
                i += count - 1;
                continue;
            }
            if (count == k)
            {
                outputCount++;
                i += count - 1;
            }
        }
        Console.WriteLine(outputCount);
    }
}
