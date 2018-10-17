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
            x1 = width / 2;
            if (kb.Key.Equals(ConsoleKey.LeftArrow))
            {
                x1 -= 1;
            }
            if (kb.Key.Equals(ConsoleKey.RightArrow))
            {
                x1 += 1;
            }
           
            Console.SetCursorPosition(x1, height - 1);
            Console.Write(he);

        }
        public static void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
           
            for (int x = 0; x < width; x++)
            {
              Console.Write("-");
            }
            Console.SetCursorPosition(0,height);

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

            Console.SetCursorPosition(width/2, height-1);
            Console.Write(he);
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


