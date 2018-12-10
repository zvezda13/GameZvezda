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
        static List<string> GetList()
        {
            Console.WriteLine("Please enter strings to the list 'exit' will end it");
            List<string> elements = new List<string>();
            while (!elements.Contains("exit"))
            {
                elements.Add(Console.ReadLine());
            }
            return elements;
        }
        static void PrintList(List<string> elements)
        {
            foreach (string item in elements)
            {
                Console.Write("{0} ,", item);
            }
        }

        static void Main(string[] args)
        {
            List<string> elements = GetList();
            PrintList(elements);
        }

    }
}


