using System;

namespace TCOverloading
{
    internal class Program
    {
        
        public static int Add(int a, int b)
        {
            return a+b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool doll)
        {
            return $"{a + b}" + (doll ? " dollar" + (a + b > 1 ? "s" : ""): "");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(11,1));
            Console.WriteLine(Add(2,0));
            Console.WriteLine(Add(3,3, false));
            Console.WriteLine(Add(94,4));
            Console.WriteLine(Add(5,5, true));
            Console.WriteLine(Add(0.5m,0.9m));
            Console.WriteLine(Add(0.2m,0.7m));
            Console.WriteLine(Add(8,8));
            Console.WriteLine(Add(9,9,true));
            Console.WriteLine(Add(10,10, false));
        }

    }
}
