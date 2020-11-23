#include <conio.h>
#include <stdio.h>
#include <iostream>
#include <math.h>
#include <ctime>
#include <stdlib.h>
using namespace std;
// 2 Nokta Arasındaki Uzakligi Hesaplayan Fonksiyon
int UzaklikHesapla(int ilkx,int ilky, int ikincix,int ikinciy) {
	int uzaklik = 0;
	uzaklik = sqrt(pow((ilkx - ikincix), 2) + pow((ilky - ikinciy), 2));
	return uzaklik;
}
class Nokta {
private:
	int xdegeri;
	int ydegeri;

public:
	void setxdegeri(int xdeger) {	xdegeri = xdeger;}
	
	int getxdegeri() {return xdegeri;}
	
	void setydegeri(int ydeger) {ydegeri = ydeger;}
	
	int getydegeri() {return ydegeri;}
	//Parametresiz kurucu fonksiyon x ve y'ye rastgele değer atar.
	Nokta() {
		xdegeri = (rand() % 300 + 1) - 200;
		ydegeri = (rand() % 300 + 1) - 200;
	}

	//Parametreli kurucu fonksiyonu x ve y koordinatları için değer alır. 
	Nokta(int xrandom, int yrandom) {
		xdegeri = xrandom;
		ydegeri = yrandom;
	}
	void RandomNoktaUzaklik() {
		// Rastgele Seçilen bir Noktaya Olan Uzaklık


		int rastgelesecilenx = (rand() % 200 + 1) - 100;
		int rastgelesecileny = (rand() % 200 + 1) - 100;
		cout << "Rastgele Nokta : " << rastgelesecilenx << "," << rastgelesecileny << endl;
		cout << "1. Noktanin Rastgele Noktaya Uzakligi: " << UzaklikHesapla(xdegeri, ydegeri, rastgelesecilenx, rastgelesecileny) << endl;
	}

	void OrijinUzaklik() {

		//Orijine uzaklığı hesaplar.
		cout << " Orijine Olan Uzaklik: " << UzaklikHesapla(xdegeri, ydegeri, 0, 0) <<  endl;

	}
	
	void NoktaNerede() {
		//Orijinde mi değil mi onu hesaplar.
		if (xdegeri == 0 && ydegeri == 0) {
			cout << " Secilen Nokta Orijin Uzerindedir" << endl;
		}
		else {
			cout << "Secilen Nokta Orijin Uzerinde Degildir" << endl;
		}
	}
};

int main()
{


	int secilenmod;
	
	while (true) {
		//Mod seçmemizi sağlar.
		cout << "Test Modu icin 0 Calisma Modu Icin 1'i Tuslayin";
		cin >> secilenmod;

		if (secilenmod == 0) {
			//2 Noktayı oluşturur.
			Nokta BirinciNokta = Nokta();
			Nokta İkinciNokta = Nokta();
			//Zamani sifirlar bu sayede rastgele sayilar hep farkli gelir.
			srand(time(NULL));

			cout << "Nokta 1: " << BirinciNokta.getxdegeri() << "," << BirinciNokta.getydegeri() << endl;
			cout << "Nokta 2: " << İkinciNokta.getxdegeri() << "," << İkinciNokta.getydegeri() << endl;

			BirinciNokta.RandomNoktaUzaklik();
			BirinciNokta.NoktaNerede();
			BirinciNokta.OrijinUzaklik();
		}
		else if (secilenmod == 1) {
			int secilenx;
			int secileny;
			//Parametreli kurucu fonksiyonun aldigi rastgele degerleri olusturur.
			Nokta SecilenBirinciNokta = Nokta(NULL, NULL);
			Nokta SecilenİkinciNokta = Nokta(NULL, NULL);

			while (true) {

				cout << "Program Birinci ve Ikinci Noktalari Dogru Girene Kadar Size Nokta Sormaya Devam Edecektir" << endl;

				if (SecilenBirinciNokta.getxdegeri() == NULL || SecilenBirinciNokta.getydegeri() == NULL) {
					cout << "Secmek İstediginiz 1. Noktanin X degerini Giriniz :";
					cin >> secilenx;
					cout << "Secmek İstediginiz 1. Noktanin Y degerini Giriniz: ";
					cin >> secileny;
					SecilenBirinciNokta = Nokta(secilenx, secileny);
				}
				else if (SecilenİkinciNokta.getxdegeri() == NULL && SecilenİkinciNokta.getydegeri() == NULL) {
					cout << "Secmek İstediginiz 2. Noktanin X degerini Giriniz: ";
					cin >> secilenx;
					cout << "Secmek İstediginiz 2. Noktanin Y degerini Giriniz: ";
					cin >> secileny;
					SecilenİkinciNokta = Nokta(secilenx, secileny);
				}
				else { break; }
			}
			// Burada 100 tane noktanın her birinin hem 1. hemde 2. noktaya uzaklıklarını toplayıp bu 2 doğruya en yakın noktaları buluyoruz /

			Nokta Grid[100];
			for (int i = 0; i < 100; i++)
			{
				Grid[i] = Nokta();
			}
			int ToplamUzaklik[100];
			int birincienyakin = 0;
			int ikincienyakin = 0;
			int ucuncuyakin = 0;
			int dorduncuenyakin = 0;
			for (int sayac1 = 0; sayac1 < 100; sayac1++)
			{
				// 1. ve 2. noktaya olan uzaklıklar hesaplanıp toplanır.
				int BirinciNoktayaUzaklik = UzaklikHesapla(SecilenBirinciNokta.getxdegeri(), SecilenBirinciNokta.getydegeri(), Grid[sayac1].getxdegeri(), Grid[sayac1].getydegeri());
				int İkinciNoktayaUzaklik = UzaklikHesapla(SecilenİkinciNokta.getxdegeri(), SecilenİkinciNokta.getydegeri(), Grid[sayac1].getxdegeri(), Grid[sayac1].getydegeri());
				ToplamUzaklik[sayac1] = BirinciNoktayaUzaklik + İkinciNoktayaUzaklik;
			}

			//Noktalara en yakin 6 nokta tespit edilir.
			for (int sayac2 = 0; sayac2 < 99; sayac2++)
			{
				if (ToplamUzaklik[sayac2] < ToplamUzaklik[sayac2 + 1])
				{
					dorduncuenyakin = ucuncuyakin;
					ucuncuyakin = ikincienyakin;
					ikincienyakin = birincienyakin;
					birincienyakin = sayac2;
				}
			}
			//En yakın 4 nokta ekrana bastırılır.
			cout << "Secilen 2 noktaya en yakin 4 nokta: " << endl;
			cout << Grid[birincienyakin].getxdegeri() << "," << Grid[birincienyakin].getydegeri() << endl;
			cout << Grid[ikincienyakin].getxdegeri() << "," << Grid[ikincienyakin].getydegeri() << endl;
			cout << Grid[ucuncuyakin].getxdegeri() << "," << Grid[ucuncuyakin].getydegeri() << endl << Grid[dorduncuenyakin].getxdegeri() << "," << Grid[dorduncuenyakin].getydegeri() << endl;
			int EnYakinNoktaUzaklik = UzaklikHesapla(SecilenBirinciNokta.getxdegeri(), SecilenBirinciNokta.getydegeri(), Grid[birincienyakin].getxdegeri(), Grid[birincienyakin].getydegeri());
			cout << "2 Nokta Arasi En Kisa Yol Uzunlugu " << EnYakinNoktaUzaklik;
		
		}
		
	}
	
}