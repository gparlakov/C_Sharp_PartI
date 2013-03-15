using System;

class GetBit
{
    static int getBit(int num, int bitposition)
    {
        int result = 0;
        if (((num >> bitposition) & 1)==1)
        {
            result = 1;
        }
        return result;
    }
    
    static void Main()
    {
        int[] numbers = new int[8];
        int[] numbers2 = new int[8];
        char[,] players = new char[8, 8];
        for (int i = 0; i < 8; i++)
        {
            for (int y = 0; y < 8; y++)
            {
                players[i, y] = '.';
            }
        }


        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 8; i++)
        {
            numbers2[i] = int.Parse(Console.ReadLine());
        }

        //numbers[0] = 254;
        //numbers[1] = 74;
        //numbers[2] = 40;
        //numbers[3] = 0;
        //numbers[4] = 86;
        //numbers[5] = 0;
        //numbers[6] = 16;
        //numbers[7] = 0;

        //numbers2[0] = 0;
        //numbers2[1] = 0;
        //numbers2[2] = 129;
        //numbers2[3] = 73;
        //numbers2[4] = 6;
        //numbers2[5] = 4;
        //numbers2[6] = 72;
        //numbers2[7] = 16;

        //numbers[0] = 240;
        //numbers[1] = 0;
        //numbers[2] = 240;
        //numbers[3] = 0;
        //numbers[4] = 96;
        //numbers[5] = 0;
        //numbers[6] = 0;
        //numbers[7] = 0;

        //numbers2[0] = 0;
        //numbers2[1] = 0;
        //numbers2[2] = 10;
        //numbers2[3] = 6;
        //numbers2[4] = 0;
        //numbers2[5] = 15;
        //numbers2[6] = 0;
        //numbers2[7] = 15;

        for (int posX = 0; posX < 8; posX++)
        {
            for (int posY = 0; posY < 8; posY++)
            {
                if (getBit(numbers[posX],posY)==1&&getBit(numbers2[posX],posY)!=1)
                {
                    players[posX, posY] = 'T';
                }
                if (getBit(numbers2[posX], posY) == 1 && getBit(numbers[posX], posY) != 1)
                {
                    players[posX, posY] = 'B';
                }
                //Console.Write(players[posX,posY]);
                //Console.Write(' ');
            }
            //Console.WriteLine();
        }

        //for (int i = 7; i >= 0; i--)
        //{
        //    Console.Write("{0,3}",Math.Pow(2,i));
        //}
        //Console.WriteLine();

        //for (int x = 0; x < 8; x++)
        //{
        //    for (int y = 7; y >= 0; y--)
        //    {
        //        Console.Write("{0,3}",players[x,y]);
        //    }
        //    Console.WriteLine();
        //}
        int result1 = 0, result2 = 0,buffer=0;
        
        for (int posX = 0; posX < 8; posX++)
        {
            for (int posY = 0; posY < 8; posY++)
            {
                buffer = 1;
                if (players[posX,posY]=='T')
                {
                    if (posX==7)
                    {
                        result1++;
                    }
                    else
                    {
                        for (int i = posX+1; i < 8; i++)
                        {
                            if (players[i,posY]!='.')
                            {
                                buffer = 0;
                            }  
                        }
                        result1 += buffer;
                    }
                }

                if (players[posX,posY]=='B')
                {
                    buffer = 1;
                    if (posX==0)
                    {
                        result2++;
                    }
                    else
                    {
                        for (int i = posX-1; i >= 0; i--)
                        {
                            if (players[i,posY]!='.')
                            {
                                buffer = 0;
                            }
                        }
                        result2 += buffer;
                    }

                }
            }
        }


        Console.WriteLine("{0}:{1}",result1,result2);
    }
}