#include <iostream>
#include <locale.h>
using namespace std;

class MyClass {
private:
    float* p;
    int size;
public:
    MyClass(int size) {
        this->size = size;
        this->p = new float[size];
        for (int i = 0; i < int(size); i++) {
            if ((i % 2) == 0) {
                p[i] = i - 1.9;
            }
            else {
                p[i] = i;
            }
        }
        cout << "Визвався конструктор " << this << endl;
        for (int i = 0; i < int(size); i++) {
            cout << p[i] << " ";
        }
        cout << endl;
    }

    MyClass(const MyClass& other) {
        this->size = other.size;
        this->p = new float[other.size];
        int k = 0;
        float c,f =0;
        cout << "Визвався конструктор копіювання " << this << endl;
        for (int i = other.size-1; i > 0; i--) {
            this->p[i] = other.p[i];
            cout << p[i] << " ";
        }
        cout << endl;

       

    }

    ~MyClass() {
        cout << "Визвався деструктор " << this << endl;
        delete[] p;
    }

};

int main() {

    setlocale(0, "UKRAINIAN");
    MyClass x(14);
    MyClass y(x);
    system("pause");
    return 0;
}
