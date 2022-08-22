using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mathmatics
{
    delegate int CalcDelegate(int x, int y);

    static int Add(int x, int y) { return x + y; }
    static int Sub(int x, int y) { return x - y; }
    static int Mul(int x, int y) { return x * y; }
    static int Div(int x, int y) { return x / y; }

    CalcDelegate[] methods;
    public Mathmatics()
    {
        //static 메서드를 가리키는 델리게이트 배열 초기화
        methods = new CalcDelegate[] { Mathmatics.Add, Mathmatics.Sub, Mathmatics.Mul, Mathmatics.Div };
    }

    //methods 배열에 담긴 델리게이트를 opCode 인자에 따라 호출
    public void Calculate(char opCode, int operand1, int operand2)
    {
        switch (opCode)
        {
            case '+':
                Console.WriteLine("+: " + methods[0](operand1, operand2));
                break;
            case '-':
                Console.WriteLine("-: " + methods[1](operand1, operand2));
                break;
            case '*':
                Console.WriteLine("*: " + methods[2](operand1, operand2));
                break;
            case '/':
                Console.WriteLine("/: " + methods[3](operand1, operand2));
                break;
        }
    }
}

namespace ch4_delegate
{
    internal class Program
    {
        static void Main(string[] agrs)
        {

        }
    }
}
