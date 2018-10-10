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
        static int x = 1;
        static int y = 1;
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
            Console.SetCursorPosition(x, y);
            if (kb.Key.Equals(ConsoleKey.RightArrow))
            {
                x += 1;
            }
            Console.SetCursorPosition(x, y);
        }
        public static void Draw()
        {
            Console.Write(he);
        }

        static void Main(string[] args)
        {

                    
            while (kb.Key != ConsoleKey.Escape)
            {
                GetInput();
                Console.Clear();
                Update();
                Draw ();
            }
        }

    }
}


