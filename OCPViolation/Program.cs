using OCPViolation.Model;

namespace OCPViolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(101, "Joshit", 50000, 3, FestivalTypes.HOLI);
            Console.WriteLine("SIMPLE INTREST IS "+fd1.CalculateSimpleIntrest());
        }
    }
}