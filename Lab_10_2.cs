using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            int[] array = new int[5];
            int kilkist = 0;
            Console.Write("Масив = ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write(array[i] + " ");
                if (array[i] > 1) kilkist++;
            }
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть чисел, бiльше за 1: "+ kilkist);  
        }
    }
}
