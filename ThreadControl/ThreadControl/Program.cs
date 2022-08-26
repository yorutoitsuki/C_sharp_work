using System;
using System.Threading;

namespace ThreadControl
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
            Thread.Sleep(3000);
            //thd.Abort();
            thd.Suspend();
            Console.WriteLine("스레드 일시정지");
            Thread.Sleep(3000);
            thd.Resume();
            Console.WriteLine("스레드 다시시작");
            thd.Join();
        }
        public static void ThreadFunction()
        {
            try
            {
                int count = 0;
                while (count < 1000)
                {
                    count++;
                    Console.WriteLine("스레드 동작 중 ... " + count);
                    Thread.Sleep(1000);
                }
                Console.WriteLine("정상 종료");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Aort 예외발생 : " + e);
                Thread.ResetAbort();
            }
        }
    }
}
