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
        static ConsoleKeyInfo kb;
        static int x = 0;
        static int y = 0;
        static int x1 = 0;
        static int height = 10;
        static int width = 40;
        static char he = 'O';


        public static void GetInput()
        {
            kb = Console.ReadKey();
        }

        public static void Update()
        {
            Console.SetCursorPosition(width / 2, height - 1);
            Console.Write(he);
            if (kb.Key.Equals(ConsoleKey.LeftArrow))
            {
                Console.Write(he);
                x1 -= 1;
            }
            Console.SetCursorPosition(x1, height - 1);
            if (kb.Key.Equals(ConsoleKey.RightArrow))
            {

                x1 += 1;
                Console.Write(he);

            }

            Console.SetCursorPosition(x1, height - 1);


        }
        public static void Draw()
        {
            Console.Clear();
            // Console.SetCursorPosition(0, 0);

            for (int x = 0; x < width; x++)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(0, height);

            for (int x = 0; x < width; x++)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y <= height; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("|");
            }
            Console.SetCursorPosition(width, 0);
            for (int y = 0; y <= height; y++)
            {
                Console.SetCursorPosition(width, y);
                Console.Write("|");
            }

        }

        static int[,] arr = new int[,]
              {{ 1, 9, 15 }
                ,{ 2,5,16 }
                ,{ 3,7,2} };
        static void PrintCentralDiagonal()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i, i]);
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
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }

        }
        static void PrintSecondaryDiagonalOposite()
        {

        }


        static void Main(string[] args)
        {
            PrintCentralDiagonal();
            PrintSecondaryDiagonal();
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


