using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 33902013;
            musteri1.MusteriAd = "Uğurcan ";
            musteri1.MusteriSoyad = "Kırmızı";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 23589410;
            musteri2.MusteriAd = "Serap";
            musteri2.MusteriSoyad = "Kaya";



            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.Ekle(musteri1);
            musteriEkle.Ekle(musteri2);


            MusteriManager musteriSil = new MusteriManager();
            musteriSil.Sil(musteri1);
            musteriSil.Sil(musteri2);


            MusteriManager musteriListele = new MusteriManager();
            musteriListele.Listele(musteri1);
            musteriListele.Listele(musteri2);





        }
    }
}
