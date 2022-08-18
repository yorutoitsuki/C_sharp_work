using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IDrawingObject
{
    void Draw();
}

class Line : IDrawingObject
{
    public void Draw()
    {
        Console.WriteLine("Line");
    }
}

class Rectangle : IDrawingObject
{
    public void Draw()
    {
        Console.WriteLine("Rectangle");
    }
}

class InterfaceMain
{
    static void Main(String[] args)
    {
        IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };

        foreach (IDrawingObject item in instances)
        {
            item.Draw();
        }
    }
}





