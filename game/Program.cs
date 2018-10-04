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
        static void Main(string[] args)

        {
            Console.WriteLine("Press arrows or Esc to exit");

            while (kb.Key != ConsoleKey.Escape)
            { 
            GetInput();
            Update();
            Draw();
            }

            Thread.Sleep(2000);
        }

        static ConsoleKeyInfo kb;
        public static void GetInput()
        {
            do
            {
                kb = Console.ReadKey();
                switch (kb.Key)
                {
                    case (ConsoleKey.LeftArrow):
                        Console.WriteLine("Left Arrow pressed");
                        break;
                    case (ConsoleKey.RightArrow):
                        Console.WriteLine("Right Arrow pressed");
                        break;
                    default:
                        Console.WriteLine("Neprovereno kopche e natisnato");
                        break;
                }


            } while (kb.Key != ConsoleKey.Escape);
        }

        public static void Update()
        {

        }
        public static void Draw()
        {

        }

        public static void Sleep(int sec)
        {

        }
    }


}


