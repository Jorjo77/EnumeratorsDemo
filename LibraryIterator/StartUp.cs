using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            //тук  за сортировка подаваме нашия клас компарер:
            SortedSet<Book> sortedList = new SortedSet<Book>(new BooksComparer())
            {
                bookOne, bookTwo, bookThree
            };
            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Title} - {item.Year}");
            }



            //Library library = new Library(bookOne, bookTwo, bookThree);
            //foreach (var book in library)
            //{
            //    Console.WriteLine(book.Title);
            //}

            //bookOne.CompareTo(55);
            //bookOne.CompareTo(bookTwo);

            //var  books = new List<Book>() { bookOne, bookTwo, bookThree };
            //Имплементация на CompareTo (ама нещо не работеше):
            //int min = 0;
            //for (int i = 0; i < books.Count; i++)
            //{
            //    for (int j = i; j < books.Count; j++)
            //    {
            //        //if (books[min] > books[j])това е същото като това долу:
            //        //{

            //        //}
            //        if (books[min].CompareTo(books[j]) > 0)
            //        {
            //            min = j;
            //        }
            //    }
            //    var temp = books[min];
            //    books[min] = books[i];
            //    books[i] = temp;
            //}

            //books.Sort();

            //foreach (var item in books)
            //{
            //    Console.WriteLine($"{item.Title} - {item.Year}");
            //}
        }
    }
}
