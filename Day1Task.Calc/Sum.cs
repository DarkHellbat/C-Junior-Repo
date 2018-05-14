using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Task.Calc
{
    public class Ops
    {
        static double c;
        public static void Sum(int a, int b)
        {
             c = a + b;

        }
        public static void Min(int a, int b)
        {
            c = a - b;

        }
        public static void Pow (int a, int b)
        {
            c = Math.Pow(a, b);
        }
        public static void Mult(int a, int b)
        {
             c = a * b;

        }
        public static void Div(int a, int b)
        {
             c = a / b;

        }
        public static void Result()
        {
            Console.WriteLine(String.Format("Результат операции равен {0}", c));
            Console.ReadKey();
        }
    }
}
