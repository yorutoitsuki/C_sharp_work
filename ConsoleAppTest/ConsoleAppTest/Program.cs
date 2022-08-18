/*class Mammal
{
    virtual public void move()
    {
        Console.WriteLine("이동한다");
    }
}
class Lion : Mammal
{
    public override void move()
    {
        Console.WriteLine("네 발로 움직인다.");
    }
}
class Whale : Mammal
{
    public override void move()
    {
        Console.WriteLine("수영을 한다");
    }
}
class Human : Mammal
{
    public override void move()
    {
        Console.WriteLine("두 발로 움직인다");
    }
}*/

interface ISource
{
    int GetResult();
}

class Source : ISource
{
    public int GetResult()
    {
        return 10;
    }
    
    public void Test()
    {
        Target target = new Target();
        target.Do(this);
    }
}

class Target
{
    public void Do(ISource obj)
    {
        Console.WriteLine(obj.GetResult());
    }
}

class Program
{
    private static void Main(string[] args)
    {
        /*Mammal one = new Lion();
        Mammal two = new Whale();
        Mammal three = new Human();

        one.move();
        two.move();
        three.move();*/

        /* IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };

         foreach (IDrawingObject item in instances)
         {
             item.Draw();
         }
         IDrawingObject instance = new Line();
         instance.Draw();*/

        Source sc = new Source();
        sc.Test();

    }
}