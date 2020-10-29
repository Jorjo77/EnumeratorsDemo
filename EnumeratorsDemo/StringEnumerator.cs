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

        public string Current => Array[index];

        object IEnumerator.Current => throw new NotImplementedException();

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
