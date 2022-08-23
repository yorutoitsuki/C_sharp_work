using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IObjectToString { };

class Computer { };

class Person : IObjectToString
{
    String name;
    public Person(String name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return "Person : " + this.name;
    }
}

namespace IObject
{
    internal class Program
    {
        private static void DisplayObject(object obj)
        {
            if(obj is IObjectToString)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        static void Main(string[] args)
        {
            DisplayObject(new Computer());
            DisplayObject(new Person("홍길동"));
        }
    }
}
