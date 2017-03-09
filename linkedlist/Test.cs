using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253027HW2
{
    class Test
    {// Ali ERDOĞAN 14253027...
        // VERİ YAPILARI ÖDEV 2..
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            Console.WriteLine("Oluşan Liste:");
            list.DosyaEkle();
            list.Display();
            Console.WriteLine("\n");
            list.AccessModi();
            Console.WriteLine("\n");
            list.AraEnbas();
            Console.WriteLine("Aranan Değerleri Enbasa Alma :");
            list.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Seçerek Sıralama Yaparak Listeyi Sıraladık Listenin Son Hali...:");
            list.SelectionSort();
            list.Display();
            Console.WriteLine("\n");
        }
    }
}
