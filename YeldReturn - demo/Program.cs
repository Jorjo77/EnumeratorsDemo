using System;
using System.Collections;
using System.Collections.Generic;
using static System.ArraySegment<T>;

namespace YeldReturn___demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // С yield return можем да връщаме и IEnumerable и IEnumerator
            //yield return си построява Enumerator автоматично отдолу

            //foreach (var name in GetNames())
            //{
            //    Console.WriteLine(name);
            //    Console.WriteLine("In the foreach");
            //}
            //закоментирания форийч горе работи като кода долу кода прави едно и също (горното като се компилира става това отдолу):
            //42 min нов пример!
            IEnumerator enumerator = GetNames().GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
        public static IEnumerable<string> GetNames()
        {
            yield return "Gosho";
            Console.WriteLine("In the method");
            yield return "Pesho";
            Console.WriteLine("Sled Pesho sam");
            yield return "Dimo";
            Console.WriteLine("In the method");
        }
    }
}
