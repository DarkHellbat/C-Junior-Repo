using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Task.Calc
{
    class Program
    {
        static int a, b;
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите операцию, которую хотите выполнить - Sum(1), Min(2), Mult(3), Div(4), Pow(5)");
            string choise = Console.ReadLine();
            Console.WriteLine("Введите числo 1");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числo 2");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case "1":
                    {
                        Ops.Sum(a,b);
                        break;
                    }
                case "2":
                    {
                        Ops.Min(a, b);
                        break;
                    }
                case "3":
                    {
                        Ops.Mult(a, b);
                        break;
                    }
                case "4":
                    {
                        Ops.Div(a, b);
                        break;
                    }
                case "5":
                    {
                        Ops.Pow(a, b);
                        break;
                    }
            }
            Ops.Result();

        }
    }
}
