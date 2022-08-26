using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("주 스레드 시작");
            ThreadStart ts = new ThreadStart(ThreadFunction);
            Thread thd = new Thread(ts);
            thd.Start();
            Console.WriteLine("스레드 시작 " + thd.ThreadState);
            Console.WriteLine("주 스레드 종료");
        }
        public static void ThreadFunction()
        {
            int count = 0;
            while(count < 10)
            {
                count++;
                Console.WriteLine("스레드 동작 중...");
            }
        }
    }
}
