#include <cmath>
#include <fstream>
#include <iostream>
#include <locale.h>
#include <stdio.h>
#include <string>

using namespace std;

//Варіант 11 Відсортувати студентів за середнім балом та вивести на екран
//тих, хто має бал більш за 4.


class Student {
    string surname;
    string name;
    int physics;
    int math;
    int it;

public:
    void Set(string surname, string name, int physics, int math, int it) {
        this->surname = surname;
        this->name = name;
        this->physics = physics;
        this->math = math;
        this->it = it;
    }
    string GetSurName() { return surname; }
    string GetName() { return name; }
    int Getphysics() { return physics; }
    int Getmath() { return math; }
    int Getit() { return it; }
    float average() {
        float ave;
        ave = (physics + math + it) / 3.0;
        return ave;
    }

    void Print() {

        cout << "Студент " << surname << " " << name
            << "   Оцiнки: Фiзика = " << physics << " Математика = " << math
            << " Iнформатика = " << it << " Середнiй бал =" << average() << endl;
    }
};

int main() {
    setlocale(0, "UKRAINIAN");
    int kilkist = 0;
    string str;
    ifstream fin("data.txt");
    if (fin) {
        while (!fin.eof()) {
            getline(fin, str, '\n');
            kilkist++;
        }

        Student* P = new Student[kilkist];
        fin.clear();
        fin.seekg(0);
        for (int i = 0; i < kilkist; i++) {
            string sname;
            string nname;
            int a;
            int b;
            int c;
            fin >> sname;
            fin >> nname;
            fin >> a;
            fin >> b;
            fin >> c;
            P[i].Set(sname, nname, a, b, c);
        }
        for (int i = 0; i < kilkist - 1; i++) {
            for (int j = i + 1; j < kilkist; j++) {
                if (P[i].average() < P[j].average()) {
                    swap(P[i], P[j]);
                }
            }
        }

        cout << "Всi данi з файлу:" << endl;
        for (int i = 0; i < kilkist; i++) {
            P[i].Print();
        }
        cout << "Всi студенти з середнiм балом бiльше 4: " << endl;

        for (int i = 0; i < kilkist; i++)
            if (P[i].average() > 4) {
                P[i].Print();
            }
        fin.close();
        delete[] P;
    }
    else
        cout << "Не вдалося вiдкрити файл ";
}
