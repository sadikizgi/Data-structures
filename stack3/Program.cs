using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_stack_28092016
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOperations so = new StackOperations();
            Stack<int> st1 = new Stack<int>(5);
            st1.push(6);
            st1.push(16);
            st1.push(3);
            st1.push(1);
            st1.push(5);
            //st1.pop();
            //st1.pop();

            st1.display();
            Console.WriteLine(so.search(st1, 160));
            st1.display();
        }
    }
}
