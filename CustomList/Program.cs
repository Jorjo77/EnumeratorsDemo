using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //мога да добавям, но не мога да го форийчна липсва IEnumerator. Отиваме в класа и правим такъв метод public IEnumerator<T> GetEnumerator() и форийча работи, е не точно, компилира се! 
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(3);

            foreach (var item in list)
            {
                Console.WriteLine("in the foreach");
                Console.WriteLine(item);
            }
        }
    }
}
