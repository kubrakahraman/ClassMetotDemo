using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri EKlendi :" + musteri.Ad);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Ad);
        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " : " + musteri.No);
            }
        }
    }
}
