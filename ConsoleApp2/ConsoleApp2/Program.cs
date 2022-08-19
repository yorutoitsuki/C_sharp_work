namespace Delegate
{
    class Program
    {
        delegate int CalcDelegate(int x, int y);

        static int Plus(int x, int y)
        {
            return x + y;
        }
        static int Minus(int x, int y)
        {
            return x - y;
        }

        static void Main()
        {
            CalcDelegate del1 = new CalcDelegate(Plus);
            int result = del1(20, 10);
            Console.WriteLine("result = " + result);

            CalcDelegate del2 = new CalcDelegate(Minus);
            result = del2(20, 10);
            Console.WriteLine("result = " + result);
        }
    }
}