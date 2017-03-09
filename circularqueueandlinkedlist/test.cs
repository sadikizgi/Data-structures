using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253607HW1
{
    class test 
    {

        static void Main(string[] args)
        {
            operation<bool> opr = new operation<bool>();
            operation<int> opr2 = new operation<int>();
            //1.SORU TEST (BU SORUDA ÇIKAN DEĞER YERİNE TRUE DÖNDÜRÜYOR . ŞU AN 6 DEĞERİNİ ÇIKARDIK ALTI ÇIKTI VE TRUE YAZDI ONUN YERİNE)
            Console.WriteLine("/////1.SORU CEVAP YERİ/////");
            Stack<int> st = new Stack<int>(7);
            Console.WriteLine("stack değerleriniz.");
            st.Push(8);
            st.Push(7);
            st.Push(6);
            st.display();
            Console.WriteLine("Sayı çıktıktan sonraki değerleriniz.");
            Console.WriteLine(opr.aktar(st, 6));
            st.display();


            Console.WriteLine("////2. SORU CEVAP YERİ///////");

            //2.SORU TEST
            Stack<int> stk3 = new Stack<int>(10);
            Stack<int> stk4 = new Stack<int>(10);

            
            stk3.Push(6);
            stk3.Push(4);
            stk3.Push(5);
            
            stk4.Push(2);
            stk4.Push(3);
            stk4.Push(1);
            Console.WriteLine("1.stack");
            stk3.display();
            Console.WriteLine("2.stack");
            stk4.display();
            Console.WriteLine("sıralanmış hali");
            opr2.sirala(stk3, stk4);





            //3.SORU TEST
            Console.WriteLine("/////3.SORU CEVAP YERİ/////");
            circularqueue<int> myqueue = new circularqueue<int>(10);
            circularqueue<int> myqueue2 = new circularqueue<int>(10);
            myqueue.enQueue(9);
            myqueue.enQueue(5);
            myqueue.enQueue(4);
            myqueue.enQueue(7);
            

            myqueue2.enQueue(5);
            myqueue2.enQueue(9);
            myqueue2.enQueue(4);
            myqueue2.enQueue(7);
            myqueue2.enQueue(8);
            myqueue2.enQueue(11);


            opr2.altkume(myqueue, myqueue2);





        }
    }
}
