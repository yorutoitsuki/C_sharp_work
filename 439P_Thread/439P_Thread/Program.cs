using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _439P_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(threadFunc1);
            Thread t = new Thread(threadFunc2);
            t.IsBackground = true;
            thread.Start();
            t.Start();
            Console.WriteLine("Main thread is done");
        }
        static void threadFunc1()
        {
            Console.WriteLine("threadFunc1 is done");
        }
        static void threadFunc2()
        {
            Console.WriteLine("threadFunc2 is done");
        }
    }
}
