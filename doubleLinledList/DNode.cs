using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_doubleLinledList_19102016
{
    class DNode<T> where T : IComparable
    {
        T value;
        DNode<T> next;
        DNode<T> prev;

        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public DNode<T> Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public DNode<T> Prev
        {
            get
            {
                return prev;
            }

            set
            {
                prev = value;
            }
        }

        public DNode(T val)
        {
            value = val;
            prev = null;
            next = null;
        }
    }
}
