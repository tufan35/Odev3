using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMEtotProje
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Musteri Eklendi " + musteri.Adi + " " + musteri.Soyadi);

        }

        public void Sil(Musteri musteri)
        {

            Console.WriteLine("Musteri Silindi " + musteri.Adi + " " + musteri.Soyadi);

        }

        public void Guncelle(Musteri musteri)
        {

            Console.WriteLine("Musteri Güncellendi " + musteri.Adi + " " + musteri.Soyadi);

        }



    }
}
