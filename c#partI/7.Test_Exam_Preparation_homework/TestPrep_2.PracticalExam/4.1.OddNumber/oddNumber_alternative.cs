using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1.OddNumber
{
    class oddNumber_alternative
    {
        static void Main(string[] args)
        {
            long[] numbersAndHits = new long[long.MaxValue];
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                numbersAndHits[long.Parse(Console.ReadLine()) + 9223372036854775807]++;
            }
            for (ulong i = 0; i < ulong.MaxValue; i++)
            {
                if (numbersAndHits[i + 9223372036854775807] % 2 == 1)
                {
                    Console.WriteLine(numbersAndHits[i + 9223372036854775807]);
                    break;
                }
            }
        }
    }
}
