namespace Interface
{
    public interface ICamera
    {
        void Picture();
        void Video();
    }

    public interface ICallPhone
    {
        void Call();
    }

    public interface INetwork
    {
        void Wifi();
    }

    public class SmartPhone : ICamera, ICallPhone, INetwork
    {
        public void Picture()
        {
            Console.WriteLine("Take Picture");
        }

        public void Video()
        {
            Console.WriteLine("Take Video");
        }

        public void Call()
        {
            Console.WriteLine("Get Call");
        }

        public void Wifi()
        {
            Console.WriteLine("Connect Wifi");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}