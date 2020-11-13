using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "long post. very long. here, now it's longer";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int> { 1, 3, 5, 2, 10, 17 };
            var max = numbers.Max();

            System.Console.WriteLine("Max: " + max);
            System.Console.WriteLine(shortenedPost + "...");
        }
    }
}
