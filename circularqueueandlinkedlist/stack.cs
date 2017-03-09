using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253607HW1
{
    class Stack<T>
    {
        T[] values;
        int top;

        public Stack(int size) //yapının konsakter kısmı .ilk değerler
        {
            values = new T[size];
            top = -1;

        }
        public void clear() // stack temizlemek için
        {
            top = -1;
        }
        public int size() // boyut için
        {
            return values.Length;
        }
        public bool isEmpty() //stack boş mu kontrol eder
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool isfull() // stack dolumu kontrol eder
        {
            if (top == values.Length - 1)
                return true;
            else
                return false;
        }

        public void Push(T val) // stack'e sayı ekleme
        {
            if (isfull())
            {
                throw new Exception("Stack is full");
            }
            else
            {
                values[++top] = val;
            }
        }

        public T pop()
        {
            if (isEmpty())
            {
                throw new Exception("stack is empty");
            }
            else
            {
                top--;
                return values[top + 1];
            }
        }
        public T peek() // sıradaki elemanı öğrenilmesi için kullanılır .
        {
            if (top == -1)
                throw new Exception("stack is empty");
            return values[top];
        }

        public void display()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(values[i]);
            }
            Console.WriteLine();
        }

    }
}
