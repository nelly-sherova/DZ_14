using System;
using System.Collections.Generic;

namespace HomeWork14
{
    static class Calculator
    {
        public static T Sum<T>(T a, T b)
        {
            return (dynamic)a+(dynamic)b;
        }
        public static T Difference<T>(T a, T b)
        {
            return (dynamic)a-(dynamic)b;
        }
        public static T Multiplication<T>(T a, T b)
        {
            return (dynamic)a*(dynamic)b;
        } 
        public static T Division<T>(T a, T b)
        {
            return (dynamic)a/(dynamic)b;
        }
    }
    class Program
    {
        delegate T Operation <T> (T x, T y);
        static void Main(string[] args)
        {
            
            bool working = true;
            string command;
            //double a, b;
            //decimal a, b;
            //float a, b;
            int a, b;
            while (working)
            {
                Console.WriteLine("Choose a command:  \n+, \n-, \n*, \n/, \n0 -> Выход");
                command = Console.ReadLine();
                switch (command)
                {
                    case "+":
                        Console.Write("a = ");
                        // a = Convert.ToDouble(Console.ReadLine());
                        // a = Convert.ToDecimal(Console.ReadLine());
                        // a = Convert.ToFloat(Console.ReadLine());
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b = ");
                        b = Convert.ToInt32(Console.ReadLine());
                        // b = Convert.ToDouble(Console.ReadLine());
                        // b = Convert.ToDecimal(Console.ReadLine());
                        // b = Convert.ToFloat(Console.ReadLine());
                        Operation<int> sum = Calculator.Sum<int>;
                        //Operation<double> sum = Calculator.Sum<double>;
                        //Operation<float> sum = Calculator.Sum<float>;
                        //Operation<decimal> sum = Calculator.Sum<decimal>;
                        int result = sum.Invoke(a, b);
                        //double result = sum.Invoke(a, b);
                        //decimal result = sum.Invoke(a, b);
                        //float result = sum.Invoke(a, b);
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;
                }
            }
        }
    }
}
