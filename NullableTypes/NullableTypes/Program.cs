using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            DateTime? date = null;
            Console.WriteLine("getvalue or default" + date.GetValueOrDefault());
            Console.WriteLine("Has value: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);

            DateTime date2;
            DateTime date3 = date ?? DateTime.Today;


            if (date != null) date2 = date.GetValueOrDefault();
            else date2 = DateTime.Today;


        }
    }
}
