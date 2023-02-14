using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'є', 'ж', 'з', 'и', 'і',
                'ї', 'й', 'к', 'л', 'м', 'н', 'о','п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
                'ч', 'ш', 'щ', 'ь', 'ю', 'я' };
            int alphabet_I = -1;  // змінні для запису позицій співпадаючого символу 
            int ciphered_I = -1;  //та  позиції символу ,на який його необхідно замінити
            Console.WriteLine("Введiть своє Прiзвище i'мя по батьковi!");
            string sentence = Console.ReadLine();
            char[] sentence_array = sentence.ToCharArray(); //переведення рядка в масив символів
            for (int i = 0; i < sentence_array.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (sentence_array[i] == alphabet[j]) // пошук співпадінь алфавіту та робочого рядка
                    {
                        alphabet_I = j;   //якщо умова виконується - значення індексу зберігається
                        break;
                    }

                }
                if (ciphered_I != -1 || alphabet_I != -1) //якщо збіг було знайдено (символ є в алфавіті)
                {
                    if ((alphabet_I < 32) && (alphabet_I >= 0)) //якщо індекс в допустимих межах
                    {
                        ciphered_I = alphabet_I + 3; //виконується зміщення на 3 літери  праворуч (значення 3 було обране ,як найбільш поширене)
                    }
                    if (ciphered_I > 31)   //якщо змінений індекс виходить за межі алфавіту 
                    {
                        ciphered_I -= 32; //віднімаємо 32 ,і таким чином алфавіт зациклюється
                    }
                    sentence_array[i] = alphabet[ciphered_I]; // вставлення зміненого символу на місце того ,з яким велася робота 
                    ciphered_I = -1; //присвоєння змінним запису індексів  
                    alphabet_I = -1; //значення ,при якому не буде виникати помилок при подальших обчисленнях 
                }
            }
            sentence = new string(sentence_array); //запис масиву в рядок 
            Console.WriteLine("\nВаш pядок у зашифрованому вигляді:\n" + sentence);//виведення результату шифрування
            for (int i = 0; i < sentence_array.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (sentence_array[i] == alphabet[j])//пошук співпадінь алфавіту та робочого рядка 
                    {
                        alphabet_I = j;
                        break;
                    }
                }
                if (ciphered_I != -1 || alphabet_I != -1)//якщо збіг було знайдено (символ є в алфавіті)
                {
                    if ((alphabet_I < 32) && (alphabet_I >= 0)) // якщо індекси в допустимих значеннях
                    {
                        ciphered_I = alphabet_I - 3;//для розшифровування -виконуємо зворотню дію
                    }
                    if (ciphered_I < 0) //якщо індекс символу ,на який замінюватиметься літера<0,то 
                    {
                        ciphered_I += 32; //додаємо 32 ,для збереження циклічності алфавіту

                    }
                    sentence_array[i] = alphabet[ciphered_I]; // замінюємо початкову літеру - обчисленою
                    ciphered_I = -1; //перезапис індексів для коректного обчислення
                    alphabet_I = -1;
                }

            }
            sentence = new string(sentence_array);//запис масиву в рядок 
            Console.WriteLine("\nВаш pядок у розшифрованому вигляді:\n" + sentence);//виведення результатів розшифрування

            Console.WriteLine("\n---------------------------------\n");
            string []PIB = sentence.Split(' ');
            
            int a = 0;
            
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
