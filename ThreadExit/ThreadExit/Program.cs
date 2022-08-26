using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("주 스레드 시작 : " + Thread.CurrentThread.GetHashCode());
            ThreadStart ts = new ThreadStart(ThreadFunction);
            Thread thd = new Thread(ts);
            thd.Start();
            Console.WriteLine("스레드 시작 " + thd.GetHashCode());
            Console.WriteLine("주 스레드 종료");
            Thread.Sleep(100);
            //thd.Abort();
            thd.Join();
        }
        public static void ThreadFunction()
        {
            try
            {
                int count = 0;
                while(count < 1000)
                {
                    count++;
                    Console.WriteLine("스레드 동작중 ..." + count);
                }
                Console.WriteLine("정상 종료");
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("Abort 예외 발생 : " + e);
            }
            finally
            {
                Console.WriteLine("finally!!");
            }
            Console.WriteLine("스레드 식별 : " + Thread.CurrentThread.GetHashCode());
        }
    }
}
