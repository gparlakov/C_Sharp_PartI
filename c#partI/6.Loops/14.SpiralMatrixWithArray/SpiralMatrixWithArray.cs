using System;
using System.Threading;

namespace _14.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int N, lenght, arrayX = -1, arrayY = 0, step = 1;   /* arrayX,Y hold the position of the next number   */
            sbyte direction = 1;                                /*  and "step" holds the nex number to be written  */
                                                                /* in the spiral matrix, The window is set so large*/
            Console.SetWindowSize(150, 35);                     /* so that it can contain larger matrixes          */
            do                                                          
            {
                Console.WriteLine("Number N: ");
            } while (!int.TryParse(Console.ReadLine(), out N));

            lenght = N;
            int[,] spiralArray= new int[N,N];
            do                                                  //endless loop which will be break-ed when at end of spiral         
            {
                for (int i = 0; Math.Abs(i) < lenght; )
                {
                    arrayX += direction;
                    spiralArray[arrayX,arrayY] = step;
                    i += direction;
                    if (step == (N * N))        //checks if we've arrived at the end of the spiral
                    {                           //and breaks the small loop
                        break;
                    }
                    
                    step++;
                }
                lenght--;

                if (step == (N * N))        /*checks if we've arrived at the end */
                {                           /*  of the spiral and breaks the big loop*/
                    break;
                }

                for (int y = 0; Math.Abs(y) < lenght; )
                {
                    arrayY += direction;
                    spiralArray[arrayX,arrayY] = step;
                    y += direction;

                    if (step == (N * N))        //checks if we've arrived at the end of the spiral
                    {
                        break;
                    }
                    
                    step++;
                    
                }

                /*on every two iterations the direction of writing is set opposite
                 so that it first moves right/down then left/up*/
                if (direction == 1)
                {
                    direction = -1;
                }
                else
                {
                    direction = 1;
                }

            } while (true);

            for (int i = 0; i < N; i++)
            {
                for (int y = 0; y < N; y++)
                {
                    Console.Write("{0,3} ",spiralArray[y,i]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
