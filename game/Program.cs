﻿using System;
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
        int x = 1;
        int y = 1;
        char he = 'O';

        public static void GetInput()
        {

            kb = Console.ReadKey();

        }
        public static void Update()
        {

        }
        public static void Draw(int x, int y)
        {
            
            if (kb.Key.Equals(ConsoleKey.LeftArrow))
            {
                x +=1;
               
              
            }
            Console.SetCursorPosition(x, y);
            if (kb.Key.Equals(ConsoleKey.RightArrow))
            {
                x -= 1;
             
              
            }
            Console.SetCursorPosition(x, y);

        }



        static void Main(string[] args)
        {

            Program zvezda=new Program() ;
   
           
            Console.WriteLine("Press arrows or Esc to exit");
          
            while (kb.Key != ConsoleKey.Escape)
            {
                GetInput();
                Update();

                 Draw (zvezda.x,zvezda.y);
                Console.Write(zvezda.he);


            }
        }

    }
}


