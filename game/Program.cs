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

        public static void GetInput()
        {

            kb = Console.ReadKey();

        }
        public static void Update()
        {

        }
        public static void Draw(int x, int y)
        {

            if (x >= 0 && y >= 0)
            {

                if (ConsoleKey.LeftArrow != 0)
                    x++;

                if (ConsoleKey.RightArrow != 0)
                    x--;

            }


        }


        static void Main(string[] args)
        {
            Console.WriteLine("Press arrows or Esc to exit");
            char he = 'O';
            int x = 1;
            int y = 1;
            while (kb.Key != ConsoleKey.Escape)
            {
                GetInput();
                Update();
                Console.Clear();

                Draw(x, y);
                Console.SetCursorPosition(x, y);
                Console.Write(he);
                Thread.Sleep(500);
            }
        }
    }
}


