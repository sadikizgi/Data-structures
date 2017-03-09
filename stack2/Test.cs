﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY27092016
{
    class Test
    {
        public static  bool search(Stack<int> st, int n)
        {
            Stack<int> yedek = new Stack<int>(st.size());
            bool flag = false;
            while (!st.isEmpty())
            {
                int deger = st.pop();
                yedek.push(deger);
                if (deger == n)
                {
                    flag = true;
                    break;
                }
            }
            while(!yedek.isEmpty())
            {
                st.push(yedek.pop());
            }


            return flag;
        }
        static void Main(string[] args)
        {
            Stack<int> st1 = new Stack<int>(5);
            st1.push(6);
            st1.push(16);
            st1.push(3);
            st1.push(1);
            st1.push(5);
            //st1.pop();
            //st1.pop();
            
            st1.display();

            Console.WriteLine(search(st1, 160));
            st1.display();

        }
    }
}
