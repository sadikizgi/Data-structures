using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSL21122016
{
    class Test
    {
        static void Main(string[] args)
        {
            Sorting<int> sort = new Sorting<int>();
            //int[] a = {5,3,1,4,2,8,9,7};
            //int[] a = { 1,2,3,4,5,6,7 };
            //int[] a = { 7,6,5,4,3,2,1};
            int[] a = { 20, 3, 1, 4, 2, 8, 9, 7,40 };
            sort.QuickSort(a);
            sort.DisplayArray(a);
        }
    }
}
