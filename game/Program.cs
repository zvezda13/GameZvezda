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
        static void PrintReverseArray()
        {
            Console.WriteLine("Kolko elementa da ima masiva");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Vyvedi masiva");
            for(int i=0;i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = n-1; i >=0; i--)
            {
                Console.Write("{0}",arr1[i]);
            }
        }

        static void Main(string[] args)
        {
            //PrintCentralDiagonal();
            //Console.WriteLine();
            //PrintSecondaryDiagonal();
            //Console.WriteLine();
            //PrintReverceCentralDiagonal();
            //Console.WriteLine();
            //PrintSecondaryReverseDiagonal();  
            PrintReverseArray();
        }

    }
}


