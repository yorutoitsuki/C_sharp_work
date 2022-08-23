using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    public interface IComparer
    {
        //X가 Y보다 크면1, 같으면 0, 작다면 -1을 반환하는 것으로 약속된 메서드
        int Compare(Object x, Object y);
    }
}
class IntegerCompare : IComparer
{
    //IComparer 인터페이스의 Compare 메서드를 구현
    //이 메서드는 Array.Sort 메서드 내에서 콜백으로 호출됨
    public int Compare(object x, object y)
    {
        int xValue = (int)x;
        int yValue = (int)y;

        if (xValue > yValue) return -1;
        else if (xValue == yValue) return 0;
        return 1;
    }
}

namespace Ex_4._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            //IComparer를 상속받은 IntegerCompare 인스턴스 전달
            Array.Sort(intArray, new IntegerCompare());
            foreach (int item in intArray)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
