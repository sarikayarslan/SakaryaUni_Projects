/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 	PROJE
**				ÖĞRENCİ ADI............: 	ARSLANCAN SARIKAYA
**				ÖĞRENCİ NUMARASI.......:	B181210052
**                         DERSİN ALINDIĞI GRUP...: D
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Saniye;
        // Atık kutularını oluşturur.
        OrganikKutusu organikKutusu = new OrganikKutusu();
        KagitKutusu kagitKutusu = new KagitKutusu();
        CamKutusu camKutusu = new CamKutusu();
        MetalKutusu metalKutusu = new MetalKutusu();
        
        
        //Atıkları oluşturur
        /// <summary>
        /// domates
        /// </summary>
        Atik organikAtik1 = new Atik(150, Image.FromFile("domates.png"));
        /// <summary>
        /// salatalik
        /// </summary>
        Atik organikAtik2 = new Atik(120, Image.FromFile("salatalik.png"));
        /// <summary>
        /// gazete
        /// </summary>
        Atik kagitAtik1 = new Atik(250, Image.FromFile("gazete.png"));
        /// <summary>
        /// dergi
        /// </summary>
        Atik kagitAtik2 = new Atik(200, Image.FromFile("dergi.png"));
        /// <summary>
        /// Kola Kutusu
        /// </summary>
        Atik metalAtik1 = new Atik(350, Image.FromFile("kola.png"));
        /// <summary>
        /// Salça Kutusu
        /// </summary>
        Atik metalAtik2 = new Atik(550, Image.FromFile("salca.png"));
        /// <summary>
        /// Cam Şişe
        /// </summary>
        Atik camAtik1 = new Atik(600, Image.FromFile("camsise.png"));
        /// <summary>
        /// Bardak
        /// </summary>
        Atik camAtik2 = new Atik(250, Image.FromFile("bardak.png"));
        List<Atik> atiklar = new List<Atik>();

       
        //Atıkları bir listeye ekler bu sayede her atığın nuamrayla denetleyebiliriz.
        void AtıkListesi()
        {
            atiklar.Add(organikAtik1);
            atiklar.Add(organikAtik2);
            atiklar.Add(kagitAtik1);
            atiklar.Add(kagitAtik2);
            atiklar.Add(metalAtik1);
            atiklar.Add(metalAtik2);
            atiklar.Add(camAtik1);
            atiklar.Add(camAtik2);
        }
        //Rastgele atık çağırmak için atiksayisi adında rastgele atanacak bir değişken tanımlar
        Random rastgele = new Random();
        int atikNo;
        //Resim kutusuna yeni bir atık atar
        void YeniResim()
        {
             atikNo = rastgele.Next(0, 8);
            ResimKutusu.Image = atiklar[atikNo].Image;
        }

        //Kullanıcının puanını tutar.
        int kullaniciPuan = 0;

        //Yeni oyun butonuna click eylemini tanımlar.
        // listeleri temizler ve butonları aktif hale getirir 
        //sayacı başlatır ve barların değerlerini sıfırlar 
        private void yenioyunbuton_Click(object sender, EventArgs e)
        {
            Saniye = 60;
            AtıkListesi();
            YeniResim();
            timer1.Start();
            kullaniciPuan = 0;
            puan.Text = Convert.ToString(kullaniciPuan);
            puan.Visible = Enabled;
            sure.Visible = Enabled;
            liste1.Items.Clear();
            liste2.Items.Clear();
            liste3.Items.Clear();
            liste4.Items.Clear();
            organikButon.Enabled = true;
            camButon.Enabled = true;
            kagitButon.Enabled = true;
            metalButon.Enabled = true;
            organikBosaltButon.Enabled = true;
            camBosaltButon.Enabled = true;
            metalBosaltButon.Enabled = true;
            kagitBosaltButon.Enabled = true;
            organikBar.Value = 0;
            camBar.Value = 0;
            metalBar.Value = 0;
            kagitBar.Value = 0;
        }


     
        //atık kutusu listelerine yazılacak atıkları denetler ve listelerine yazar
        void ListeYaz()
        {
            switch (atikNo)
            {
                case 0:
                    liste1.Items.Add("Domates (150)");
                    break;

                case 1:
                    liste1.Items.Add("Salatalık (120)");
                    break;

                case 2:
                    liste2.Items.Add("Gazete (250)");
                    break;

                case 3:
                    liste2.Items.Add("Dergi (200)");
                    break;

                case 4:
                    liste4.Items.Add("Kola Kutusu (350)");
                    break;

                case 5:
                    liste4.Items.Add("Salça Kutusu (550)");
                    break;

                case 6:
                    liste3.Items.Add("Cam Şişe (600)");
                    break;

                case 7:
                    liste3.Items.Add("Bardak (250)");
                    break;

            }
        }
        /* Aık butonları çakışma mantığı
         * butona bastığınızda atıklistesinde atıklara atanan numaralara göre
         * atıkların kutuya olup olmadığı denetlenir eğer uygunsa
         * atığın puanı kullanıcın puanına eklenir daha sonra atık listeye yazılır
         * daha sonra yeni bir resim atanır.
             */

        //Organik atık butonunun tıklama eylemi
        private void organikButon_Click(object sender, EventArgs e)
        {

            if (atikNo == 0 && organikKutusu.Kapasite - organikKutusu.DoluHacim >= atiklar[atikNo].Hacim)
            {
                organikKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();
            }

            else if (atikNo == 1 && organikKutusu.Kapasite - organikKutusu.DoluHacim >= atiklar[atikNo].Hacim) 
            {
                organikKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();

            }
            organikBar.Value = organikKutusu.DolulukOrani;
            puan.Text = Convert.ToString(kullaniciPuan);

        }
        //kağıt atık butonunun tıklama eylemi

        private void kagitButon_Click(object sender, EventArgs e)
        {
            if (atikNo == 2 && kagitKutusu.Kapasite - kagitKutusu.DoluHacim >= atiklar[atikNo].Hacim)
            {
                kagitKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();
            }

            else if (atikNo == 3 && kagitKutusu.Kapasite - kagitKutusu.DoluHacim >= atiklar[atikNo].Hacim) 
            {
                kagitKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();

            }
            kagitBar.Value = kagitKutusu.DolulukOrani;
            puan.Text = Convert.ToString(kullaniciPuan);

        }
        //metal atık butonunun tıklama eylemi
        private void metalButon_Click(object sender, EventArgs e)
        {
            if (atikNo == 4 && metalKutusu.Kapasite - metalKutusu.DoluHacim >= atiklar[atikNo].Hacim)
            {
                metalKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();

            }


            else if (atikNo == 5 && metalKutusu.Kapasite - metalKutusu.DoluHacim >= atiklar[atikNo].Hacim) 
            {
                metalKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();

            }
            metalBar.Value = metalKutusu.DolulukOrani;
            puan.Text = Convert.ToString(kullaniciPuan);

        }
        //cam atık butonunun tıklama eylemi

        private void camButon_Click(object sender, EventArgs e)
        {
            if (atikNo == 6 && camKutusu.Kapasite - camKutusu.DoluHacim >= atiklar[atikNo].Hacim)
            {
                camKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();

            }

            else if (atikNo == 7 && camKutusu.Kapasite - camKutusu.DoluHacim >= atiklar[atikNo].Hacim) 
            {
                camKutusu.Ekle(atiklar[atikNo]);
                kullaniciPuan += atiklar[atikNo].Hacim;
                ListeYaz();
                YeniResim();

            }
            camBar.Value = camKutusu.DolulukOrani;
            puan.Text = Convert.ToString(kullaniciPuan);
        }
        /*
         Boşalt butonlarının çalışma mantığı
         
             Butona bastığımızda eğer Doluluk oranı %75 üstündeyse
             Saniyeye 3 saniye daha ekler 
             her kutunun kendine has puanını kullanıcının puanına ekler
             doluhacimi sıfırlar
             listesini temizler
             */




        //Organik boşalt butonunun tıklama eylemi

        private void organikBosaltButon_Click(object sender, EventArgs e)
        {
            if (organikKutusu.DolulukOrani>=75)
            {
                Saniye += 3;
                organikKutusu.Bosalt();
                kullaniciPuan += organikKutusu.BosaltmaPuani;

                organikBar.Value = organikKutusu.DolulukOrani;
                puan.Text = Convert.ToString(kullaniciPuan);
                liste1.Items.Clear();

            }
        }
        //kağıt boşalt butonunun tıklama eylemi

        private void kagitBosaltButon_Click(object sender, EventArgs e)
        {
            if (kagitKutusu.DolulukOrani >= 75) {
                Saniye += 3;
                kagitKutusu.Bosalt();
                kullaniciPuan += kagitKutusu.BosaltmaPuani;

                kagitBar.Value = kagitKutusu.DolulukOrani;
                puan.Text = Convert.ToString(kullaniciPuan);
                liste2.Items.Clear();

            }
        }
        //cam boşalt butonunun tıklama eylemi

        private void camBosaltButon_Click(object sender, EventArgs e)
        {
            if (camKutusu.DolulukOrani >= 75)
            {
                Saniye += 3;
                camKutusu.Bosalt();
                kullaniciPuan += camKutusu.BosaltmaPuani;

                camBar.Value = camKutusu.DolulukOrani;
                puan.Text = Convert.ToString(kullaniciPuan);
                liste3.Items.Clear();

            }
        }
        //metal boşalt butonunun tıklama eylemi

        private void metalBosaltButon_Click(object sender, EventArgs e)
        {
            if (metalKutusu.DolulukOrani >= 75)
            {
                Saniye += 3;
                metalKutusu.Bosalt();
                kullaniciPuan += metalKutusu.BosaltmaPuani;
                liste4.Items.Clear();

                metalBar.Value = metalKutusu.DolulukOrani;
                puan.Text = Convert.ToString(kullaniciPuan);
            }
        }

        //Geri Sayim Değişkenleri
        /*
         Timerın nasıl çalışacağı ve saniye 0 olduğuna neler yapılacağını içerir
         zaman 0 olduğunda bütün butonları pasif hale getirir
         timerı durdurur.

             */
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            Saniye -= 1;
            sure.Text = Saniye.ToString();
            if (Saniye == 0)
            {
                timer1.Stop();
                organikButon.Enabled = false;
                camButon.Enabled = false;
                kagitButon.Enabled = false;
                metalButon.Enabled = false;
                organikBosaltButon.Enabled = false;
                camBosaltButon.Enabled = false;
                metalBosaltButon.Enabled = false;
                kagitBosaltButon.Enabled = false;

            }
        }
        //çıkış butonunun tıklama eyleimini içerir
        // uygulamadan çıkmamızı sağlar.
        private void cikisbuton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
