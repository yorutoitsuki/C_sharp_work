namespace ConsoleEvent
{
    class Program
    {
        public delegate void ButtonEvent();
        public static event ButtonEvent evtClick;
        public static void onClick()
        {
            evtClick();
        }
        public static void MyHandler()
        {
            Console.WriteLine("버튼 클릭 처리기 수행");
        }
        static void Main()
        {
            evtClick += new ButtonEvent(MyHandler);
            onClick();
        }
    }
}