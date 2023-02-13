using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введiть своє Прiзвище i'мя по батьковi!");
            int a = 0;
            string[] PIB = Console.ReadLine().Split(' ');
            string student = "студент IПЗ-21008б";
            string result = "";
            
            foreach (string s in PIB)
            {
                Console.WriteLine(s + " довжина  = " + s.Length);
                result += s + " ";
            }
            string surname = PIB[0];
            for (int i = 0; i < PIB[0].Length; i++)
            {
                if (surname[i] == 'а' || surname[i] == 'a')
                {
                    a++;
                }
            }
            Console.WriteLine("У Прiзвищi букв 'a' = " + a);
            Console.WriteLine(result + "- "+ student);

        }
    }
}
