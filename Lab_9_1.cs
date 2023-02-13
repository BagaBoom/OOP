using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("Щоб завершити програму введiть х = 0");
            do
            {
                Input(out x, out y, out z);
                if (x == 0)
                {
                    Console.WriteLine("Завершення програми");
                    break;
                }
                Console.WriteLine("Результат = " + Calculation(x, y, z));
                XResultVoid(x);
                Console.WriteLine("_____________________________________________________");
            } while (true);
        }

        static void Input(out double x, out double y, out double z)
        {
            Console.Write("Введiть х = ");
            x = double.Parse(Console.ReadLine());
            if(x != 0)
            {
                Console.Write("Введiть y = ");
                y = double.Parse(Console.ReadLine());
                Console.Write("Введiть х = ");
                z = double.Parse(Console.ReadLine());
            }
            else
            {
                y = 0.0;
                z = 0.0;
            }
            
        }

        static void XResultVoid(double x)
        {
            if(x < 0)
            {
                Console.WriteLine("Негативне x");
            }
            else
            {
                Console.WriteLine("Позитвне x");
            }
            if (x < -10)
            {
                Console.WriteLine("Менше за -10");
            }
            else if (x < -1)
            {
                Console.WriteLine("Менше за -1");
            }
            else if(x < 10)
            {
                Console.WriteLine("Бiльше за 1");
            }
            else
            {
                Console.WriteLine("Бiльше за 10");
            }
        }
        static double Calculation(double x, double y, double z)
        {
            double a = x + (Math.Pow(z, 2) / (3 + z * Math.Sin(y)));
            return a;
        }
    }
}
