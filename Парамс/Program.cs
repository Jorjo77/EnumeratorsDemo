using System;

namespace Парамс
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames("Pesho", 2,4,4,4,4,5);
        }

        static void PrintNames(string name, params int[] names)
        {
            Console.WriteLine(name);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
