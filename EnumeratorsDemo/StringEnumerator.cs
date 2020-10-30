using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumeratorsDemo
{
    //IEnumerator е нещото което итерира през колекция
    //когато съм в/у него с Ctrl+. - implement interface и ни излизат методите които интерфейса казва че трябва да имплементираме:
    class StringEnumerator : IEnumerator<string>
    {
        private int index = -1;
        public StringEnumerator(string[] array)
        {
            Array = Array;
        }
        public string[] Array { get; set; }

        //public string Current => Array[index]; това е модерен запис на това долу:
        public string Current
        {
            get
            {
                return Array[index];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            index++;
            if (Array.Length<=index)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
