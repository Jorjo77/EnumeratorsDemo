using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        //public int CompareTo(Book other)
        //{
        //    int result = this.Year.CompareTo(other.Year);
        //    if (result==0)
        //    {
        //        result = this.Title.CompareTo(other.Title);
        //    }
        //    return result;
        //}

        //public int CompareTo(Book other)
        //{
        //    if (this.Year <= other.Year)
        //    {
        //        return -1;
        //    }
        //    if (Year == other.Year)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
