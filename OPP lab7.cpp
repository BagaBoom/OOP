#include <iostream>
#include <stdio.h>
#include <cmath>
#include <locale.h>

using namespace std;

float p = 3.14;
class Geometric_body 
{

public:
	virtual void Area() = 0;
};

class Ball : public Geometric_body
{
	float R;

public:
	Ball(float R)
	{
		this->R = R;
	}

	void Area() override
	{
		cout << "Area Ball = " << 4*p*pow(R,2) << endl;
	}
};

class Parallelepiped : public Geometric_body
{
	float a;
	float b;
	float c;
public:
	Parallelepiped(float a, float b, float c)
	{
		this->a = a;
		this->b = b;
		this->c = c;
	}
	void Area() override
	{
		cout << "Area Parallelepiped = "<< 2*(a*b + b*c + a*c) << endl;
	}
};

class Tetrahedron : public Geometric_body
{

    float a;
public:
	Tetrahedron(float a) 
	{
		this->a = a;
	}
	void Area() override
	{
		cout << "Area Tetrahedron = "<< pow(3, 1.0/3)*a << endl;
	}
};

int main()
{
	setlocale(0, "UKRAINIAN");
	Geometric_body* d[3];
	Ball B(3);
	Parallelepiped P(3,3,3);
	Tetrahedron T(3);
	d[0] = &B;
	d[0]->Area();
	d[1] = &P;
	d[1]->Area();
	d[2] = &T;
	d[2]->Area();
}




