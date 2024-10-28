using Humanizer;

namespace NuGetStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(2).Humanize());
        }
    }
}
