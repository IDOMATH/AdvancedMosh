using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> square = number => number * number;

            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;

            //Console.WriteLine(multiplier(10));
            //Console.WriteLine(square(5));
            //Console.WriteLine(Square(5));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 10);

            //    var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        static int Square(int number)
        {
            return number * number;
        }
    }
}
