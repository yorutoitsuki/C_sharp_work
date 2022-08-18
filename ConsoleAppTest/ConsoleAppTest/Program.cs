class Mammal
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
}

class Program
{
    static void Main(string[] args)
    {
        Mammal one = new Lion();
        Mammal two = new Whale();
        Mammal three = new Human();

        one.move();
        two.move();
        three.move();
    }
}