using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace game
{
    class Program
    {
        static int[,] arr = new int[,]
              {{ 1, 9, 15 }
                ,{ 2,5,16 }
                ,{ 3,7,2} };
        static void PrintCentralDiagonal()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i, i] + ",");
            }
        }
        static void PrintSecondaryDiagonal()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == arr.GetLength(1) - (i + 1))
                    {
                        Console.Write(arr[i, j] + ",");
                    }
                }
            }

        }
        static void PrintReversedSecDiagonal(int[,] arr)
        {
            int revers = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(1); j > i; j--)
                {
                    revers = arr[i, j - 1];                   //obryshtam secondary diagonal
                    arr[i, j - 1] = arr[j - 1, i];
                    arr[j - 1, i] = revers;

                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == arr.GetLength(1) - (i + 1))         //printiram obyrnatiq diagonal
                    {
                        Console.Write(arr[i, j] + ",");
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            PrintCentralDiagonal();
            Console.WriteLine();
            PrintSecondaryDiagonal();
            Console.WriteLine();
            PrintReversedSecDiagonal(arr);
                   
            //while (kb.Key != ConsoleKey.Escape)
            //{
            //    GetInput();
            //    Update();
            //    Draw();
            //    Thread.Sleep(600);
            //}
        }

    }
}


