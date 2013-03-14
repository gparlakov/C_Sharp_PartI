using System;

class Program
{
    static void Main()
    {
        string num =  Console.ReadLine();
        char[] result = new char[num.Length];
        int length = 0, oneInMind = 0;
        if (num[num.Length-1]<='5')
        {
            result[result.Length-1]=(char)(num[num.Length-1]+1);
            for (int i = 0; i < num.Length-1; i++)
            {
                result[i] = num[i];
            }
        }
        else
        {
            result[result.Length - 1] = '0';
            length = num.Length;
            oneInMind = 1;
            for (int i = length-2; i >= 0; i--)
            {
                if (num[i]-'0'+ oneInMind<=6)
                {
                    result[i] = (char)(num[i] + oneInMind);
                    oneInMind = 0;
                }
                else
                {
                    oneInMind = 1;
                    result[i] = '0';
                }
            }
          
        }
        if (oneInMind == 1)
        {
            Console.Write(oneInMind);
        }
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }
        
        
    }
}
