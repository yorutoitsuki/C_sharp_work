using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int GetresultDelegate();

class Target
{
    public void Do(GetresultDelegate getResult)
    {
        Console.WriteLine(getResult());
    }
}

class Source
{
    public int GetResult()
    {
        return 10;
    }
    public void Test()
    {
        Target target = new Target();
        target.Do(new GetresultDelegate(this.GetResult));
    }
}

namespace DelegateCallBack
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
