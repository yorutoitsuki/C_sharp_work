using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack_Pratic
{
    class SortObject
    {
        int[] numbers;

        public SortObject(int[] numbers)
        {
            this.numbers = numbers;
        }

        public delegate bool CompareDelegate(int arg1, int arg2);

        public void sort(CompareDelegate compareMethod)
        {
            int temp;
            for(int i=0; i < numbers.Length; i++)
            {
                int lowPos = i;
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (compareMethod(numbers[j], numbers[lowPos]))
                    {
                        //if(number[i] < number[j]) || if(number[i] > number[j]
                        lowPos = j;
                    }
                    
                }
                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void Display()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            so.sort(AscendingCompare);
            so.Display();

            Console.WriteLine();

            so.sort(DescendingCompare);
            so.Display();
        }
        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }
        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
    }
    
}
