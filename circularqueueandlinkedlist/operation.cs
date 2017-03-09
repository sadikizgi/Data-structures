using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253607HW1
{
    class operation<T> where T : IComparable
    {
        public bool aktar(Stack<int> stk, int n) // 1. sorunun cevabı . 
        {
            Stack<int> yedek = new Stack<int>(stk.size()); // yedek stack oluşturuldu . 
            bool flag = false;
            while (!stk.isEmpty())                          // stk boş değil ise while ye girdi
            {
                int deger = stk.pop();                         // stk i boşaltarak yedek stack e attı
                yedek.Push(deger);                              //  çıkan değerleri yedeğe aktardı
                if (deger == n)                                 // aktarım sırasında kontrol etti eğer istediği değer varsa onu çıkardı .
                {

                    n = yedek.pop();
                    flag = true;
                    break;

                }

            }
            while (!yedek.isEmpty())
            {
                stk.Push(yedek.pop());
            }

            return flag;
        }

        public void sirala(Stack<int> stk1, Stack<int> stk2) //2. sorunun cevabı.
        {

            Stack<int> yedek = new Stack<int>(stk1.size() + stk2.size());
            Stack<int> yedek2 = new Stack<int>(stk1.size() + stk2.size());

            while (!stk1.isEmpty()) // stack leri tek bir yedek stack te topladık
            {
                int deger = stk1.pop();
                yedek.Push(deger);
                int deger2 = stk2.pop();
                yedek.Push(deger2);

            }
            while (!yedek.isEmpty())
            {
                int deger3 = yedek.pop();  // yedekteki degeri deger3 e çıkardık karşılaştırmak için

                while (!yedek2.isEmpty() && yedek2.peek() > deger3)  // yedek2 boş olana kadar değerleri aldı ve yedek2 nin top ını tuttut.
                {
                    yedek.Push(yedek2.pop());   ///yedek 2 den aldığı değeri yedek e ekledi

                }
                yedek2.Push(deger3);          // yedek2 ye değeri ekledi

            }

            yedek2.display();                   // yedek2 yi görüntüledi .

        }


        public void altkume(circularqueue<int> queue1, circularqueue<int> queue2) // 3. sorunun cevabı
        {
            circularqueue<int> yedek1 = new circularqueue<int>(queue1.size());
            circularqueue<int> yedek2 = new circularqueue<int>(queue2.size());

            int sayac = 0;
            int sayac2 = 0;

            while(!queue1.isEmpty())                        //queue1 boşalana kadar dönücek
            { 
                int deger = queue1.deQueue();                  // yedekleme yapıldı ve deger alındı
                yedek1.enQueue(deger);
                while (!queue2.isEmpty())                           // queue2 boşalana kadar dönücek
                {
                    int deger2 = queue2.deQueue();                  //queue2 boşalırken deger ile deger2 yi karşılaştırcaz 
                    yedek2.enQueue(deger2);

                    if (deger == deger2)
                    {
                        sayac++;                                    // aynı değer var ise sayaç 1 artıcak
                    }

                }
                    while (!yedek2.isEmpty())                       // biraz önce queue2 boşalmıştı bunu dolduralım ki 2. değeri kıyaslayabilelim.
                    {
                        queue2.enQueue(yedek2.deQueue());              // eğer bunu doldurmaz isek bir degere bakar gerisini kontrol etmez
                    }
                
                sayac2++;
            }

            

            if (sayac == sayac2)                                    //sayac ın degeri sayac2 ile eşitlenirse bu alt küme olduğunu gösterir
            {
                Console.WriteLine(" Alt kümesidir");
            }
            else
            {
                Console.WriteLine("DEĞİL");
            }

        }
    }
}

