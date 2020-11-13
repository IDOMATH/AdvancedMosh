using System;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //object obj = "Blane";

            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            // We know this object will have the optimize method at run time so we can use dynamic typing keyword
            //dynamic excelObject = "blane";
            //excelObject.Optimize();

            dynamic a = 10;
            a = "hi";
        }
    }
}
