using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("cannot divide by zero");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("sorry, an error occurred");
            //}

            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"C:\logs\log.txt");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("an unexpected error occurred.");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}

            //try
            //{
            //    using (var streamReader = new StreamReader(@"c:\logs\log.txt"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("an error occurred");
            //}

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("IDOMATH");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
