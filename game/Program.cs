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
        List<int> elements = new List<int>();
        static List<int> GetList(List<int> elements)
        {
            for (int i = 0; i < 4; i++)
            {
                elements.Add(i + 2);
            }
            
            return elements;
        }
        static void PrintList(List<int> elements)
        {
            foreach (int item in elements)
            {
                Console.Write("{0},", item);
            }
        }

        static void RemoveFromList(List<int> elements, int index)
        {
            Console.WriteLine("Please enter the index of the item to be removed");
            index = Convert.ToInt32(Console.ReadLine());
            elements.RemoveAt(index);
        }

        static void PrintResultList(List<int> elements)
        {
            foreach (int item in elements)
            {
                Console.Write("{0},", item);
            }
        }


        static void Main(string[] args)
        {
            List<int> elements = new List<int>();
            int index = 0;
            GetList(elements);
            PrintList(elements);
            RemoveFromList(elements, index);
            PrintResultList(elements);
        }

    }
}


