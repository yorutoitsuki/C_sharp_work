using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Currency
{
    decimal money;
    public decimal Money { get { return money; } }
    public Currency(decimal money)
    {
        this.money = money;
    }
}

public class Won : Currency
{
    public Won(decimal money) : base(money) { }
    public override string ToString()
    {
        return Money + " Won";
    }
}

public class Dollar : Currency
{
    public Dollar(decimal money) : base (money) { }
    public override string ToString()
    {
        return Money + " Dollar";
    }
}
public class Yen : Currency
{
    public Yen(decimal money) : base(money) { }
    public override string ToString()
    {
        return Money + " Yen";
    }
    static public implicit operator Won(Yen yen)
    {
        return new Won(yen.Money * 13m);
    }
}

namespace C_sharp_ch4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(13);

            
        }
    }
}
