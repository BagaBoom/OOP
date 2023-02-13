using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_OOP_2
{
    internal class Program
    {
        const double g = 9.80665;
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть данi");
            Console.Write("Введiть масу m = ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введiть висоту h = ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Введiть швидкiсть v = ");
            double v = double.Parse(Console.ReadLine());

            Console.WriteLine("Кiнетизна  енергiя = " + KineticEnergy(m, v) + " Dж");
            Console.WriteLine("Потенцiйна енергiя = " + PotentialEnergy(m,h) + " Dж");


        }

        static double KineticEnergy(double m , double v)
        {
            return (m* Math.Pow(v,2))/2;
        }

        static double PotentialEnergy(double m , double h)
        {
            return m*g*h;
        }
    }
}
