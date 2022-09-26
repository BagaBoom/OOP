#include <iostream>
#include <stdio.h>
#include <cmath>
#include <locale.h>

using namespace std;

class Place
{

	string nameP;
public:

	
	
	void SetNameP(string name)
	{
		nameP = name;
	}

	string GetNameP() {
		return nameP;
	}

	void show()
	{
		cout << "Мiсце " << nameP << endl;
	}

};

class Region : public Place
{

	string nameR;
	int area;
	int age;
public:
	
		
	void SetNameR(string name) 
	{
		nameR = name;
		
	}

	void SetAge(int ag) {
		age = ag;
	}

	void SetArea(int are) {
        area = are;
	}


	string GetNameR() {
		return nameR;
	}

	int GetAge() {
		return age;
	}
	int GetArea() {
		return area;
	}

	

	void show()
	{
		cout << "Країна " << GetNameP() << " Область " << nameR << " Площа = " << area  << endl;
	}
};





class City : public Region
{

	string nameC;
public:
	

	void SetnameC(string name)
	{
		nameC = name;
	}

	

	string Get() 
	{
		return nameC;
	}

	
	

	void show()
	{
		cout <<"Країна " << GetNameP() << " Мiсто " << nameC << " Рiк " << GetAge() << " Область " << GetNameR() << endl;
	}
};


class Metropolis : public Region
{
	string nameM;
	int	population;
public:
	

	void SetNameM(string name) 
	{
		nameM = name;
	}

	void SetPopulation(int population1) 
	{
		population = population1;
	}
		
	string GetNameM() 
	{
		return nameM;
	}
	

	void show()
	{
		cout << "Країна " << GetNameP() << " Мегаполiс " << nameM << " Рiк " << GetAge() << " Область " << GetNameR() << " Населення " << population << endl;
	}


};


int main()
{
	setlocale(0, "UKRAINIAN");
	Place pl;
	pl.SetNameP("Україна");
	Region reg;
	reg.SetNameR("Рiвненський");
	reg.SetArea(3425532);
	reg.SetNameP("Україна");
	City ci;
	ci.SetNameP("Україна");
	ci.SetnameC("Сарни");
	ci.SetAge(235);
	ci.SetNameR("Рiвненська");
	Metropolis me;
	me.SetNameP("Україна");
	me.SetNameM("Києв");
	me.SetAge(125);
	me.SetNameR("Києвська");
	me.SetPopulation(2440000);

	pl.show();
	reg.show();
	ci.show();
	me.show();

	return 0;

}

