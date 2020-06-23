using System;

namespace SingletonTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var first = func();
            var second = func();

            return ReferenceEquals(first, second);
        }
    }
}