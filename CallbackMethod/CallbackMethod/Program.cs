namespace CallbackMethod
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);

        static void Callback(int x, int y, CalcDelegate dele)
        {
            dele(x, y);
        }

        static void Plus(int x, int y) { Console.WriteLine(x + y); }
        static void Minus(int x, int y) { Console.WriteLine(x - y); }
        static void Mul(int x, int y) { Console.WriteLine(x * y); }
        static void Div(int x, int y) { Console.WriteLine(x / y); }
        static void Main()
        {
            CalcDelegate plus = Plus;
            CalcDelegate minus = Minus;
            CalcDelegate mul = Mul;
            CalcDelegate div = Div;

            Callback(20, 10, plus);
            Callback(20, 10, minus);
            Callback(20, 10, mul);
            Callback(20, 10, div);
        }
    }
}