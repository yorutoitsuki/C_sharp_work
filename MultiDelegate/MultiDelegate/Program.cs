namespace MultiDelegate
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);
        static void Plus(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Minus(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Multiple(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            CalcDelegate del1 = Plus;
            CalcDelegate del2 = Minus;
            CalcDelegate del3 = Multiple;
            CalcDelegate del4 = Divide;

            del1 += del2;
            del1 += del3;
            del1 += del4;

            del1(20, 10);

            del1 -= del3;
            del1 -= del4;

            del1(20, 10);

        }
    }
}