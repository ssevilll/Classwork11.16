using Classwork11._16.Task1.Enums;

namespace Classwork11._16.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aznAmount = 100;
            Program program = new Program();
            double usdAmount = program.Exchange(aznAmount, Currecy.Usd);
            double eurAmount = program.Exchange(aznAmount, Currecy.Eur);
            double tryAmount = program.Exchange(aznAmount, Currecy.Try);
            Console.WriteLine($"{aznAmount} AZN is {usdAmount} USD");
            Console.WriteLine($"{aznAmount} AZN is {eurAmount} EUR");
            Console.WriteLine($"{aznAmount} AZN is {tryAmount} TRY");
        }
        public double Exchange(double azn, Enum currecy)
        {
            if (currecy is Currecy)
            {
                switch (currecy)
                {
                    case Currecy.Usd:
                        return azn / 1.7;
                    case Currecy.Eur:
                        return azn / 1.8;
                    case Currecy.Try:
                        return azn / 0.09;
                    default:
                        return 0;
                }
            }
            else
            {
                throw new ArgumentException("Invalid currency type.");
            }
        }
    }
}
