using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularPolygon obj1 = new RegularPolygon(3, 7.5);
            RegularPolygon obj2 = new RegularPolygon(3, 7.5);
            RegularPolygon obj3 = new RegularPolygon(15, 7.5);
            Console.WriteLine("Перший об'єкт");
            Console.WriteLine(obj1.ToString());

            Console.WriteLine("Другий об'єкт");
            Console.WriteLine(obj2.ToString());

            Console.WriteLine("Третій об'єкт");
            Console.WriteLine(obj3.ToString());
            Console.WriteLine($"(Перший об'єкт == Другому) = {obj1 == obj2}");

        }
    }

    class RegularPolygon
    {

        private int top;
        private double describedRadius; //описаний радіус

        public RegularPolygon(int top, double describedRadius)
        {
            this.top = top;
            this.describedRadius = describedRadius;
        }

        public double area()
        {
            return 0.5 * (top * side()) * inscribedRadius();
        }

        public double side()
        {
            return 2 * describedRadius * Math.Sin(180 / top);
        }

        public double inscribedRadius()
        {// Вписаний радіус
            return describedRadius * Math.Cos(180 / top);
        }
        public override string ToString()
        {
            return $"Кiлькiсть вершин = {top}\nРадiус описаного кола = {describedRadius}\nПлоща = {area()}\n";
        }
        public static bool operator ==(RegularPolygon obj, RegularPolygon obj0)
        {
            if (obj.top == obj0.top && obj.describedRadius == obj0.describedRadius)
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(RegularPolygon obj, RegularPolygon obj0)
        {
            if (obj.top == obj0.top && obj.describedRadius == obj0.describedRadius)
            {
                return true;
            }
            return false;
        }
    }
    

}

