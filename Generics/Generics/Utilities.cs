using System;

namespace Generics
{
    partial class Program
    {
        public class Utilities<T> where T : IComparable, new()
        {
            public int Max(int a, int b)
            {
                return a > b ? a : b;
            }
            public T Max<T>(T a, T b) where T: IComparable
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
            public void DoSomething(T value)
            {
                var obj = new T();
            }

        }
    }
}
