using ClassLibrary;

namespace Pakethantering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();
            Console.WriteLine(greeter.SayHello());
        }
    }
}
