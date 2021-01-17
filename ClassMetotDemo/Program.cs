using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Kübra";
            musteri.Soyad = "Kahraman";
            musteri.No = 3;

            Musteri musteri2 = new Musteri();
            musteri.Ad = "Bahar";
            musteri.Soyad = "Küçükıstıranca";
            musteri.No = 4;

            Musteri musteri3 = new Musteri();
            musteri.Ad = "Yasemin";
            musteri.Soyad = "Keskin";
            musteri.No = 5;

      
            Musteri[] musteriler = new Musteri[] { musteri, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri4 = new Musteri();
            musteri.Ad = "Bilge";
            musteri.Soyad = "Dere";
            musteri.No = 6;

            musteriManager.MusteriEkleme(musteri4);
            musteriManager.MusteriSilme(musteri3);

            Console.WriteLine("--------Müşteriler----- ");
            musteriManager.MusteriListeleme(musteriler);






        }
    }
}
