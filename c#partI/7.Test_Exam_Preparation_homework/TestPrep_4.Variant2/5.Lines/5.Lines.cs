using System;

class Program
{
    static int getBit(int number, int bitIndex)
    {
        int result = 0;
        if ((number >> bitIndex & 1) == 1)
        {
            result = 1;
        }

        return result;
    }

    //returns lenght of horizontal line()
    static int getHorizontalLine(int[] array, int horIndex, int verIndex)
    {
        int lenght = 0;
        for (int i = verIndex; i < 8; i++)
        {
            if (getBit(array[horIndex], i) == 1)
            {
                lenght++;
            }
            else
            {
                break;
            }
        }
        return lenght;
    }

    //returns lenght of vertical line()
    static int getVerticalLine(int[] array, int horIndex, int verIndex)
    {
        int lenght = 0;
        for (int i = horIndex; i < 8; i++)
        {
            if (getBit(array[i], verIndex) == 1)
            {
                lenght++;
            }
            else
            {
                break;
            }
        }
        return lenght;
    }

    static void Main()
    {
        int[] nums = new int[8];
        //nums[0] = 1;//8;
        //nums[1] = 0;//72;
        //nums[2] = 0;//8;
        //nums[3] = 1;//8;
        //nums[4] = 0;//16;
        //nums[5] = 0;//28;
        //nums[6] = 0;//240;
        //nums[7] = 1;//0;
        for (int i = 0; i < 8; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int col, row, vLineMaxLenght = 1, hLineMaxLenght = 1, hLines = 0, vLines = 0, line, vertical;


        for (row = 0; row < 8; row++)
        {
            for (col = 0; col < 8; col++)
            {
                if (getBit(nums[row], col) == 1)
                {
                    line = getHorizontalLine(nums, row, col);
                    if (line == hLineMaxLenght)
                    {
                        hLines++;
                        col += line - 1;
                    }
                    else if (line > hLineMaxLenght)
                    {
                        hLineMaxLenght = line;
                        hLines = 1;
                        col += line - 1;
                    }
                }
            }
        }

        for (col = 0; col < 8; col++)
        {
            for (row = 0; row < 8; row++)
            {
                if (getBit(nums[row], col) == 1)
                {
                    vertical = getVerticalLine(nums, row, col);
                    if (vertical == vLineMaxLenght)
                    {
                        vLines++;
                        row += vertical - 1;
                    }
                    else if (vertical > vLineMaxLenght)
                    {
                        vLineMaxLenght = vertical;
                        vLines = 1;
                        row += vertical - 1;
                    }
                }
            }
        }

        if (vLineMaxLenght > hLineMaxLenght)
        {
            Console.WriteLine(vLineMaxLenght);
            Console.WriteLine(vLines);
        }
        else if (vLineMaxLenght < hLineMaxLenght)
        {
            Console.WriteLine(hLineMaxLenght);
            Console.WriteLine(hLines);
        }
        else                                     //vLineMaxLenght == hLineMaxLenght
        {
            Console.WriteLine(vLineMaxLenght);
            if ((vLineMaxLenght == 1) && (vLines == 1) && (hLines == 1)) 
            {
                Console.WriteLine(1);
            }
            else if ((vLineMaxLenght==1)&&(vLines==hLines))
            {
                Console.WriteLine(vLines);
            }
            else
            {
                Console.WriteLine(vLines + hLines);
            }
        }
    }
}