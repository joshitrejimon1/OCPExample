
using OCPSoluction.Model;

namespace OCPSExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Solution--------"); FixedDeposit fd1 = new FixedDeposit(1011, "JOSHIT", 5000, 3, new HoliIntrest());
            Console.WriteLine("SimpleInterest: " + fd1.CalculateSimpleIntrest());
        }
    }
}