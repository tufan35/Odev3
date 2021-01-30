using ClassMEtotProje;
using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {


            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Cennet";
            musteri1.Soyadi = "Cevik";
            musteri1.KrediPuanı = 50;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Tufan";
            musteri2.Soyadi = "Cevik";
            musteri2.KrediPuanı = 60;



            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ali";
            musteri3.Soyadi = "Cevik";
            musteri3.KrediPuanı = 70;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Adları : " + musteri.Adi + "\n");
                Console.WriteLine("Musteri Kredi Notu : " + musteri.KrediPuanı + "\n");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Guncelle(musteri2);
            musteriManager.Sil(musteri3);

        }
    }
}
