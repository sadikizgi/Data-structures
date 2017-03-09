using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _14253607HW2
{
    class islem<T> where T : IComparable
    {
        LinkedList<T> Liste = new LinkedList<T>();
        public void Dosyaoku()                                          //1.SORUNUN cevabı
        {


            Node<T> iterator = Liste.head;

            string yol = @"C:\Users\izgi\Documents\Visual Studio 2015\Projects\14253607HW2\numbers.txt";
            FileStream fs = new FileStream(yol, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadLine();
            string[] parcala = yazi.Split(',');                        // txt den adlığımız sayıları parçalar




            for (int i = 0; i < parcala.Length; i++)
            {
                T temp = (T)Convert.ChangeType(parcala[i], typeof(T)); // string olan değerleri T tipinde yaparak karşılaştırma yapabilmeyi sağladık
                if (Liste.head == null)
                {
                    Liste.AddtoEnd(temp);                               // listeye ekleme

                }

                iterator = Liste.head;
                while (iterator != null)
                {
                    T temp2 = (T)Convert.ChangeType(iterator.Value, typeof(T));
                    if (temp.CompareTo(temp2) == 0)                     // burda karşılaştımayı yapıyorz. aynısayı var ise eklemicek
                    {
                        break;
                    }
                    iterator = iterator.Next;
                }

                if (iterator == null)
                {
                    Liste.AddtoEnd(temp);
                }

            }

            sw.Close();
            fs.Close();
            Liste.Display();


        }

        public void indisbul()                                  //2.SORUNUN cevabı
        {
            Node<T> iterator = Liste.head;
            string yol = @"C:\Users\izgi\Documents\Visual Studio 2015\Projects\14253607HW2\numbers.txt";
            FileStream fs = new FileStream(yol, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            string aranacak = sw.ReadLine();
            string[] parcala = aranacak.Split(',');


            int sayac = 0;                                              //kaç tane degeri aradığını tutacak
            int indis = 0;                                              //degerleri ararken kaç sayı gezdiğini tutcak

            for (int i = 0; i < parcala.Length; i++)
            {
                iterator = Liste.head;
                T temp = (T)Convert.ChangeType(parcala[i], typeof(T));
                while (iterator != null)
                {
                    T temp2 = (T)Convert.ChangeType(iterator.Value, typeof(T));
                    if (temp2.CompareTo(temp) == 0)
                    {
                        sayac++;
                        indis++;
                        iterator = iterator.Next;
                        break;
                    }
                    else
                    {
                        indis++;
                        iterator = iterator.Next;

                    }
                }
            }

            Console.WriteLine("toplam erişim = " + indis + "ortalama erişim =" + indis / sayac);



            sw.Close();
            fs.Close();
        }




        public void search()                                        //3.SORUNUN cevabı
        {
            Node<T> iterator = Liste.head;
            Node<T> prev = Liste.head;
            string yol = @"C:\Users\izgi\Documents\Visual Studio 2015\Projects\14253607HW2\numbers.txt";
            FileStream fs = new FileStream(yol, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            string aranacak = sw.ReadLine();
            string[] parcala = aranacak.Split(',');


            int sayac = 0;                                                  //kaç tane degeri aradığını tutacak
            int indis = 0;                                                  //degerleri ararken kaç sayı gezdiğini tutcak

            for (int i = 0; i < parcala.Length; i++)
            {
                iterator = Liste.head;

                T temp = (T)Convert.ChangeType(parcala[i], typeof(T));
                while (iterator != null)
                {
                    indis++;
                    T temp2 = (T)Convert.ChangeType(iterator.Value, typeof(T));
                    if (temp2.CompareTo(temp) == 0)
                    {
                        sayac++;
                        if (iterator == Liste.head)
                        {

                            break;
                        }
                        else
                        {

                            prev.Next = iterator.Next;
                            Liste.AddToFront(temp2);
                            break;
                        }
                    }

                    prev = iterator;
                    iterator = iterator.Next;


                }

            }
            Console.WriteLine("toplam erişim = " + indis + "ortalama erişim =" + indis / sayac);
            sw.Close();
            fs.Close();
            Liste.Display();
        }

        // 4. SORUNUN cevabı = 2. yöntem daha kullanışlıdır.hafızaya erişim daha azdır .buda daha hızlı çalışmasını sağlamaktadır.
        // iş yükü diğerine göre biraz daha azdır. büyük listelerde daha çok işe yarar .
        // Bu 2.yöntemi ben telefonda ki sık kullanınanlara benzetiyorum. çok kullananlar öne gelince işlem yapmamız hızlanıyor. 
        // bu kodlar içinde böyle . daha sık kullanmak  erişimi hızlandırıyor .

        public void slectionSort()        // 5.SORUNUN Cevabı
        {
            Node<T> currentOuter = Liste.head;
            
            while (currentOuter != null)
            {
                Node<T> minimum = currentOuter;
                Node<T> currentInner = currentOuter.Next;

                while (currentInner != null)
                {
                    if (currentInner.Value.CompareTo(minimum.Value) < 0)
                    {
                        minimum = currentInner;
                    }

                    currentInner = currentInner.Next;
                }

                if (!Object.ReferenceEquals(minimum, currentOuter))
                {
                    T temp = currentOuter.Value;
                    currentOuter.Value = minimum.Value;
                    minimum.Value = temp;
                }

                currentOuter = currentOuter.Next;
            }
            Liste.Display();
        }
    }
}
    

