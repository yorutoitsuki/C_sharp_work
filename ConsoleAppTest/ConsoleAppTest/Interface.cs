using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal interface Interface
{
    public abstract void Draw();
    public abstract void Move(int offset);
}

interface IDrawinigObject
{
    void Draw();
    void Move(int offset);
}

class Computer
{

}

interface IMonitor
{
    void TurnOn();
}

interface Ikeyboard { }

class Notebook : Computer, IMonitor, Ikeyboard
{
    public void TurnOn() {
    }
   /*void IMonitor.TurnOn()
    {
    }*/
}

class InterfaceMain
{
    static void Main(string[] args)
    {
        Notebook notebook = new Notebook();
        notebook.TurnOn();
    }
}



