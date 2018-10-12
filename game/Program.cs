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
        static int height = 10;
        static int width = 30;
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
            Console.SetCursorPosition(0, 0);
            // Console.Write(he);

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
            for (int y = 0; y < height; y++)
            {
                Console.Write("|");
                Console.WriteLine();
            }
            Console.SetCursorPosition(width, 0);
            for (int y = 0; y < height; y++)
            {
                Console.Write("|");
                Console.WriteLine();
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


