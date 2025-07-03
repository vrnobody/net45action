using System;

namespace net45action
{
    public static class Utils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1 + 2 = {Utils.Add(1, 2)}");
        }
    }
}
