using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumArray = 0;
            Console.WriteLine("Введіть розмір масиву ");
            int array_size = int.Parse(Console.ReadLine());
            Console.Write("Масив [ ");
            for (int i = 0; i < RandomArray(array_size).Length; i++)
            {
                Console.Write(RandomArray(array_size)[i]+ " ");  
            }
            Console.Write("]");
            Console.WriteLine();
            int kilkist = 0;
            for (int i = 0; i < RandomArray(array_size).Length; i++)
            {
                if (RandomArray(array_size)[i] > 0 && kilkist < 3)
                {
                    sumArray += RandomArray(array_size)[i];
                    kilkist++;
                }

            }
            kilkist = 0;
            for (int i = RandomArray(array_size).Length -1; i >= 0; i--)
            {
                if (RandomArray(array_size)[i] > 0 && kilkist < 6)
                {
                    sumArray += RandomArray(array_size)[i];
                    kilkist++;
                }
            }



            Console.WriteLine("Сума перший трьох і останіх шести елементів додатнiх = "+ sumArray);
        }

        static int [] RandomArray(int array_size)
        {
            Random random= new Random();
            int[] array = new int[array_size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50,50);
            }
            return array;
        }
    }
}
