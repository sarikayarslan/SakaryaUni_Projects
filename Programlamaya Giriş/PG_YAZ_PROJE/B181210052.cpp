/*******************************************************************************************
*					SAKARYA ÜNİVERSİTESİ												
*			BİLGİSAYAR VE BİLİSİM BİLİMLERİ FAKULTESİ
*					BİLGİSAYAR MÜHENDİSLİĞİ 
*				PROGRAMLAMAYA GİRİŞ DERSİ
*
*
*				ÖDEV NUMARASI...: 1
*				ÖĞRENCİ ADI...: ARSLANCAN SARIKAYA
*				ÖĞRENCİ NUMARASI...: B181210052
*				DERS GRUBU...: A GRUBU
*
*
*******************************************************************************************/

#include <windows.h>
#include <fstream>
#include <iostream>
#include <stdio.h> 
#include <string>
#include <sstream> 
#include<iomanip>

using namespace std;
int main()
{
	class Malzeme
	{
	public:
		int MalNo;
		string MalAdi;
		string MalBirimi;
		int BirimFiyatı;
		string MalMarka;
	};

	class Proje
	{
	public:
		int ProjeNo;
		string ProjeAdi;
		string ProjeFirma;
		string ProjeSorumlusu;
		string ProjeKontrolor;
		string Hakedis;

	};

	class Hakedis
	{
	public:
		int HakedisDonem;
		int ProjeNo;
		int UrunKodu;
		int KullanilanAdet;
		int Tutar;
	};
	string tekrar;
	int ToplamMaliyet;

	Proje ProjeDizisi = Proje();
	Malzeme MalDizisi = Malzeme();
	Hakedis HakedisDizisi = Hakedis();
	int secim;


	//Proje Dosya İslemlerinin Degiskenleri
	ofstream yedekProje("yedek2.txt");
	fstream dosyaProje("Projeler.txt", ios::in || ios::out || ios::app);
	string GirUrunAdi;
	string GirUrunBirimi;
	int  GirUrunFiyati;
	int GirUrunKodu;
	string GirUrunMarka;
	ofstream yedek("yedek.txt");
	fstream dosyaMalzeme("Malzemeler.txt", ios::in || ios::out || ios::app);
	string satir;
	
	//Kullanıcıdan İstenen Proje Degiskenleri
	int GirProjeNo;
	string GirProjeAdi;
	string GirProjeFirma;
	string GirProjeSorumlu;
	string GirProjeKontrolor;
	string GirHakedis;
	string HakedisVerildi = "Verildi";

	//Hakedis Dosyalarını Tanımlama
	ofstream yedekHakedis("yedek3.txt");
	fstream dosyaHakedis("Hakedis.txt", ios::in || ios::out || ios::app);


	do
	{
		system("cls");
		// Menu Secimi
		cout << "Yapmak Istediginiz Islemi Seciniz" << endl;
		cout << "1) Urun Islemlerine Gitmek Istiyorum" << endl;
		cout << "2) Proje Islemlerine Gitmek Istiyorum" << endl;
		cout << "3) Hakedis Islemlerine Gitmek Istiyorum" << endl;

		cin >> secim;

		switch (secim)
		{
			// Urun Menusuunde Yapılacak İslemler
		case 1:
			cout << "Yapmak Istediginiz Islemi Seciniz" << endl;
			cout << "1) Urun Ekleme" << endl;
			cout << "2) Urun Silme" << endl;
			cout << "3) Urun Arama" << endl;
			cout << "4) Raporlama" << endl;
			cin >> secim;

			switch (secim)
			{
				//Ürün Ekleme
			case 1:
				/*bu menude ürün dosyasını sonuna kadar okutuyorum ve urun kodunu en son urunun bir fazlası olarak yazdırıyuorum bu sayede hiç bir urun dosyasının kodu aynı olmuyor*/
				cout << "Urun Adi Giriniz...:";
				cin >> GirUrunAdi;

				cout << "Urun Birimi Giriniz...:";
				cin >> GirUrunBirimi;

				cout << "Urun Birim Fiyati Giriniz...:";
				cin >> GirUrunFiyati;

				cout << "Urun Markasını Giriniz...:";
				cin >> GirUrunMarka;


				while (!dosyaMalzeme.eof())
				{
					getline(dosyaMalzeme, satir);
					MalDizisi.MalNo = stoi(satir);

					getline(dosyaMalzeme, satir);
					MalDizisi.MalAdi = satir;

					getline(dosyaMalzeme, satir);
					MalDizisi.MalBirimi = satir;

					getline(dosyaMalzeme, satir);
					MalDizisi.BirimFiyatı = stoi(satir);

					getline(dosyaMalzeme, satir);
					MalDizisi.MalMarka = satir;

					yedek << MalDizisi.MalNo << endl;
					yedek << MalDizisi.MalAdi << endl;
					yedek << MalDizisi.MalBirimi << endl;
					yedek << MalDizisi.BirimFiyatı << endl;
					yedek << MalDizisi.MalMarka << endl;

				}
				yedek << MalDizisi.MalNo + 1 << endl;
				yedek << GirUrunAdi << endl;
				yedek << GirUrunBirimi << endl;
				yedek << GirUrunFiyati << endl;
				yedek << GirUrunMarka;

				yedek.close();
				dosyaMalzeme.close();
				remove("Malzemeler.txt");
				rename("yedek.txt", "Malzemeler.txt");


				break;

				//Ürün Silme
			case 2:
				/*bu bölümde silinecek ürünün bilgisini alıyorum yedek dosyasına tekrar yazdırıyorum eğer 
				girilen ürün özellikleri ilk dosyadan okunanla aynı ise o ürünü yedeğe yazmıyor*/
				cout << "Urun Kodunu Giriniz...:";
				cin >> GirUrunKodu;

				while (!dosyaMalzeme.eof())
				{
					getline(dosyaMalzeme, satir);
					MalDizisi.MalNo = stoi(satir);

					getline(dosyaMalzeme, satir);
					MalDizisi.MalAdi = satir;

					getline(dosyaMalzeme, satir);
					MalDizisi.MalBirimi = satir;

					getline(dosyaMalzeme, satir);
					MalDizisi.BirimFiyatı = stoi(satir);

					getline(dosyaMalzeme, satir);
					MalDizisi.MalMarka = satir;

					if (GirUrunKodu != MalDizisi.MalNo)
					{
						yedek << MalDizisi.MalNo << endl;
						yedek << MalDizisi.MalAdi << endl;
						yedek << MalDizisi.MalBirimi << endl;
						yedek << MalDizisi.BirimFiyatı << endl;
						yedek << MalDizisi.MalMarka;
						if (!dosyaMalzeme.eof())
						{
							yedek << endl;
						}
					}

				}
				yedek.close();
				dosyaMalzeme.close();
				remove("Malzemeler.txt");
				rename("yedek.txt", "Malzemeler.txt");
				break;

				//Ürün Arama
			case 3:
				/* Bu menüde ürün adını kullanıcıdan alıp malzemeler.txt yi okutuyorum
				eğer böyle bir ürün varsa onu ekrana bastırıyr.*/
				cout << "Urun Adini Giriniz...:";
				cin >> GirUrunAdi;

				while (!dosyaMalzeme.eof())
				{
					getline(dosyaMalzeme, satir);
					MalDizisi.MalNo = stoi(satir);

					getline(dosyaMalzeme, satir);
					MalDizisi.MalAdi = satir;

					getline(dosyaMalzeme, satir);
					MalDizisi.MalBirimi = satir;

					getline(dosyaMalzeme, satir);
					MalDizisi.BirimFiyatı = stoi(satir);

					getline(dosyaMalzeme, satir);
					MalDizisi.MalMarka = satir;

					if (GirUrunAdi == MalDizisi.MalAdi) {
						cout << MalDizisi.MalAdi << endl;
						cout << MalDizisi.MalBirimi << endl;
						cout << MalDizisi.MalNo << endl;
						cout << MalDizisi.BirimFiyatı << endl;
						cout << MalDizisi.MalMarka;
					}
					else
					{
						cout << "Boyle Bir Urun Bulunmamaktadir..";
					}

				}
				yedek.close();
				dosyaMalzeme.close();
				break;

				//Raporlama
			case 4:
				secim = 0;
				int RaporSecim;
				cout << endl << endl;
				cout << "1) Markaya Gore Raporla" << endl;
				cout << "2) Fiyat Araligina Gore Raporla (Birim Fiyat)" << endl;
				cout << "3) Butun Urunleri Listele" << endl;
				cout << " Raporlama Cesidini Seciniz...:" << endl;
				cin >> RaporSecim;

				switch (RaporSecim)
				{
					//Markaya Göre Raporlama
					/*Bu menüdeki bütün işlemlerde ürün aramadaki algoritmayı kullanıyorum mantıkları tamamen aynı*/
				case 1:
					cout << "Urun Markasini  Giriniz...:";
					cin >> GirUrunMarka;

					while (!dosyaMalzeme.eof())
					{

						getline(dosyaMalzeme, satir);
						MalDizisi.MalNo = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalAdi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.MalBirimi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.BirimFiyatı = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalMarka = satir;

						if (GirUrunMarka == MalDizisi.MalMarka) {
							cout << MalDizisi.MalAdi << endl;
							cout << MalDizisi.MalBirimi << endl;
							cout << MalDizisi.MalNo << endl;
							cout << MalDizisi.BirimFiyatı << " Lira" << endl;
							cout << MalDizisi.MalMarka << endl;
						}

					}


					break;
					//Fiyat Aralığına Göre Raporlama
				case 2:
					int GirMinTutar;
					int GirMaxTutar;


					cout << "Minimum Fiyat Giriniz...:";
					cin >> GirMinTutar;

					cout << "Limit Fiyat Giriniz...:";
					cin >> GirMaxTutar;

					while (!dosyaMalzeme.eof())
					{

						getline(dosyaMalzeme, satir);
						MalDizisi.MalNo = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalAdi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.MalBirimi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.BirimFiyatı = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalMarka = satir;

						if (GirMinTutar <= MalDizisi.BirimFiyatı && GirMaxTutar >= MalDizisi.BirimFiyatı) {
							cout << MalDizisi.MalAdi << endl;
							cout << MalDizisi.MalBirimi << endl;
							cout << MalDizisi.MalNo << endl;
							cout << MalDizisi.BirimFiyatı << " Lira" << endl;
							cout << MalDizisi.MalMarka << endl;
						}

					}
					break;
					// Bütün Ürünleri Raporlama
				case 3:

					while (!dosyaMalzeme.eof())
					{

						getline(dosyaMalzeme, satir);
						MalDizisi.MalNo = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalAdi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.MalBirimi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.BirimFiyatı = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalMarka = satir;

						cout << MalDizisi.MalAdi << endl;
						cout << MalDizisi.MalBirimi << endl;
						cout << MalDizisi.MalNo << endl;
						cout << MalDizisi.BirimFiyatı << " Lira" << endl;
						cout << MalDizisi.MalMarka << endl << endl;
					}
					break;
				}
			}

			break;
			//Proje İslemleri
			/*Ekleme Silme Düzenleme İslemlerinde 2 dosya kullanıyorum en son yedek dosyasına asıl dosyanın ismini veriyorum.*/
		case 2:
			secim = 0;
			cout << "Yapmak Istediginiz Islemi Seciniz" << endl;
			cout << "1) Proje Ekleme" << endl;
			cout << "2) Proje Silme (Hakedis Verilmisler Silinemez)" << endl;
			cout << "3) Proje Arama" << endl;
			cout << "4) Proje Raporlama" << endl;
			cin >> secim;




			switch (secim)
			{
				//Proje Ekleme
			case 1:

				cout << "Proje Adi Giriniz...:";
				cin >> GirProjeAdi;

				cout << "Proje Firmasi Giriniz...:";
				cin >> GirProjeFirma;

				cout << "Proje Sorumlusu Giriniz...:";
				cin >> GirProjeSorumlu;

				cout << "Proje Kontroloru Giriniz...:";
				cin >> GirProjeKontrolor;

				cout << "Projenin Hakedis Durumunu Giriniz (Verildi/Verilmedi)...:";
				cin >> GirHakedis;


				while (!dosyaProje.eof())
				{
					getline(dosyaProje, satir);
					ProjeDizisi.ProjeNo = stoi(satir);

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeAdi = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeFirma = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeSorumlusu = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeKontrolor = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.Hakedis = satir;

					yedekProje << ProjeDizisi.ProjeNo << endl;
					yedekProje << ProjeDizisi.ProjeAdi << endl;
					yedekProje << ProjeDizisi.ProjeFirma << endl;
					yedekProje << ProjeDizisi.ProjeSorumlusu << endl;
					yedekProje << ProjeDizisi.ProjeKontrolor << endl;
					yedekProje << ProjeDizisi.Hakedis << endl;

				}
				yedekProje << ProjeDizisi.ProjeNo + 1 << endl;
				yedekProje << GirProjeAdi << endl;
				yedekProje << GirProjeFirma << endl;
				yedekProje << GirProjeSorumlu << endl;
				yedekProje << GirProjeKontrolor << endl;
				yedekProje << GirHakedis;

				yedekProje.close();
				dosyaProje.close();
				remove("Projeler.txt");
				rename("yedek2.txt", "Projeler.txt");

				break;

				//Proje Silme
			case 2:

				cout << "Proje Numarasi Giriniz...:";
				cin >> GirProjeNo;



				while (!dosyaProje.eof())
				{
					getline(dosyaProje, satir);
					ProjeDizisi.ProjeNo = stoi(satir);

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeAdi = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeFirma = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeSorumlusu = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeKontrolor = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.Hakedis = satir;

					if (GirProjeNo != ProjeDizisi.ProjeNo || ProjeDizisi.Hakedis == HakedisVerildi)
					{
						yedekProje << ProjeDizisi.ProjeNo << endl;
						yedekProje << ProjeDizisi.ProjeAdi << endl;
						yedekProje << ProjeDizisi.ProjeFirma << endl;
						yedekProje << ProjeDizisi.ProjeSorumlusu << endl;
						yedekProje << ProjeDizisi.ProjeKontrolor << endl;
						yedekProje << ProjeDizisi.Hakedis;
						if (!dosyaProje.eof())
						{
							yedekProje << endl;
						}
					}
				}
				yedekProje.close();
				dosyaProje.close();
				remove("Projeler.txt");
				rename("yedek2.txt", "Projeler.txt");

				break;

				// Proje Arama
			case 3:
				cout << "Proje Adini Giriniz...:";
				cin >> GirProjeAdi;

				while (!dosyaMalzeme.eof())
				{

					while (!dosyaProje.eof())
					{
						getline(dosyaProje, satir);
						ProjeDizisi.ProjeNo = stoi(satir);

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeAdi = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeFirma = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeSorumlusu = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeKontrolor = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.Hakedis = satir;

						if (GirProjeAdi == ProjeDizisi.ProjeAdi) {
							cout <<"Proje No: "<< ProjeDizisi.ProjeNo << endl;
							cout <<"Proje Adi: "<< ProjeDizisi.ProjeAdi << endl;
							cout <<"Proje Firmasi: "<< ProjeDizisi.ProjeFirma << endl;
							cout <<"Proje Sorumlusu:  "<< ProjeDizisi.ProjeSorumlusu << endl;
							cout <<"Proje kontroloru: "<< ProjeDizisi.ProjeKontrolor << endl;
							cout <<"Proje Hakedis Durumu: "<< ProjeDizisi.Hakedis << endl;
						}

					}
				}
				break;
				//Proje Raporlama
			case 4:
				secim = 0;
				cout << "1) Hakedisi Verilenleri Raporla " << endl;
				cout << "2) Hakedisi Verilmeyenleri Raporla " << endl;

				cin >> secim;
				//Hakedisi Verilmeyen ve Verilene Gore Raporlar
				switch (secim)
				{
				case 1:
					while (!dosyaProje.eof())
					{

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeNo = stoi(satir);

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeAdi = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeFirma = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeSorumlusu = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeKontrolor = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.Hakedis = satir;

						if (HakedisVerildi == ProjeDizisi.Hakedis) {
							cout << ProjeDizisi.ProjeNo << endl;
							cout << ProjeDizisi.ProjeAdi << endl;
							cout << ProjeDizisi.ProjeFirma << endl;
							cout << ProjeDizisi.ProjeSorumlusu << endl;
							cout << ProjeDizisi.ProjeKontrolor << endl;
							cout << ProjeDizisi.Hakedis << endl;
						}

					}
					break;

				case 2:
					while (!dosyaProje.eof())
					{

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeNo = stoi(satir);

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeAdi = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeFirma = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeSorumlusu = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.ProjeKontrolor = satir;

						getline(dosyaProje, satir);
						ProjeDizisi.Hakedis = satir;

						if (HakedisVerildi != ProjeDizisi.Hakedis) {
							cout << ProjeDizisi.ProjeNo << endl;
							cout << ProjeDizisi.ProjeAdi << endl;
							cout << ProjeDizisi.ProjeFirma << endl;
							cout << ProjeDizisi.ProjeSorumlusu << endl;
							cout << ProjeDizisi.ProjeKontrolor << endl;
							cout << ProjeDizisi.Hakedis << endl;
						}

					}

					break;
				}
				break;
			}

			break;
			//Hakediş Raporlama

			/*Burada çoklu dosya işlemlerini kullandım
			hakdeişte kullanılan malzemeleri ve projeleri sadece koduyla hakedişe yazdırıyorum 
			ihtiyaç halinde (ekrana bastırma vb) onların bulunduğu txt dosyalarına gidiyorum
			ve kodlarının eşleştiği dosyaları ekrana bastırıyorum.*/
		case 3:
			int KullanilanAdet;
			int HakedisDonem;
			cout << "1) Malzeme Ekle " << endl;
			cout << "2) Malzeme sil" << endl;
			cout << "3) Malzeme Guncelleme" << endl;
			cout << "4) Proje Hakedis Listele " << endl;
			cout << "5) Hakedislerde Urun Ara " << endl;
			cout << "6) Projenin Hakedis Durumunu Degistir" << endl;
			cin >> secim;



			switch (secim)
			{
				//Malzeme Ekle 
			case 1:
				do
				{

					cout << "Proje Numarasi Giriniz...:" << endl;
					cin >> GirProjeNo;
					cout << "Hakedis Donemi Giriniz...:" << endl;
					cin >> HakedisDonem;
					cout << "Urun Kodunu Giriniz" << endl;
					cin >> GirUrunKodu;
					cout << "Kullanilan Adeti Giriniz...:" << endl;
					cin >> KullanilanAdet;




					while (!dosyaHakedis.eof())
					{
						getline(dosyaHakedis, satir);
						HakedisDizisi.ProjeNo = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.HakedisDonem = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.UrunKodu = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.KullanilanAdet = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.Tutar = stoi(satir);


						yedekHakedis << HakedisDizisi.ProjeNo << endl;
						yedekHakedis << HakedisDizisi.HakedisDonem << endl;
						yedekHakedis << HakedisDizisi.UrunKodu << endl;
						yedekHakedis << HakedisDizisi.KullanilanAdet << endl;
						yedekHakedis << HakedisDizisi.Tutar << endl;
					}

					while (!dosyaMalzeme.eof())
					{
						getline(dosyaMalzeme, satir);
						MalDizisi.MalNo = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalAdi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.MalBirimi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.BirimFiyatı = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalMarka = satir;
						if (GirUrunKodu == MalDizisi.MalNo) {
							break;
						}
					}



					HakedisDizisi.Tutar = KullanilanAdet * MalDizisi.BirimFiyatı;
					yedekHakedis << GirProjeNo << endl;
					yedekHakedis << HakedisDonem << endl;
					yedekHakedis << GirUrunKodu << endl;
					yedekHakedis << KullanilanAdet << endl;
					yedekHakedis << HakedisDizisi.Tutar;
					if (yedekHakedis.eof())
					{
						yedekHakedis << endl;
					}

					yedekHakedis.close();
					dosyaHakedis.close();
					remove("Hakedis.txt");
					rename("yedek3.txt", "Hakedis.txt");
					cout << "Hakedise Yeni Bir Urun Daha Eklemek İster Misiniz? (e/h)...: " << endl;
					cin >> tekrar;

				} while (tekrar == "e");

				break;
				//Malzeme Silme
			case 2:

				do
				{

					cout << "Proje Numarasi Giriniz...:" << endl;
					cin >> GirProjeNo;
					cout << "Hakedis Donemi Giriniz...:" << endl;
					cin >> HakedisDonem;
					cout << "Urun Kodunu Giriniz" << endl;
					cin >> GirUrunKodu;

					while (!dosyaHakedis.eof())
					{
						getline(dosyaHakedis, satir);
						HakedisDizisi.ProjeNo = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.HakedisDonem = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.UrunKodu = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.KullanilanAdet = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.Tutar = stoi(satir);

						if (GirProjeNo != HakedisDizisi.ProjeNo || HakedisDonem != HakedisDizisi.HakedisDonem || GirUrunKodu != HakedisDizisi.UrunKodu)
						{
							yedekHakedis << HakedisDizisi.ProjeNo << endl;
							yedekHakedis << HakedisDizisi.HakedisDonem << endl;
							yedekHakedis << HakedisDizisi.UrunKodu << endl;
							yedekHakedis << HakedisDizisi.KullanilanAdet << endl;
							yedekHakedis << HakedisDizisi.Tutar;
							if (yedekHakedis.eof())
							{
								yedekHakedis << endl;
							}
						}
					}

					while (!dosyaMalzeme.eof())
					{
						getline(dosyaMalzeme, satir);
						MalDizisi.MalNo = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalAdi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.MalBirimi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.BirimFiyatı = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalMarka = satir;
						if (GirUrunKodu == MalDizisi.MalNo) {
							break;
						}
					}


					yedekHakedis.close();
					dosyaHakedis.close();
					remove("Hakedis.txt");
					rename("yedek3.txt", "Hakedis.txt");
					cout << "Hakedisten Baska Bir Urun Silmek İster Misiniz(e/h)...: " << endl;
					cin >> tekrar;

				} while (tekrar == "e");


				break;
				//Malzeme Güncelleme
				/*Malzeme güncellemede bütün bilgileri güncellemeyi yazmaya gerek duymadım.
				ekle ve sil fonksiyonlarıyla bu işlemler yaptırılabilir burada sadece kullanılan malzemenin
				kullanılan miktarını değiştirebiliyosunuz.
				Burada Sadece seçtiğiniz ürünün kullanılan miktarını güncelliyoruz. (projede yapılacak işlemle ilgili 
				açık bir bilgi verilmemiş)*/
			case 3:
				do
				{

					cout << "Proje Numarasi Giriniz...:" << endl;
					cin >> GirProjeNo;
					cout << "Hakedis Donemi Giriniz...:" << endl;
					cin >> HakedisDonem;
					cout << "Urun Kodunu Giriniz" << endl;
					cin >> GirUrunKodu;
					cout << "Guncel Adeti Giriniz" << endl;
					cin >> KullanilanAdet;

					while (!dosyaHakedis.eof())
					{
						getline(dosyaHakedis, satir);
						HakedisDizisi.ProjeNo = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.HakedisDonem = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.UrunKodu = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.KullanilanAdet = stoi(satir);
						getline(dosyaHakedis, satir);
						HakedisDizisi.Tutar = stoi(satir);


						while (!dosyaMalzeme.eof())
						{
							getline(dosyaMalzeme, satir);
							MalDizisi.MalNo = stoi(satir);

							getline(dosyaMalzeme, satir);
							MalDizisi.MalAdi = satir;

							getline(dosyaMalzeme, satir);
							MalDizisi.MalBirimi = satir;

							getline(dosyaMalzeme, satir);
							MalDizisi.BirimFiyatı = stoi(satir);

							getline(dosyaMalzeme, satir);
							MalDizisi.MalMarka = satir;
							if (GirUrunKodu == MalDizisi.MalNo) {
								break;
							}
						}

						if (GirProjeNo != HakedisDizisi.ProjeNo || HakedisDonem != HakedisDizisi.HakedisDonem || GirUrunKodu != HakedisDizisi.UrunKodu)
						{
							yedekHakedis << HakedisDizisi.ProjeNo << endl;
							yedekHakedis << HakedisDizisi.HakedisDonem << endl;
							yedekHakedis << HakedisDizisi.UrunKodu << endl;
							yedekHakedis << HakedisDizisi.KullanilanAdet << endl;
							yedekHakedis << HakedisDizisi.Tutar;
							if (yedekHakedis.eof())
							{
								yedekHakedis << endl;
							}
						}
						else
						{
							HakedisDizisi.Tutar = KullanilanAdet * MalDizisi.BirimFiyatı;
							yedekHakedis << HakedisDizisi.ProjeNo << endl;
							yedekHakedis << HakedisDizisi.HakedisDonem << endl;
							yedekHakedis << HakedisDizisi.UrunKodu << endl;
							yedekHakedis << KullanilanAdet << endl;
							yedekHakedis << HakedisDizisi.Tutar;
							if (!yedekHakedis.eof())
							{
								yedekHakedis << endl;
							}
						}
					}



					yedekHakedis.close();
					dosyaHakedis.close();
					remove("Hakedis.txt");
					rename("yedek3.txt", "Hakedis.txt");
					cout << "Hakedisten Baska Bir Urun Silmek İster Misiniz(e/h)...: " << endl;
					cin >> tekrar;

				} while (tekrar == "e");
				break;

				//Projede Kullanılan Urunleri Listele
			case 4:

				cout << "Proje Kodunu Giriniz...:";
				cin >> GirProjeNo;
				ToplamMaliyet = 0;
				cout << "ProjeNo" << setw(15) << "HakedisDonemi" << setw(15) << "UrunAdi" << setw(15) << "BirimFiyati" << setw(15) << "Tutar" << endl;
				while (!dosyaHakedis.eof()) {


					getline(dosyaHakedis, satir);
					HakedisDizisi.ProjeNo = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.HakedisDonem = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.UrunKodu = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.KullanilanAdet = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.Tutar = stoi(satir);

					fstream dosyaMalzeme("Malzemeler.txt", ios::in || ios::out || ios::app);

					while (!dosyaMalzeme.eof())
					{
						getline(dosyaMalzeme, satir);
						MalDizisi.MalNo = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalAdi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.MalBirimi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.BirimFiyatı = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalMarka = satir;
						if (HakedisDizisi.UrunKodu == MalDizisi.MalNo) {
							if (GirProjeNo == HakedisDizisi.ProjeNo)
							{
								ToplamMaliyet += HakedisDizisi.Tutar;
								cout << HakedisDizisi.ProjeNo << setw(15) << HakedisDizisi.HakedisDonem << setw(20) << MalDizisi.MalAdi << setw(15) << MalDizisi.BirimFiyatı << setw(15) << HakedisDizisi.Tutar << " Lira" << endl;
							}
							dosyaMalzeme.close();
							break;
						}



					}



				}
				cout << "TOPLAM MALIYET...:" << ToplamMaliyet << " Lira" << endl;


				break;
				//Malzeme Arama
				/*Burada çoklu dosya işlemlerini kullandım ürün proje kodlarını hakedişe entegre hale getirdim gereken 
				verileri numaraları sayesinde çekiyorum*/
			case 5:
				cout << "Malzemenin Kodunu Giriniz...:" << endl;
				cin >> GirUrunKodu;
				cout << "ProjeNo" << setw(15) << "HakedisDonemi" << setw(15) << "UrunAdi" << setw(15) << "BirimFiyati" << setw(15) << "Tutar" << endl;

				while (!dosyaHakedis.eof()) {


					getline(dosyaHakedis, satir);
					HakedisDizisi.ProjeNo = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.HakedisDonem = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.UrunKodu = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.KullanilanAdet = stoi(satir);
					getline(dosyaHakedis, satir);
					HakedisDizisi.Tutar = stoi(satir);

					fstream dosyaMalzeme("Malzemeler.txt", ios::in || ios::out || ios::app);

					while (!dosyaMalzeme.eof())
					{
						getline(dosyaMalzeme, satir);
						MalDizisi.MalNo = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalAdi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.MalBirimi = satir;

						getline(dosyaMalzeme, satir);
						MalDizisi.BirimFiyatı = stoi(satir);

						getline(dosyaMalzeme, satir);
						MalDizisi.MalMarka = satir;

						if (HakedisDizisi.UrunKodu == GirUrunKodu && GirUrunKodu == MalDizisi.MalNo) {

							cout << HakedisDizisi.ProjeNo << setw(15) << HakedisDizisi.HakedisDonem << setw(20) << MalDizisi.MalAdi << setw(15) << MalDizisi.BirimFiyatı << setw(15) << HakedisDizisi.Tutar << " Lira" << endl;
							dosyaMalzeme.close();
							break;
						}
					}
				}
				break;

			case 6:
				/*Burada işlemi biten projenin hakediş durumunu güncelleyip projenin silinme ihtimalini ortadan kaldırabiliyoruz*/
				int HakedisDurumu;
				cout << "Islem Yapmak Istediginiz Proje Numarasini Giriniz...:" << endl;
				cin >> GirProjeNo;
				cout << "1) Hakedis Verildi" << endl;
				cout << "2) Hakedis Verilmedi" << endl;
				cout << "Hakedisi Nasıl Guncellemek Istersiniz...:" << endl;
				cin >> HakedisDurumu;

				while (!dosyaProje.eof())
				{
					getline(dosyaProje, satir);
					ProjeDizisi.ProjeNo = stoi(satir);

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeAdi = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeFirma = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeSorumlusu = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.ProjeKontrolor = satir;

					getline(dosyaProje, satir);
					ProjeDizisi.Hakedis = satir;

					if (GirProjeNo != ProjeDizisi.ProjeNo)
					{
						yedekProje << ProjeDizisi.ProjeNo << endl;
						yedekProje << ProjeDizisi.ProjeAdi << endl;
						yedekProje << ProjeDizisi.ProjeFirma << endl;
						yedekProje << ProjeDizisi.ProjeSorumlusu << endl;
						yedekProje << ProjeDizisi.ProjeKontrolor << endl;
						yedekProje << ProjeDizisi.Hakedis;
						if (!dosyaProje.eof())
						{
							yedekProje << endl;
						}
					}
					else if (HakedisDurumu == 1) {
						yedekProje << ProjeDizisi.ProjeNo << endl;
						yedekProje << ProjeDizisi.ProjeAdi << endl;
						yedekProje << ProjeDizisi.ProjeFirma << endl;
						yedekProje << ProjeDizisi.ProjeSorumlusu << endl;
						yedekProje << ProjeDizisi.ProjeKontrolor << endl;
						yedekProje << "Verildi";
						if (!dosyaProje.eof())
						{
							yedekProje << endl;
						}
					}
					else if (HakedisDurumu == 2) {
						yedekProje << ProjeDizisi.ProjeNo << endl;
						yedekProje << ProjeDizisi.ProjeAdi << endl;
						yedekProje << ProjeDizisi.ProjeFirma << endl;
						yedekProje << ProjeDizisi.ProjeSorumlusu << endl;
						yedekProje << ProjeDizisi.ProjeKontrolor << endl;
						yedekProje << "Verilmedi";
						if (!dosyaProje.eof())
						{
							yedekProje << endl;
						}
					}
				}
				yedekProje.close();
				dosyaProje.close();
				remove("Projeler.txt");
				rename("yedek2.txt", "Projeler.txt");
				break;

			}
		}

		cout << "Ana Menuye Donmek Ister Misiniz (e/h)...:" << endl;
		cin >> tekrar;
	} while (tekrar=="e"|| tekrar =="E");
	
}


