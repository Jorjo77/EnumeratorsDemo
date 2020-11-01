using IteratorsAndComparators;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BooksComparer : IComparer<Book>
    {
        public int Compare( Book x, Book y)
        {
            //return x.Year.CompareTo(y.Year); - това е същото като това долу:
            if (x.Year > y.Year)
            {
                return 1;
            }
            else if (x.Year < y.Year)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
