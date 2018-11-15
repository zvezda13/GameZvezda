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
        static int[,] arr = new int[,]
              {{ 1, 9, 15 }
                ,{ 2,5,16 }
                ,{ 3,7,2} };
        static void PrintCentralDiagonal()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i, i] + ",");
            }
        }
  
        static void PrintSecondaryDiagonal()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int j = (arr.GetLength(0) - (i + 1));
                Console.Write(arr[i, j] + ",");     
            }
        }
      
        static void PrintReverceCentralDiagonal()
        {
            for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            {
                Console.Write(arr[i, i] + ",");
            }
        }

        static void PrintSecondaryReverseDiagonal()
        {
            for (int i = arr.GetLength(0)-1; i >=0; i--)
            {
                int j = (arr.GetLength(0) - (i + 1));
                Console.Write(arr[i, j] + ",");
            }
        }

        static void Main(string[] args)
        {
            PrintCentralDiagonal();
            Console.WriteLine();
            PrintSecondaryDiagonal();
            Console.WriteLine();
            PrintReverceCentralDiagonal();
            Console.WriteLine();
            PrintSecondaryReverseDiagonal();  
        }

    }
}


