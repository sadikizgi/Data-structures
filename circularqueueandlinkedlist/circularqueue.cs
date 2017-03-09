using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253607HW1
{
    class circularqueue<T> where T : IComparable
    {
        T[] values;
        int front;
        int rear;

        public circularqueue(int size)
        {
            values = new T[size];
            front = 0;
            rear = 0;
        }

        public int size()
        {
            return values.Length;
        }
        public bool isEmpty()
        {
            if (front == rear)
                return true;
            else
            {
                return false;
            }
        }
        public bool isFull()
        {
            if (front == (rear + 1) % size())
                return true;

            else
            {
                return false;
            }
        }

        public void enQueue(T val)
        {
            if (isFull())
            {
                throw new Exception("queue is full");
            }
            else
            {
                values[++rear % size()] = val;
            }
        }

        public T deQueue()
        {
            if (isEmpty())
            {
                throw new Exception("queue is empty");
            }
            else
            {
                return values[++front % size()];
            }
        }

        public void display()
        {
            if (!isEmpty())
            {
                int i = (front + 1) % size();

                while (i != (rear + 1) % size())
                {
                    Console.WriteLine(values[i]);
                    i = (i + 1) % size();
                }
            }
        }

    }
}
