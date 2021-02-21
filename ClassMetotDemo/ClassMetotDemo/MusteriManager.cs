using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Id'si"+ musteri.MusteriId + " olan" + musteri.MusteriAd +"  "
                + musteri.MusteriSoyad +"  "+ "eklenmiştir." );


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Id'si" + musteri.MusteriId + " olan" + musteri.MusteriAd + "  "
                + musteri.MusteriSoyad + "  " + " silinmiştir.");
        }
        public void Listele(params Musteri[]musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Bilgileri :");
                Console.WriteLine("Müşteri Id : " + musteri.MusteriId);
                Console.WriteLine("Musterinin  adı ve soyadı : "+ musteri.MusteriAd +" "+musteri.MusteriSoyad);

            }
            
        }
            
    }
}
