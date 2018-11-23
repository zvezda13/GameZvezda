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
        static int[] arr = new int[7];

       
        static List<int> elements = new List<int>();


        static int DivideThree(List<int> elements)
        {
            int sum = 0;
            foreach (int element in elements)
            {
                if (element % 3 == 0)
                {
                    sum+=element;
                }
            }
            Console.WriteLine("Sum3:  {0}", sum);
            return sum;
         }

            //void DeleneDve(int[] arr, out int chetni,out int nechetni)
            //    { 
            //        chetni = 0;
            //        nechetni = 0;
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            if (arr[i] % 2 ==0)
            //            {
            //                chetni += arr[i];
            //            }
            //            else
            //                nechetni += arr[i];
            //        }

            //    }
            static void PrintSums(int[] arr, int chetni, int nechetni)
        {
            Console.WriteLine("SumChetni:  {0}", chetni);
            Console.WriteLine("SumNeChetni:  {0}", nechetni);
            
        }
       
        static void Main(string[] args)
        {
            //int[] arr = new int[7]{ 1, 2, 3, 4, 5, 6,7 };
            elements.Add(1);
            elements.Add(2);
            elements.Add(3);
            elements.Add(4);
            elements.Add(5);
            elements.Add(6);
            DivideThree(elements);
            //DeleneDve(arr, out chetni, out nechetni);
            // PrintSums(arr,  chetni, nechetni);
        }

    }
}


