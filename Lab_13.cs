using System;
using System.Collections.Generic;

namespace Lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCar = new List<Car>();
            int sum_price = 0;
            listCar.Add(new A_Class("ВК2828АA", "Mercedes", 50000));
            listCar.Add(new A_Class("DD9999AA", "Mercedes", 50000));
            listCar.Add(new S_Class("FF2398GG", "BMW", 30000));
            listCar.Add(new S_Class("FS7777GG", "Volvo", 30000));
            listCar.Add(new J_Class("DO0000DY", "BMW", 44000));
            listCar.Add(new J_Class("DO1111DY", "KIA", 24000));
            string number;
            string brand;
            int price;
            int cod = 2;

            while (cod != 9)
            {
                Console.WriteLine("\n\n\n1. Ввести новий автомобіль\n2. Вивести весь список автомобілів\n3." +
                    " Сума автопарку\n4. Вивести всі автомобілі А класу\n5. Вивести всі автомобілі S класу\n" +
                    "6. Вивести всі автомобілі J класу\n7. Видали автомобіль\n8. Завершити програму");
                int a = int.Parse(Console.ReadLine());
                cod = a;
                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("Введіть номер автомобіля:");
                            number = Console.ReadLine();
                            Console.WriteLine("Введіть марку автомобіля:");
                            brand = Console.ReadLine();
                            Console.WriteLine("Введіть ціну автомобіля:");
                            price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Виберіть тип класу автомобіля\n1.A class\n2.S class\n3.J class");
                            int classCar = int.Parse(Console.ReadLine());
                            switch (classCar)
                            {
                                case 1:
                                    {
                                        listCar.Add(new A_Class(number, brand, price));
                                        break;
                                    }
                                case 2:
                                    {
                                        listCar.Add(new S_Class(number, brand, price));
                                        break;
                                    }
                                case 3:
                                    {
                                        listCar.Add(new J_Class(number, brand, price));
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (Car car in listCar)
                            {
                                Console.WriteLine(car.CarResult());


                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (Car car in listCar)
                            {
                                sum_price += car.get_Price();
                            }
                            Console.WriteLine("Sun = " + sum_price);
                            break;
                        }
                    case 4:
                        {
                            foreach (Car car in listCar)
                            {
                                if (car.CarResult()[0] == 'A')
                                {
                                    Console.WriteLine(car.CarResult());
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            foreach (Car car in listCar)
                            {
                                if (car.CarResult()[0] == 'S')
                                {
                                    Console.WriteLine(car.CarResult());
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            foreach (Car car in listCar)
                            {
                                if (car.CarResult()[0] == 'J')
                                {
                                    Console.WriteLine(car.CarResult());
                                }
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Введіть номер автомобіля");
                            string num = Console.ReadLine();
                            int i = 0;

                            foreach (Car car in listCar)
                            {
                                if (car.get_Number() == num)
                                {
                                    break;
                                }
                                i++;

                            }
                            listCar.RemoveAt(i);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Завершення програми");
                            break;
                        }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Перевірка " + listCar[0].Equals(listCar[1]));
        }
    }

    abstract class Car
    {
        public string number;
        protected string brand;
        protected int price;
        public int get_Price()
        {
            return price;
        }
        public string get_Number()
        {
            return number;
        }
        public string get_Brand()
        {
            return brand;
        }
        public abstract string CarResult();


    }

    class A_Class : Car
    {
        public A_Class(string number, string brand, int price)
        {
            this.number = number;
            this.brand = brand;
            this.price = price;
        }


        public override string CarResult()
        {
            return $"A клас Марка: {brand} ІD: {number} Ціна: {price}$";
        }

        public override bool Equals(object obj)
        {
            return obj is A_Class @class && number == @class.number && brand == @class.brand && price == @class.price;
        }
    }
    class S_Class : Car
    {
        public S_Class(string number, string brand, int price)
        {
            this.number = number;
            this.brand = brand;
            this.price = price;
        }

        public override string CarResult()
        {
            return $"S клас Марка: {brand} ІD: {number} Ціна: {price}$";
        }
        public override bool Equals(object obj)
        {
            return obj is S_Class @class && number == @class.number && brand == @class.brand && price == @class.price;
        }
    }

    class J_Class : Car
    {
        public J_Class(string number, string brand, int price)
        {
            this.number = number;
            this.brand = brand;
            this.price = price;
        }

        public override string CarResult()
        {
            return $"J клас Марка: {brand} ІD: {number} Ціна: {price}$";
        }
        public override bool Equals(object obj)
        {
            return obj is J_Class @class && number == @class.number && brand == @class.brand && price == @class.price;
        }
    }
}
