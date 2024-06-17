using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();
            //Vatandas vatandas = new Vatandas();
            Person person1 = new Person();
            person1.NationalIdentity = 59266329226;
            person1.FirstName = "Gökmen";
            person1.LastName = "Erkal";
            person1.DateOfBirthYear = 2001;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1 );

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1"};
            yeniSehirler1.Add("Adana 1");

            foreach(var sehir in yeniSehirler1 )
            {
                Console.WriteLine(sehir);
            }

            //SelamVer("Gokmen");
            //SelamVer("Ali");
            //SelamVer();

            //Topla(3, 5);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "İsimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 3, int sayi2 = 10)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);

            return toplam;
        }
    }

    //public static void Degiskenler()
    //{
    //    string mesaj = "Merhaba";
    //    double tutar = 100000;
    //    int sayi = 100;
    //    bool girisYapmisMi = false;

    //    string ad = "Gokmen";
    //    string soyad = "Erkal";
    //    int dogumYili = 2001;
    //    long tcNo = 12345678910;

    //    Console.WriteLine(tutar * 1.18);

    //    Console.WriteLine(tutar * 1.18);
    //}

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumYili { get; set; }
        public string TcNo { get; set; }
    }


}
