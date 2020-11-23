/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 	SORU_3
**				ÖĞRENCİ ADI............: 	ARSLANCAN SARIKAYA
**				ÖĞRENCİ NUMARASI.......:	B181210052
**                         DERSİN ALINDIĞI GRUP...: D
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3
{
    //Bütün sınıfların ortak özelliklerini barındırır.
    class Urun
    {
        public string Ad;
        public string Marka;
        public string Model;
        public string Ozellik;
        public int HamFiyat;
        public int SecilenAdet;
        public int SecilenToplamAdet;
        public int StokAdeti;
        public double KDVFiyat;
    }
//Satılan 4 Ögenin Sınıfları
    //Led Tv Sınıfı
    class LedTV : Urun
    {
        double EkranBoyutu;
        string EkranCozunurlugu;
        Random rastgele = new Random();

        public LedTV(int Ekran)
        {
            Random rastgele = new Random();
            StokAdeti = rastgele.Next(0, 100);
            EkranBoyutu = Ekran;
            EkranCozunurlugu = "1240x720";
            Ad = "Televizyon";
            Marka = "Samsung";
            Model = "Arslan2023";
            Ozellik = "Kayhan Ayar Youtube Kanalını izletir";
            HamFiyat = 4000;
        }
    }
    // Buzdolabı Sınıfı
    class Buzdolabi : LedTV
    {
        int IcHacim;
        string EnerjiSinifi;

        public Buzdolabi(int Hacim):base(30)
        {

            Random rastgele = new Random();
            StokAdeti = rastgele.Next(100, 10000) % 100;
            IcHacim = Hacim;
            EnerjiSinifi = "A++";
            Ad = "Buzdolabı";
            Marka = "Samsung";
            Model = "AntiCorona";
            Ozellik = "Besinleri Covid-19'dan Arındırır";
            HamFiyat = 3500;

        }


    }
    //Laptop Sınıfı
    class Laptop : Buzdolabi
    {
        double EkranBoyutu;
        string EkranCozunurlugu;
        string DahiliHafiza;
        string RamKapasitesi;
        string PilGucu;
        
        public Laptop(string Lram):base(600)
        {
            EkranBoyutu = 17.3;
            EkranCozunurlugu = "800x400";
            DahiliHafiza = "1TB";
            RamKapasitesi = Lram;
            PilGucu = "20.000mAh";
            Random rastgele = new Random();
            StokAdeti = Convert.ToInt32(DateTime.Now.Second * 5 / 3);
            Ad = "Laptop";
            Marka = "Monster";
            Model = "Ayar A.S";
            Ozellik = "Skyrim oynamamızı sağlar";
            HamFiyat = 6000;
        }

    }
    //Cep Telefonu Sınıfı
    class CepTel : Laptop
    {

        string DahiliHafiza;
        string RamKapasitesi;
        string PilGucu;
        public CepTel(string ram):base("4GB")
        {
            Ad = "Telefon";
            Marka = "Samsung";
            Model = "Note 4";
            Ozellik = "Arama Yapabilme";
            StokAdeti = DateTime.Now.Millisecond % 100;
            HamFiyat = 2500;
            DahiliHafiza = "64GB";
            RamKapasitesi = ram;
            PilGucu = "5000 mAh";
        }

    }

    //Sepete eklenecek ürünlerin KDV dajhil fiyatları burada hesaplanır.
     class Sepet : CepTel
    {
        public double KdvUygula(CepTel Tel)
        {
            double KDVFiyat = Tel.HamFiyat * 1.20;
            return KDVFiyat;
        }
        public double KdvUygula(Laptop Pc)
        {
            double KDVFiyat = Pc.HamFiyat * 1.15;
            return KDVFiyat;

        }
        public double KdvUygula(Buzdolabi Buz)
        {
            double KDVFiyat = Buz.HamFiyat * 1.05;
            return KDVFiyat;
        }

        public double KdvUygula(LedTV tv)
        {
            double KDVFiyat = tv.HamFiyat * 1.18;
            return KDVFiyat;
        }
        
        public Sepet() : base("4GB") { }
        

       

    }
}
