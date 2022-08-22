﻿using System;
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

delegate bool CompareDelegate(Person arg1, Person arg2);
class SortPerson
{
    Person[] men;

    public SortPerson(Person[] name)
    {
        this.men = name;
    }

    public void Sort(CompareDelegate compareMethod)
    {
        Person temp;
        for (int i = 0; i < men.Length; i++)
        {
            int lowPos = i;
            for (int j = 0; j < men.Length; j++)
            {
                /*if (men[j].Age < men[lowPos].Age)
                {
                    lowPos = j;
                }*/
                if (compareMethod(men[j], men[lowPos]))
                {
                    lowPos = j;
                }
            }

            temp = men[lowPos];
            men[lowPos] = men[i];
            men[i] = temp;
        }
    }
    public void Display()
    {
        for (int i = 0; i < men.Length; i++)
        {
            Console.WriteLine(men[i] + ",");
        }
    }
}


namespace CallBack_Person
{
    internal class Program
    {
        static bool AscSortByName(Person arg1, Person arg2)
        {
            /*
             * string 객체의 CompareTo 매서드는 문자열 비교를 수행
             * 문자열이 사전 정렬순으로 비교해서 크면 1, 같으면 0, 작으면 -1을 반환
             * 따라서 0 보다 작은 값을 반환한 경우 true로 가정하면 오름차순 정렬
             */
            return arg1.Name.CompareTo(arg2.Name) < 0;
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

            SortPerson so = new SortPerson(personArray);
            so.Sort(AscSortByName);
            so.Display();

        }
    }
}
