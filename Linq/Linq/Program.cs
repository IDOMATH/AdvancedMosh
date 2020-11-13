using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Without LINQ, we would have to:
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10) cheapBooks.Add(book);
            //}
            //foreach (var book in cheapBooks) Console.WriteLine(book.Title + " " + book.Price);

            // With LINQ just:

            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // These are LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheapBooks) Console.WriteLine(book);

            Console.WriteLine(books.First(b => b.Title == "C# ADvanced topics").Title);
        }
    }
}
