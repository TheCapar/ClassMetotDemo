using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle("Deha Edebali ","Çapar ",true); 
            musteriManager.MusteriEkle("Nazım", "Marul", false);

        }
    }
}
