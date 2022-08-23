#include <iostream>
#include <locale.h>
#include <string>

using namespace std;

class People {
    string name, surname, namber;
    int cod;
    int age;

public:

    People();
    People(string, string, string, int, int);
    ~People();
    void Print();
    void setName(string);
    string getName();
    void setSurName(string);
    string getSurName();
    void setNamber(string);
    string getNamber();
    void setCod(int cod);
    int getCod();
    void setAge(int age);
    int getAge();
};


void People::setName(string name)
{
    name = name;
}

string People::getName()
{
    return name;
}

void People::setSurName(string surname)
{
    surname = surname;
}

string People::getSurName()
{
    return surname;
}

void People::setNamber(string namber)
{
    namber = namber;
}

string People::getNamber()
{
    return namber;
}

void People::setCod(int cod)
{
    cod = cod;
}

int People::getCod()
{
    return cod;
}

void People::setAge(int age)
{
    age = age;
}

int People::getAge()
{
    return age;
}

People::People()
{
    name = "Den";
    surname = "Komar";
    namber = "+2352525";
    cod = 23233232;
    age = 18;
    cout << "Початок програми" << endl;
}

People::People(string name, string surname, string namber, int cod, int age)
{
    this->name = name;
    this->surname = surname;
    this->namber = namber;
    this->cod = cod;
    this->age = age;
    cout << "Конструктор з параметрами викликаний для об'єкта " << this << "\n" << endl;
    //  Print();
}



People::~People()
{
    cout << "Деструктор викликаний для об'єкта " << this << endl;
}



void People::Print()
{

    cout << "Iмя - " << name << "\nПризвiще - " << surname << "\nНомер:" << namber
        << "\nКод: " << cod << "\nВiк " << age << endl;
}

int main()
{

    setlocale(0, "Ukrainian");
    cout << "Heloo" << endl;
    People();
    People people[5] = { People("Tom", "Shelby", "+378045645", 111111, 33),
                        People("Arthur", "Shelby", "+045346635", 222222, 41),
                        People("John", "Shelby", "+8568654564", 333333, 25),
                        People("Roberts", "Shelby", "+25375774", 444444, 35),
                        People("Grey", "Shelby", "+13478564", 555555, 51) };
    void (People:: * pf)();
    pf = &People::Print;
    int  n = 0;
    while (n < 5)
    {
        (people[n].*pf)();
        n++;
    }



    return 0;
}