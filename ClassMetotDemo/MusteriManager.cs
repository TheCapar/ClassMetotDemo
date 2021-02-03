using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(string Name, string SurName, bool Aldı)
        {
            Console.WriteLine("Müşterimizin Adı:" + " " + Name);
            Console.WriteLine("Müşterimizin Soyadı:" + " " + SurName);
            if (Aldı == true)
            {
                Console.WriteLine("Müşterimiz Ürünümüzü Almış");
            }
            else
            {
                Console.WriteLine("Müşterimiz Ürünümüzü Almamış" );
            }
            Console.WriteLine("--------------------------------");
        }
    }
}
