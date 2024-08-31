using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Check<int> check1 = new Check<int>();
            check1.Input();
            Console.WriteLine(check1.Output());

            Check<string> check2 = new Check<string>();
            check2.Input();
            Console.WriteLine(check2.Output());
            Console.ReadKey();
        }
    }
}
