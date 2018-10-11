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
        static int height = 4;
        static int weight = 5;
        static char he = 'O';


        public static void GetInput()
        {
            kb = Console.ReadKey();
        }

        public static void Update()
        {
            if (kb.Key.Equals(ConsoleKey.LeftArrow))
            {
                x -= 1;
            }
            if (kb.Key.Equals(ConsoleKey.RightArrow))
            {
                x += 1;
            }
        }
        public static void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
           // Console.Write(he);
            char[,] arr = new char[6, 4]

             {
                 {'-','-','-','-' },
                 {'|',' ',' ','|' },
                 {'|',' ',' ','|' },
                 {'|',' ',' ','|' },
                 {'|',' ',' ','|' },
                 {'-','-','-','-' }

            };
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
          
        }

        static void Main(string[] args)
        {
          while (kb.Key != ConsoleKey.Escape)
            {
                Draw();
                GetInput();
                Update();
               
            }
        }

    }
}


