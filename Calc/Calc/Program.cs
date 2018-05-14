using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length !=2)
            {
                Console.WriteLine("Введите 2 числа");
                return;
            }
Console.WriteLine(Convert.ToInt64(args[0]) + Convert.ToInt64(args[0]));
            Console.ReadKey();
        }
    }
}
