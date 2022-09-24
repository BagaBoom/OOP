#include <iostream>
#include <cmath>
#include <locale.h>

using namespace std;
//Варіант 11. Створити клас «пісочний годинник» :
//a) його екземпляр містить розміри a і b.
//b) його конструктор без параметра створює екземпляр зі значенням 0, а конструктор з параметрами створює екземпляр з відповідним значенням a і b.
//c) його методи дозволяють отримувати і присвоювати значення a і b та обчислювати значення площі.
//d) операція « << » перевантажена : виводить на екран значення a, b і площі цієї фігури.
//e) операція « + » перевантажена : для двох фігур створює нову фігуру з параметрами(a = a1 + a2, b = b1 + b2).
//g) операція «++» збільшує a і b на одиницю.

class Clock 
{
    float a, b;
    void SetA(float a) { this->a = a; }
    void SetB(float b) { this->b = b; }
public:
    Clock() 
    {
        SetA(0);
        SetB(0);
    }
    Clock(float a, float b) 
    {
        SetA(a);
        SetB(b);
    }

   
    ~Clock() {

    }

    float GetA() 
    {
        return a;

    }
    float GetB()
    {
        return b;
    }

    float Area()
    {
        this->a = a;
        this->b = b;
        float s = (b / 2) * a;
        return s;
    }

    Clock operator ++ (int)//постфіксний інкремент
    {
        Clock t = *this;
        a++;
        b++;
        return t;
    }
    Clock operator ++()//префіксний інкремент
    {
        a++;
        b++;
        return *this;
    }

    friend ostream& operator << (ostream& os, Clock& obj);
    friend Clock operator + (Clock obj1, Clock obj2);

};

//перевантаження оператора виведення
ostream& operator << (ostream& os, Clock& obj) {
    return os << "\na = " << obj.a << "\nb = " << obj.b << "\nArea = " << obj.Area() << endl << endl;
}

//перевантаження оператора додавання
Clock operator + (Clock obj1, Clock obj2) {
    Clock obj3;
    obj3.a = obj1.a + obj2.a;
    obj3.b = obj1.b + obj2.b;
    return obj3;
}



int main()
{
    setlocale(0, "UKRAINIAN");
    float a, b;
    cout << "Ведiть перший обєкт a i b" << endl;
    cin >> a >> b;
    Clock Clock_1 = Clock(a, b);
    cout << "Перший обєкт " << Clock_1;
    cout << "Ведiть другий обєкт a i b" << endl;
    cin >> a >> b;
    Clock Clock_2 = Clock(a, b);
    cout << "Другий обєкт " << Clock_2;
    Clock Clock_3;
    Clock_3 = Clock_1 + Clock_2;
    cout << "Перший + Другий " << Clock_3 << endl;
    Clock_1++;
    cout << "Результат постфiксного iнкремента для першого об'єкта\n" << Clock_1;
    ++Clock_2;
    cout << "Результат префiксного iнкремента для другого об'єкта\n" << Clock_2;
    Clock Clock_4 = ++Clock_3;
    cout << "Резyльтат префiксного iнкремента для другого + перший обєкти\n" << Clock_4 << endl;
    Clock Clock_5 = Clock_3++;
    cout << "Результат постфiксного iнкремента для другого + перший обєкти\n" << Clock_5;
}



