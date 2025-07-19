using System;
using System.Collections.Generic;

namespace OkulYonetimSistemi
{
    // Person adlı temel sınıf
    public class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public Person(string ad, string soyad, DateTime dogumTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesneleri oluşturuluyor
            Person ogrenci1 = new Person("Ahmet", "Yılmaz", new DateTime(2005, 6, 12));
            Person ogrenci2 = new Person("Ayşe", "Demir", new DateTime(2006, 3, 25));

            // Öğretmen nesneleri oluşturuluyor
            Person ogretmen1 = new Person("Mehmet", "Kaya", new DateTime(1980, 1, 15));
            Person ogretmen2 = new Person("Fatma", "Çelik", new DateTime(1975, 9, 8));

            // Listeye eklenip hepsi yazdırılıyor
            List<Person> kisiler = new List<Person> { ogrenci1, ogrenci2, ogretmen1, ogretmen2 };

            Console.WriteLine("Okuldaki Kişilerin Bilgileri:\n");
            foreach (Person kisi in kisiler)
            {
                kisi.BilgileriYazdir();
            }

            Console.ReadLine();
        }
    }
}
