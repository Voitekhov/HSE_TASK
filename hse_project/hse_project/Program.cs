using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hse_project
{
    class Program
    {
        public static int sum (int a, int b)
            {
                return a+b;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Sasha Pestova");
            Console.WriteLine(sum(5, 3));

            Console.ReadKey();
        }
    }
}
