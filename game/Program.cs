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
        static int[] arr= new int[7];  
        
        static void MinMaxPrint(int[] arr, out int minVal,out int maxVal)
        {
            minVal = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < minVal)
                {
                    minVal = arr[i];
                }
            }
            Console.WriteLine("min:  {0}",minVal);

            maxVal = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > maxVal)
                {
                    maxVal = arr[i];
                }
            }
            Console.WriteLine("max:  {0}", maxVal);

        }
        

        static void Main(string[] args)
        {
            int[] arr = new int[7]{ 5001, 1, 2, 3, 4, -5001, 6 };
            int minVal, maxVal;
            MinMaxPrint(arr, out minVal, out maxVal);
        }

    }
}


