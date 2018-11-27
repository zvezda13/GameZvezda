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
        static List<int> DevideList (int[] arr)
             {
            for (int i = 0; i <arr.Length-1; i++)
            {
                if (arr[i] % 3 == 0)
                { 
                   elements.Add(arr[i]);
                }
            }
            foreach (int item in elements)
            {
                Console.WriteLine("{0},", elements);
            }
            
            return elements;
             }
                             
            static void PrintSums(int[] arr, int chetni, int nechetni)
        {
            Console.WriteLine("SumChetni:  {0}", chetni);
            Console.WriteLine("SumNeChetni:  {0}", nechetni);
            Console.Write("{0},", elements);
            
        }
       
        static void Main(string[] args)
        {
           int[] arr = new int[7]{ 1, 2, 3, 4, 5, 6,7 };

           // PrintSums(arr,  chetni, nechetni);
           DevideList(arr);
        }

    }
}


