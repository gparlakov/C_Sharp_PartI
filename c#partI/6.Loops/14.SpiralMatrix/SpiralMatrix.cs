using System;
using System.Threading;

namespace _14.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int N,lenght,cursorX=15,cursorY=1,step=1;       /* cursorX,Y hold the position of the next number  */
            sbyte direction = 1;                            /*  and "step" holds the nex number to be written  */
            Console.SetWindowSize(150, 35);                 /* in the spiral matrix, The window is set so large*/
            do                                              /* so that it can contain larger matrixes          */
            {
                Console.WriteLine("Number N: ");
            } while (!int.TryParse(Console.ReadLine(), out N));
            lenght = N;
            do                                             //endless loop which will be break-ed when at end of spiral         
            {
                for (int i = 0; Math.Abs(i) < lenght; )
                {
                    
                    cursorX += direction * 4;
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.Write("|{0,2}|", step);
                    i+=direction;
                    if (step == (N * N))        //checks if we've arrived at the end of the spiral
                    {                           //and breaks the small loop
                        break;
                    }
                    step++;
                    Thread.Sleep(15);
                }
                lenght--;

                if (step == (N * N))        /*checks if we've arrived at the end */
                                            /*  of the spiral and breaks the big loop*/ 
                {
                    break;
                }
                
                for (int y = 0; Math.Abs(y) < lenght; )
                {
                    
                    cursorY += direction;
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.Write("|{0,2}|", step);
                    y += direction;
                    if (step == (N * N))        //checks if we've arrived at the end of the spiral
                    {
                        break;
                    }
                    step++;
                    Thread.Sleep(15);
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
            Console.SetCursorPosition(0, 34);
            //Console.WriteLine("\n");
        }
    }
}
