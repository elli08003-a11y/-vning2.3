using System;
namespace Övning2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många extra dagar ska du hyra blien.");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många km ska du tänker du köra.");
            int km = int.Parse(Console.ReadLine());
            int kostnad = (km + (d * 500) + 300);
            Console.WriteLine("Din totala kostnad är " + kostnad + "kr");
        }
    }
}