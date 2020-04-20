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
                    case "-":
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
                        Operation<int> dif = Calculator.Difference<int>;
                        //Operation<double> dif = Calculator.Difference<double>;
                        //Operation<float> dif = Calculator.Difference<float>;
                        //Operation<decimal> dif = Calculator.Difference<decimal>;
                        int result1 = dif.Invoke(a, b);
                        //double result1 = dif.Invoke(a, b);
                        //decimal result1 = dif.Invoke(a, b);
                        //float result1 = dif.Invoke(a, b);
                        Console.WriteLine($"{a} - {b} = {result1}");
                        break;
                    case "*":
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
                        Operation<int> mul = Calculator.Multiplication<int>;
                        //Operation<double> mul = Calculator.Multiplication<double>;
                        //Operation<float> mul = Calculator.Multiplication<float>;
                        //Operation<decimal> mul = Calculator.Multiplication<decimal>;
                        int result2 = mul.Invoke(a, b);
                        //double result2 = mul.Invoke(a, b);
                        //decimal result2 = mul.Invoke(a, b);
                        //float result2 = mul.Invoke(a, b);
                        Console.WriteLine($"{a} * {b} = {result2}");
                        break;
                    case "/":
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
                        Operation<int> div = Calculator.Division<int>;
                        //Operation<double> div = Calculator.Division<double>;
                        //Operation<float> div = Calculator.Division<float>;
                        //Operation<decimal> div = Calculator.Division<decimal>;
                        int result3 = div.Invoke(a, b);
                        //double result3 = div.Invoke(a, b);
                        //decimal result3 = div.Invoke(a, b);
                        //float result3 = div.Invoke(a, b);
                        Console.WriteLine($"{a} * {b} = {result3}");
                        break;
                }
            }
        }
    }
}
