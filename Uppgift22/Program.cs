using System;
namespace uppgift22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elin hoppade 2 Meter);");
            double Elinhopp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Alma hoppade 1 Meter");
            double almahopp = Convert.ToDouble(Console.ReadLine());

            double skillnad = Elinhopp - almahopp;

            Console.WriteLine("Elin hoppade 1 meter längre än Alma");
        }
    }
}