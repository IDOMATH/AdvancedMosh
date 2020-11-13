namespace Generics
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            //    var numbers = new GenericList<int>();
            //    numbers.Add(10);

            //    var books = new GenericList<Book>();
            //    books.Add(new Book());

            //    var dictionary = new GenericDictionary<string, Book>();
            //    dictionary.Add("12345", new Book());

            var number = new Nullable<int>(5);
            System.Console.WriteLine(number.HasValue);
            System.Console.WriteLine(number.GetValueOrDefault());

            var num = new Nullable<int>();
            System.Console.WriteLine(num.HasValue);
            System.Console.WriteLine(num.GetValueOrDefault());
        }
    }
}
