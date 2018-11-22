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
        int Minimum = arr[0];
        int Maximum = arr[0];
        static int LimitToRange(int[] arr, int Minimum, int Maximum)
        {
            int limit = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < Minimum)
                {
                    arr[i] = Minimum;
                    Minimum = limit;
                }
                if (arr[i] > Maximum)
                {
                    arr[i] = Maximum;
                    Maximum = limit;
                }
            }
            
            return limit;
        }
        static int Bigg(int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > temp)
                {
                    temp = arr[i];
                }
            }
           
           Console.WriteLine("{0}",temp);

            return temp;
        }
        

        static void Main(string[] args)
        {
            int[] arr = new int[7] { 15, 9, 28, -5001, 20, 5002, 2 };
            LimitToRange(arr, -5000, 5000);
            Bigg(arr);
        }

    }
}


