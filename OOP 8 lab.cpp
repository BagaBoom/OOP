#include <iostream>
#include <locale.h>
using namespace std;

template <class T>
class Queue
{
private:
    T* queue; // останній елемент в черзі
    int count; // поточна довжина черги
    int maxCount; // максимальний розмір черги

    // Метод, що здійснює копіювання черги
    void Copy(const Queue<T>& obj)
    {
        // 1. Звільнити попередньо виділену пам'ять для черги
        if (maxCount > 0)
            delete[] queue;

        // 2. Скопіювати дані

        count = obj.count;
        maxCount = obj.maxCount;

        // виділити пам'ять для нової черги
        queue = new T[maxCount];

        // цикл копіювання даних
        for (int i = 0; i < maxCount; i++)
            queue[i] = obj.queue[i];
    }

public:
    // Конструктор
    Queue(int _maxCount)
    {
        // Створити чергу розміром _maxCount
        maxCount = _maxCount;
        queue = new T[maxCount]; // виділити пам'ять для черги
        count = 0; // поки що черга пуста
    }

    // Конструктор копіювання
    Queue(const Queue& obj)
    {
        Copy(obj);
    }

    // Оператор копіювання
    Queue<T> operator=(const Queue& obj)
    {
        Copy(obj);
        return *this;
    }

    // Очищення черги
    void Clear()
    {
        count = 0;
    }

    // Деструктор
    ~Queue()
    {
        if (maxCount > 0)
            delete[] queue; // звільнити пам'ять, виділену під чергу
    }

    // Перевірка, чи черга пуста?
    bool isEmpty()
    {
        return count == 0;
    }

    // Отримати кількість елементів черги
    int Count()
    {
        return count;
    }

    // Перевірка, чи черга повна?
    bool isFull()
    {
        return count == maxCount;
    }

    // Додати новий елемент до черги
    void operator + (T item);

    // Витягнути  елемент з черги 
    void operator - (int key);
   



    // Метод, що виводить чергу
    void Print()
    {
        cout << " ";
        for (int i = 0; i < count; i++)
            cout << queue[i] << " ";
        cout << endl;
    }
};

template <class T>
void Queue<T>::operator +(T item)
{
    if (!isFull()) // якщо черга не заповнена
        queue[count++] = item;
}

template <class T>
void Queue<T>::operator -(int key)
{
    if (!isEmpty()) // Якщо черга заповнена
    {
        // запам'ятати перший елемент
        T item = queue[key];

        // зсув елементів
        for (int i = key; i < count; i++)
            queue[i - 1] = queue[i];
        count--;
        
    }     
}

int main()
{
    setlocale(0, "UKRAINIAN");
    int a = 5, v, key;
    double add, s;
    Queue<double> q(10);
    q + (25);
    q + (30);
    q + (70);
    q + (10);
    q + (7);
    int cod = 2;
    while (cod != 4)
    {
        cout << "\n1)Вивести всi данi\n2)Додати елемент\n3)Витягти елемент\n4)Вийти з програми" << endl;
        cin >> v;
        cod = v;
        switch (v)
        {
        case 1:
            q.Print();
            break;
        case 2:
            cout << "Новий елемент = ";
            cin >> s;
            q + (s);
            break;
        case 3:
            cout << "Ведіть номер черги = ";
            cin >> key;
            q - (key);

            break;
        default:
            cout << "Завершення роботи" << endl;
        }
    }

    return 0;
}
