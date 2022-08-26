using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackMethod2
{
    internal class Program
    {
        delegate void CalcDelegate(int x, int y);
        static void Callback(int x, int y, CalcDelegate dele)
        {
            dele(x, y);
        }
        static void Main(string[] args)
        {

        }
    }
}
