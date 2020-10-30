using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    class CustomList<T>
    {
        private T[] array;
        private int index = 0;

        public CustomList()
        {
            array = new T[8];
        }
        public IEnumerator<T> GetEnumerator()
        {
            //return null;така нашия енумератор е готов, yield return е съкратен запис на нашия енумератор.
            Console.WriteLine("Starting");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("in the yield method");
                yield return array[i]; //yield return казва върни един елемент във форийча
            }
        }
        public void Add(T element)
        {
            array[index] = element;
            index++;
        }
    }
}
