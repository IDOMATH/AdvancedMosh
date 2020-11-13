using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO STEP by step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET web api", Price = 12 },
                new Book() {Title = "C# ADvanced topics", Price = 7 },
                new Book() {Title = "C# ADvanced topics", Price = 9 }
            };
        }
    }
}
