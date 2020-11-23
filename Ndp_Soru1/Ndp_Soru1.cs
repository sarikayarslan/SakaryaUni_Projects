/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Arslancan SARIKAYA
**				ÖĞRENCİ NUMARASI.......: B181210052
**                         DERSİN ALINDIĞI GRUP...: D
****************************************************************************/







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_4
{

    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int number = 100;
        public int score1 { get; set; }
        public int score2 { get; set; }
        public int score3 { get; set; }
        public int score4 { get; set; }

        public double avarage { get; set; }
   }




    class Program
    {
        static void Main(string[] args)
        {
            
            //Notların Ortalamaya etki yüzdeleri
            double rate1 = 0.1;
            double rate2 = 0.1;
            double rate3 = 0.3;
            double rate4 = 0.4;

            //öğrenci isimlerinin ve istatistiklerin yazılacağı yolları tutar
            string path = @"C:\Users\Arslan S\Desktop\info.txt";
            string pathresult = @"C:\Users\Arslan S\Desktop\result.txt";
            //seçilecek rastgele isim ve soyisimleri tutar
            string[] namearray = { "Arslan", "Aslı", "Oguz", "Gizem", "Senol", "Cemile", "Bahri", "Feyza", "Emre", "Kayhan",
                                      "Serkan", "Ersin", "Burak", "Merve", "İrem", "Berfin", "Mesut", "Furkan", "Sebnem", "Ebru" };
            string[] surnamearray = { "Sarikaya", "Yildirim", "Guven", "Guler", "Escobar", "Marley", "Turk", "Tatlises",
                                       "Aydin", "Gunes", "Kocak", "Gungor", "Akkaya", "Demir", "Ayar","Avsar","Acar","Alkan","Aydin","Ozyurt"};




            System.IO.StreamWriter WText = new System.IO.StreamWriter(path);
            Random random = new Random();
            Student[] studentlist = new Student[101];
            WText.WriteLine(rate1*100 + " " + rate2*100 + " " + rate3*100 + " " + rate4*100 + " " );
            for (int i = 0; i < 101; i++)
            {

                //Öğrenci dizisinie rastgele öğrenci verileri girer
                studentlist[i] = new Student();
                studentlist[i].name = namearray[random.Next(20)];
                studentlist[i].surname = surnamearray[random.Next(20)];
                studentlist[i].number += i;
                studentlist[i].score1 = random.Next(0, 100);
                studentlist[i].score2 = random.Next(0, 100);
                studentlist[i].score3 = random.Next(0, 100);
                studentlist[i].score4 = random.Next(0, 100);
                studentlist[i].avarage = (studentlist[i].score1 *rate1 + studentlist[i].score2 * rate2
                                        + studentlist[i].score3 *rate3 + studentlist[i].score4 * rate4);
                //Girilen öğrenci verilerini desktop/info.txt dosyasına yazdırır.
                WText.WriteLine(studentlist[i].name + " " +
                                studentlist[i].surname + " " +
                                studentlist[i].number + " " +
                                studentlist[i].score1 + " " +
                                studentlist[i].score2 + " " +
                                studentlist[i].score3 + " " +
                                studentlist[i].score4);

            }
            WText.Close();
            //Öğrenci bilgilerini konsol ekranına yazdırır
            for (int i = 0; i < studentlist.Length; i++)
            {
                Console.WriteLine(studentlist[i].name + " " +
                                studentlist[i].surname + " " +
                                studentlist[i].number + " " +
                                studentlist[i].score1 + " " +
                                studentlist[i].score2 + " " +
                                studentlist[i].score3 + " " +
                                studentlist[i].score4);
                for (int k = 0; k < 30; k++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            //istatistiklerin yazdırılıp yazdırılmayacağını sorar
            Console.WriteLine("İstatistikleri Yazdirmak İster Misiniz E/H");
            string answer = Convert.ToString(Console.ReadLine());

            int AA = 0;
            int BA = 0;
            int BB = 0;
            int CB = 0;
            int CC = 0;
            int DC = 0;
            int DD = 0;
            int FD = 0;
            int FF = 0;
            //Eğer cevap E,e ise istatistikleri oluşturur
            if (answer == "e" || answer == "E")
            {
                for (int i = 0; i < studentlist.Length; i++)
                {
                    if (studentlist[i].avarage >= 90)
                    {
                        AA++;
                    }
                    else if (studentlist[i].avarage >= 85)
                    {
                        BA++;
                    }
                    else if (studentlist[i].avarage >= 80)
                    {
                        BB++;
                    }
                    else if (studentlist[i].avarage >= 75)
                    {
                        CB++;
                    }
                    else if (studentlist[i].avarage >= 65)
                    {
                        CC++;
                    }
                    else if (studentlist[i].avarage >= 58)
                    {
                        DC++;
                    }
                    else if (studentlist[i].avarage >= 50)
                    {
                        DD++;
                    }
                    else if (studentlist[i].avarage >= 40)
                    {
                        FD++;
                    }
                    else if (studentlist[i].avarage >= 0)
                    {
                        FF++;
                    }

                }
                //İstatistikleri konsol ekranına basar
                Console.WriteLine("AA    {0} \nBA    {1} \nBB    {2} \nCB    {3} \nCC    {4} " +
                               "\nDC    {5} \nDD    {6} \nFD    {7} \nFF    {8}", AA, BA, BB, CB, CC, DC, DD, FD, FF);
                Console.WriteLine("Gecen öğrenci Sayısı  {0} \nKalan Öğrenci Sayısı  {1}", studentlist.Length - FD - FF, FD + FF);
                System.IO.StreamWriter result = new System.IO.StreamWriter(pathresult);
                result.WriteLine("AA    {0} \nBA    {1} \nBB    {2} \nCB    {3} \nCC    {4} " +
                               "\nDC    {5} \nDD    {6} \nFD    {7} \nFF    {8}", AA, BA, BB, CB, CC, DC, DD, FD, FF);
                //istatistikleri desktop/result.txt dosyasına yazar
                result.WriteLine("Gecen öğrenci Sayısı  {0} \nKalan Öğrenci Sayısı  {1}", studentlist.Length - FD - FF, FD + FF);
                result.Close();

            }





            Console.Read();

        }
    }
}
