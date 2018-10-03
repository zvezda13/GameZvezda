using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace game
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Press arrows or Esc to exit");
            Program zvezda=new Program();
                       
            
            while (zvezda.kb.Key != ConsoleKey.Escape)
            {
               zvezda.GetKey();
            }
           
        }

     
        ConsoleKeyInfo kb = Console.ReadKey(); //hvashta push-natite buttoni ot keybord-a 
        public void GetKey()

        {
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
        }

        /*
         *  //foreach (kb.Key in )
            //    Console.WriteLine("Neprovereno kopche e natisnato");

         *  switch(kb)
            {
                case (ConsoleKey.LeftArrow):
            }
            if (kb.Key == ConsoleKey.LeftArrow)
                Console.WriteLine("Left Arrow pressed");
            else
                Console.WriteLine("Right Arrow pressed");
        internal enum KeyCode : int
               {
                   /// <summary>
                   /// The left arrow key.
                   /// </summary>
                   Left = 0x25,

                   /// <summary>
                   /// The right arrow key.
                   /// </summary>
                   Right,
               }
       


       internal static class NativeKeyboard
       {

           private const int KeyPressed = 0x8000;


           public static bool IsKeyDown(KeyCode key)
           {
               return (GetKeyState((int)key) & KeyPressed) != 0;

           }

           [System.Runtime.InteropServices.DllImport("user32.dll")]
           private static extern short GetKeyState(int key);
       }

        /*
      public static void IsLeft()
      {
          if  KeyCode= 0x25
              Console.WriteLine("Natisna na lqvo.");
          //return (GetKeyState((int)key) & KeyPressed) != 0;


      }
      */
        // static ConsoleKeyInfo key = new ConsoleKeyInfo();

    }


}
