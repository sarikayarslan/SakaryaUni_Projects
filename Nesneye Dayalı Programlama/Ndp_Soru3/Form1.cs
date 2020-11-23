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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SAtılacak Nesneleri oluşturuyoruz
        LedTV tv = new LedTV(30); //Parametre -> Ekran Boyutu
        Buzdolabi Buz = new Buzdolabi(600);// Parametre -> İçHacim
        Laptop Pc = new Laptop("16GB");// Parametre ->Ram Kapasitesi
        CepTel Tel = new CepTel("4GB");// Parametre ->Ram Kapasitesi

        //Sepete Ekle butonunun komutlarını içerir
        private void BtnEkle(object sender, EventArgs e)
        {
            //Secilen Adetleri Atar
            tv.SecilenAdet = Convert.ToInt32(NumericTVAdet.Value);
            Buz.SecilenAdet = Convert.ToInt32(NumericBuzAdet.Value);
            Pc.SecilenAdet = Convert.ToInt32(NumericPcAdet.Value);
            Tel.SecilenAdet = Convert.ToInt32(NumericTelAdet.Value);
            //Sepet Oluşturur
            Sepet sepet = new Sepet();
            //Listboxları hazır hale getirir (temizler)
            AdetList.Items.Clear();
            UrunList.Items.Clear();
            KdvList.Items.Clear();
            //Seçilen adetin stoktakinden az olup olmadığını kontrol eder
            if (tv.SecilenAdet <= tv.StokAdeti && Pc.SecilenAdet <= Pc.StokAdeti &&
                Tel.SecilenAdet <= Tel.StokAdeti && Buz.SecilenAdet <= Buz.StokAdeti)
            {
                //Seçilen adetleri Stoktan Düşer.
                //Televizyon
                tv.StokAdeti = tv.StokAdeti - tv.SecilenAdet;
                TvStok.Text = Convert.ToString(tv.StokAdeti);

                //Buzdolabı
                Buz.StokAdeti = Buz.StokAdeti - Buz.SecilenAdet;
                BuzStok.Text = Convert.ToString(Buz.StokAdeti);

                //Laptop
                Pc.StokAdeti = Pc.StokAdeti - Pc.SecilenAdet;
                PcStok.Text = Convert.ToString(Pc.StokAdeti);

                //CepTel
                Tel.StokAdeti = Tel.StokAdeti - Tel.SecilenAdet;
                TelStok.Text = Convert.ToString(Tel.StokAdeti);
                //Listeye Bastırır
                if (tv.SecilenAdet > 0)
                {
                    AdetList.Items.Add(tv.SecilenAdet);
                    UrunList.Items.Add(tv.Ad);
                    KdvList.Items.Add(sepet.KdvUygula(tv) * tv.SecilenAdet);
                }
                if (Pc.SecilenAdet > 0)
                {
                    AdetList.Items.Add(Pc.SecilenAdet);
                    UrunList.Items.Add(Pc.Ad);
                    KdvList.Items.Add(Convert.ToInt32(sepet.KdvUygula(Pc) * Pc.SecilenAdet));
                }
                if (Buz.SecilenAdet > 0)
                {
                    AdetList.Items.Add(Buz.SecilenAdet);
                    UrunList.Items.Add(Buz.Ad);
                    KdvList.Items.Add(sepet.KdvUygula(Buz) * Buz.SecilenAdet);

                }
                if (Tel.SecilenAdet > 0)
                {
                    AdetList.Items.Add(Tel.SecilenAdet);
                    UrunList.Items.Add(Tel.Ad);
                    KdvList.Items.Add(sepet.KdvUygula(Tel) * Tel.SecilenAdet);
                }
                int toplam = 0;
                for (int i = 0; i < KdvList.Items.Count; i++)
                {
                    toplam += Convert.ToInt32(KdvList.Items[i]);
                }
                ToplamFiyat.Text = Convert.ToString(toplam) + " ₺";


                NumericTVAdet.Value = 0;
                NumericPcAdet.Value = 0;
                NumericBuzAdet.Value = 0;
                NumericTelAdet.Value = 0;
            }
            // Stok Sayısını ve adeti denetler ve uyarı verir
            else
            {
                MessageBox.Show("Seçilen Adet Stok Sayısından Fazla Lütfen Kontrol Ediniz");
            }
        }
        //Sepeti Temizle Butonunun Kodları
        private void BtnTemzle(object sender, EventArgs e)
        {
            //Listeyi temizler
            //Stokları ilk haline getirir

            tv.StokAdeti = tv.SecilenToplamAdet;
            Pc.StokAdeti = Pc.SecilenToplamAdet;
            Tel.StokAdeti = Tel.SecilenToplamAdet;
            Buz.StokAdeti = Buz.SecilenToplamAdet;
            TvStok.Text = Convert.ToString(tv.StokAdeti);
            BuzStok.Text = Convert.ToString(Buz.StokAdeti);
            PcStok.Text = Convert.ToString(Pc.StokAdeti);
            TelStok.Text = Convert.ToString(Tel.StokAdeti);

            AdetList.Items.Clear();
            UrunList.Items.Clear();
            KdvList.Items.Clear();
            ToplamFiyat.Text = "0 ₺";
            NumericTVAdet.Value = 0;
            NumericPcAdet.Value = 0;
            NumericBuzAdet.Value = 0;
            NumericTelAdet.Value = 0;
        }
    }
    

}
