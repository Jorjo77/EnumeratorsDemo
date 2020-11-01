using IteratorsAndComparators;
using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            ////тук  за сортировка подаваме нашия клас компарер:
            //SortedSet<Book> sortedList = new SortedSet<Book>()
            //{
            //    bookOne, bookTwo, bookThree
            //};
            Library library = new Library(bookOne, bookTwo, bookThree);
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
