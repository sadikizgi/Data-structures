using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace _14253027HW2
{
    class LinkedList<T> where T:IComparable
    {
        Node<T> head;

        public bool Search(T val)
        {
            Node<T> iterator = head;
            while (iterator != null)
            {
                if (iterator.Value.CompareTo(val) == 0)
                    return true;

                iterator = iterator.Next;
            }
            return false;
        }
        public bool SearchRecursive(T val)
        {
            return SearchRecursive(head, val);
        }

        private bool SearchRecursive(Node<T> tempHead, T val)
        {
            if (tempHead == null)
                return false;
            else if (tempHead.Value.CompareTo(val) == 0)
                return true;
            else
                return SearchRecursive(tempHead.Next, val);
        }
        public int Count()
        {
            int count = 0;
            Node<T> iterator = head;
            while (iterator != null)
            {
                count++;
                iterator = iterator.Next;
            }
            return count;
        }


        public void AddToFront(T val)
        {
            Node<T> newNode = new Node<T>(val);
            newNode.Next = head;
            head = newNode;
        }


        public void AddToEnd(T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> iterator = head;
            if (head == null)
                head = newNode;
            else
            {
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = newNode;
            }
        }

        public void Delete(T val)
        {
            if (!Search(val))
                return;
            else
            {
                if (head.Value.CompareTo(val) == 0)
                    head = head.Next;
                else
                {
                    Node<T> prev, iterator;
                    prev = iterator = head;
                    while (iterator.Value.CompareTo(val) != 0)
                    {
                        prev = iterator;
                        iterator = iterator.Next;
                    }
                    prev.Next = iterator.Next;

                }
                if (Search(val))
                    Delete(val);
            }

        }

        public T Minimum()
        {
            if (head == null)
                throw new Exception("list is empty");
            T min = head.Value;
            Node<T> iterator = head;
            while (iterator != null)
            {
                iterator = iterator.Next;
                //kontrollerin sırası önemli
                if (iterator != null &&
                    min.CompareTo(iterator.Value) == 1)

                    min = iterator.Value;

            }
            return min;
        }


        public void DeleteLast()
        {
            Node<T> iterator = head;
            Node<T> prev = head;
            if (head == null || head.Next == null)
                head = null;

            while (iterator.Next != null)
            {
                prev = iterator;
                iterator = iterator.Next;
            }
            prev.Next = null;


        }

        public void Display()
        {
            Node<T> iterator = head;
            while (iterator != null)
            {
                Console.Write(iterator.Value + "  ");
                iterator = iterator.Next;
            }
            //if (head == null)
            //    return;
            //Node<T> iterator = head;

            //while (iterator.Next!= null)
            //{
            //    Console.Write(iterator.Value);
            //    iterator = iterator.Next;

            //}
            //Console.WriteLine(iterator.Value);


        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /// /ÖDEVE BAŞLANGIC.....
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public void DosyaEkle()
        {
            Node<T> iterator = head;
            StreamReader dosya = File.OpenText("C:\\ödev\\sayilar.txt");// ilk önce dosyayı okutma işlemi yapıldı....
            string oku1 = dosya.ReadLine();
            string oku2 = dosya.ReadLine();
            for (int i = 0; i < oku1.Split(',').Length; i++)//burada split edilerek sayılar , göre parçalandı..
            {
                T degis = (T)Convert.ChangeType(oku1.Split(',')[i], typeof(T));
                while (iterator != null)// buradaki while de okunan degerleri listeye atmak için
                {
                    T degis2 = (T)Convert.ChangeType(iterator.Value, typeof(T));
                    if (degis2.CompareTo(degis) == 0)// burada kontrol yapısı olan if kullanıldı eğer aynı değerden varsa listeye eklememesi için
                    {
                        break;
                    }

                    iterator = iterator.Next;

                }
                if (iterator == null)
                    AddToEnd(degis);
                iterator = head;

            }


        }

        public void AccessModi()
        {


            int access = 0;
            int sumAccess = 0;
            float averageAccess = 0;
            ArrayList list = new ArrayList();
            Node<T> iterator = head;
            StreamReader dosya = File.OpenText("C:\\ödev\\sayilar.txt");// burada yine dosya okuma işlemi yapıldı....
            string oku = dosya.ReadLine();
            string oku2 = dosya.ReadLine();
            for (int i = 0; i < oku2.Split(',').Length; i++)// burada dosyanın ikinci satırını okuma işlemi yapıldı 
            {
                access = 0;
                iterator = head;
                T degis = (T)Convert.ChangeType(oku2.Split(',')[i], typeof(T));

                while (iterator != null)// buradaki while de listedeki değerleri aldık...
                {
                    T degis2 = (T)Convert.ChangeType(iterator.Value, typeof(T));
                    access++;// burada erişimler artırıldı...
                    if (degis2.CompareTo(degis) == 0)// burada listedeki değerlerle karşılaştırmayapıldı
                    {

                        break;
                    }

                    iterator = iterator.Next;
                }
                list.Add(access);// burada erişimler arrayliste atıldı..


            }
            int j = 0;
            for (j = 0; j < list.Count; j++)
            {
                sumAccess = sumAccess + Convert.ToInt32(list[j]);// erişim sayısı kadar for döndürldü ve ortalama erişim ile toplam erişim hesaplandı...

            }
            averageAccess = (float)sumAccess / j;
            Console.WriteLine("toplam erişim=" + sumAccess + " \n" + "ortalama erişim=" + averageAccess);
        }
        public void AraEnbas()// bu metodda dosyadan okunan değerler listede varsa aranan değer enbaşa getirme işlemi yapıldı ve toplam erişim ile ortalama erişim yine hesaplandı..
        {
            Node<T> iterator = head;
            Node<T> prev = head;
            StreamReader dosya = File.OpenText("C:\\ödev\\sayilar.txt");
            string oku = dosya.ReadLine();
            string oku2 = dosya.ReadLine();
            float sayac = 0;
            int erisim = 0;
            for (int i = 0; i < oku2.Split(',').Length; i++)
            {
                T degis = (T)Convert.ChangeType(oku2.Split(',')[i], typeof(T));
                iterator = head;
                while (iterator != null)
                {
                    erisim++;
                    T degis2 = (T)Convert.ChangeType(iterator.Value, typeof(T));
                    if (degis2.CompareTo(degis) == 0)
                    {

                        sayac++;
                        if (iterator == head)
                            break;
                        else
                        {


                            prev.Next = iterator.Next;
                            AddToFront(degis2);
                            break;
                        }

                    }
                    prev = iterator;
                    iterator = iterator.Next;
                }

            }
            Console.WriteLine("Toplam Erişim=" + erisim + "\n" + "Ortalama Erişim=" + erisim / sayac);
        }
        // b ve c şıkkında yapılan toplam erişim ile ortalama erişimin avantajı c şıkkında yaptığımız yerleri değiştirilerek yapılan erişim daha avantajlı olduunu gördük ..
        // b ve c şıkkında yapılan toplam ve ortalama erişimin dezavantajı b de yapılan erişim sayısı c de yapılan erişim sayısından fazldır bu dezavantajıdır..
        public void SelectionSort()// burada listedeki değerleri selection sort yöntemiyle sıralandı..
        {
            Node<T> iterator = head;
            Node<T> min = iterator;
            Node<T> prev = head;

            while(iterator!=null)
            {
                min = iterator;
                if (iterator == null)
                    break;
                prev = iterator.Next;
                while(prev!=null)
                {
                    if (iterator.Value.CompareTo(prev.Value) == 1)
                        min = prev;
                    prev = prev.Next;
                }
                if(prev==null)
                {
                    T temp = min.Value;
                    min.Value = iterator.Value;
                    iterator.Value = temp;
                }
                iterator = iterator.Next;
            }


        }
    }
}
