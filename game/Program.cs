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
           
               zvezda.GetKey();
          
           
        }
         // ConsoleKeyInfo kb = Console.ReadKey();   //hvashta push-natite buttoni ot keybord-a 


        ConsoleKeyInfo kb;
        public void GetKey()

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


    }


}


