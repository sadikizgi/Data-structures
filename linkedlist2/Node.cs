﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY11102016
{
    class Node<T> where T : IComparable
    {
        T value;
        Node<T> next;
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
        public Node<T> Next
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
        public Node(T val)
        {
            value = val;
            next = null;
        }
    }
}
