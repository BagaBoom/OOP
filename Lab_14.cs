using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            Four_Pointed_Star[] arrayStar = new Four_Pointed_Star[6];
            for (int i = 0; i < arrayStar.Length; i++)
            {
                arrayStar[i] = new Four_Pointed_Star(random.Next(1,20),random.Next(1,20));
                Console.WriteLine(arrayStar[i].ToString());
            }
           
            Array.Sort(arrayStar, new Star_Comparer());
            Console.WriteLine("------------------------------------------------");
            foreach (Four_Pointed_Star star in arrayStar)
            {
                Console.WriteLine(star.ToString());
            }

        }

    }
    interface IArea_Star
    {
        double Area_Star();
    }
    class Four_Pointed_Star : IArea_Star
    {
        private double a;
        private double b;
        public Four_Pointed_Star()
        {
            a = 0.0;
            b = 0.0;
        }
        public Four_Pointed_Star(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double get_A()
        {
            return a;
        }
        public double get_B()
        {
            return b;
        }

        public double Area_Star()
        {
            return 0.5 * ((a / 2) - (b / 2)) * b;
        }

        public override string ToString()
        {
            return $"Area Star = {Area_Star()}";
        }
    }
    class Star_Comparer : IComparer
    {
        public int Compare(object x , object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Four_Pointed_Star)x).Area_Star(), ((Four_Pointed_Star)y).Area_Star());
        }
    }
}
