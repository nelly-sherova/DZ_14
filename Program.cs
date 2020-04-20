using System;

namespace HomeWork14
{
    static class Calculator
    {
        public static T Sum<T>(T a, T b)
        {
            return a+b;
        }
        public static T Difference<T>(T a, T b)
        {
            return a-b;
        }
        public static T Multiplication<T>(T a, T b)
        {
            return a*b;
        } 
        return static T Division<T>(T a, T b)
        {
            return a/b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
