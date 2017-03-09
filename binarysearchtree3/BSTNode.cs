using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL23112016
{
    class BSTNode<T> where T : IComparable
    {
        T value;
        BSTNode<T> left, right;


        public BSTNode(T val)
        {
            Value = val;
        }
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

        internal BSTNode<T> Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        internal BSTNode<T> Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
