using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174P_Event
{
    internal class Program
    {
        public delegate void ButtonEvent();
        public static event ButtonEvent evtClik;
        public static void onClick()
        {
            evtClik();
        }
        public static void MyHandler()
        {
            Console.WriteLine("버튼 클릭 처리기 수행");
        }
        static void Main(string[] args)
        {
            evtClik += new ButtonEvent(MyHandler);
            onClick();
        }
    }
}
