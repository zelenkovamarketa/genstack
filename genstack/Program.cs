using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genstack
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Stack<T>
    {
        T[] elements;
        int index;
        public Stack(int maxElementCount = 100)
        {
            elements = new T[maxElementCount];
            index = -1;
        }
        public void Push(T t)
        {
            elements[++index] = t;
        }
        public T Pop()
        {
            if (index>=0)
            {
                T t = elements[index];
                index--;
                return t;
            }
            else throw new IndexOutOfRangeException();
        }
        public T Peek()
        {
            T t = elements.Last();
            return t;
        }
        public bool IsEmpty()
        {
            bool b;
            if (elements.Count() == 0) b = true;
            else b = false;
            return b;
        }
        public string PrintStack()
        {
            string s = "";
            foreach (T item in elements)
            {
                s += $"{item} ";
            }
            return s;
        }
    }
}
