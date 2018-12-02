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
        static List<int> GetList()
        {
            List<int> elements = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                elements.Add(i + 2);
            }
            foreach (int item in elements)
            {
                Console.Write("{0},", item);
            }
            return elements;
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
            GetList();
            RemoveFromList(elements, index);
            PrintResultList(elements);
        }

    }
}


