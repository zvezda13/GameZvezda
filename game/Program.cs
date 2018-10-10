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
        static int height = 5;
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
            Console.Write(he);
        }

        public static void DrawBorder()
        {
          
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < weight; x++)
                {
                    if (y > 0 )
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                
                 }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
          while (kb.Key != ConsoleKey.Escape)
            {
                DrawBorder();
                GetInput();
                Update();
                Draw ();
            }
        }

    }
}


