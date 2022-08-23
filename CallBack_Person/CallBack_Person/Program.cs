using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public int Age;
    public string Name;

    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public override string ToString()
    {
        return Name + ": " + Age;
    }
}

delegate bool CompareDelegate(object arg1, object arg2);//이름, 나이 상관 없이 정렬 하기 위해 object로 타입선언
class SortObject
{
    Object[] things;

    public SortObject(object[] things)
    {
        this.things = things;
    }

    public void Sort(CompareDelegate compareMethod)
    {
        object temp;
        for (int i = 0; i < things.Length; i++)
        {
            int lowPos = i;
            for (int j = i+1; j < things.Length; j++)
            {
                /*if (men[j].Age < men[lowPos].Age)
                {
                    lowPos = j;
                }*/
                if (compareMethod(things[j], things[lowPos]))
                {
                    lowPos = j;
                }
            }

            temp = things[lowPos];
            things[lowPos] = things[i];
            things[i] = temp;
        }
    }
    public void Display()
    {
        for (int i = 0; i < things.Length; i++)
        {
            Console.WriteLine(things[i] + ",");
        }
    }
}


namespace CallBack_Person
{
    internal class Program
    {
        static bool AscSortByName(Object arg1, Object arg2)
        {
            Person person1=null;
            Person person2=null;
            if (arg1 is Person)
            {
                person1 = arg1 as Person;//대상 타입으로 형변환
            }
            if(arg2 is Person)
            {
                person2 = arg2 as Person;
            }
            
            //대상 타입으로 형변환
            /*
             * string 객체의 CompareTo 매서드는 문자열 비교를 수행
             * 문자열이 사전 정렬순으로 비교해서 크면 1, 같으면 0, 작으면 -1을 반환
             * 따라서 0 보다 작은 값을 반환한 경우 true로 가정하면 오름차순 정렬
             */
            return person1.Name.CompareTo(person2.Name) < 0;
        }
        static void Main(string[] args)
        {
            Person[] personArray = new Person[]
            {
                new Person(51, "Anders"),
                new Person(37, "Scott"),
                new Person(45, "Peter"),
                new Person(62, "Mads")
            };

            SortObject so = new SortObject(personArray);
            so.Sort(AscSortByName);
            so.Display();

        }
    }
}
