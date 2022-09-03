#include <iostream>
#include <stdio.h>
#include <cmath>
#include <locale.h>

using namespace std;


//Варант 3 студент Радчук Сергій ІПЗ-21008б
//Створити клас «квадрат», такий, що:
//а) його екземпляр містить розмір сторони квадрата.
//b) його конструктор без параметра створює екземпляр зі значенням 0, а
//конструктор з параметрами створює екземпляр з відповідним значенням
//сторони.
//c) його методи дозволяють отримувати і присвоювати значення сторони і
//обчислювати значення площі.
//d) функція print_sqr() виводить на екран значення його сторони і площі.
//e) дружня функція frd в якості параметрів отримує екземпляри двох
//квадратів і повертає новий квадрат, площа якого дорівнює сумі площ
//цих двох квадратів.Значення сторони нового квадрата має бути
//перераховане.
class Square 
{
public:
    float a,s; 
	Square();
	Square(float);
	~Square();
	float print_sqr();
	void setA(float);
	float getA();

};

Square::Square() //конструктор без параметра 
{
	a = 5;
	cout << "Початок розрахунку\n" << endl;

}



Square::Square(float a) //конструктор з параметром 
{
	this->a = a;

}

float Square::print_sqr()
{

	s = pow(a, 2);

	cout << "Довжина сторони  квадрата - " << a << "см\n" << "Площа даної фiгури " << s << "см^2\n" << endl;

	return s;
}


Square::~Square() //деконструктор
{
	
}

void Square::setA(float a)
{
	a = a;
}

float Square::getA()
{
	return a;
}

Square frd(Square& arr, Square& add) //дружня фунція 
{
	float S = arr.print_sqr() + add.print_sqr();
	float a = sqrt(S);
	cout << "Новий  квадрат" << endl;
	Square newSquare(a);
	return newSquare;
}


int main()
{
	setlocale(0, "UKRAINIAN");
	Square a1;
	Square a2(7);
	Square a1_a2 = frd(a1, a2);// дружня фунція яка сумує два квадрата
	a1_a2.print_sqr();
}

