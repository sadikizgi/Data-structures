using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_stack_28092016
{
    class StackOperations
    {
        public bool search(Stack<int> st, int n)
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
            while (!yedek.isEmpty())
            {
                st.push(yedek.pop());
            }
            return flag;
        }
    }
}
