using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegate_2
{
    internal class Program
    {
        delegate void CalcDelegate(int x, int y);

        static void add(int x, int y) { Console.WriteLine(x + y); }
        static void sub(int x, int y) { Console.WriteLine(x - y); }
        static void mul(int x, int y) { Console.WriteLine(x * y); }
        static void div(int x, int y) { Console.WriteLine(x / y); }
        static void Main(string[] args)
        {
            CalcDelegate cal = add;
            cal += sub;
            cal += mul;
            cal += div;
            cal(10, 5);
            Console.WriteLine("mul 제거");
            cal -= mul;
            cal(10, 5);
        }
    }
}
