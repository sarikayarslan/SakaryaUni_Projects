/****************************************************************************
**
**				ÖĞRENCİ ADI...........................:ARSLANCAN SaveDC
**				ÖĞRENCİ NUMARASI.............: B181210052
**				DERS GRUBU…………………: D
****************************************************************************/





#include <iostream>
#include <fstream>
#include <string>
#include <time.h>
#include <sstream> 
#include<Windows.h>
#include<iomanip>


using namespace std;
//Ekrana bastırırken ekranda gezinmeyi sağlar
void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;
	coord.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

class _ogrenci  {
protected:
	string isim;
	string soyisim;
	int numara;
};
class _dosyayonetimi :protected _ogrenci {
public:
	//Rastgele isim ataması yapar
	void randomname() {
		srand(time(0));
		ifstream isimler;
		isimler.open("isimler.txt", ios::in);
		int j = 1 + rand() % 4945;
		if (isimler.is_open() == true) {
			for (int i = 0; i < j; i++) {
				isimler >> isim;
			}
		}
	}
	//Rastgele soyisim ataması yapar
	void randomsurname() {
		srand(time(0));
		ifstream soyisimler;
		soyisimler.open("soyisimler.txt", ios::in);
		int n = 1 + rand() % 278;
		if (soyisimler.is_open() == true) {
			for (int i = 0; i < n; i++) {
				soyisimler >> soyisim;
			}
		}
	}

};
class _sinif :public _dosyayonetimi {
public:
	string sinifismi;
	int bireysayisi;
	string kayitsinif;
	string yenisinif;
	
	void sinifekle() {																				//TXT sonuna yeni bir sınıf ve bireysayisi ekler
		int sinifsayisi = 0;
		fstream sinifekle("kayitlar.txt");
			while(!sinifekle.eof()) {
				sinifsayisi++;
				sinifekle >> sinifismi;
				sinifekle >> bireysayisi;
				for (int i = 0; i < bireysayisi; i++) {
					sinifekle >> isim >> soyisim >> numara;
				}
			}
			sinifekle.close();
			fstream sinifekle2("kayitlar.txt", ios::app);
		srand(time(0));
		char s_harf='A'+ rand() % 26;
		string s_sayi;
		int y = sinifsayisi+1;
		s_sayi = to_string(y);
		string elemansayisi2 = "0";
		yenisinif =s_sayi+s_harf;
		sinifekle2 <<endl<< yenisinif<<endl;
		sinifekle2 << elemansayisi2;
		sinifekle2.close();
	}
	void sinifsil() {
		ifstream dosya("kayitlar.txt", ios::in || ios::out || ios::app);						/*SEçtiğimiz sınıf okunmaya başlandığında yedeğe yazdırırken atlar*/
		ofstream yedek("yedek.txt");
		if (yedek.is_open()) { // Dosyanın açılıp açılmadığını kontrol et.
			cout << "Dosya basari ile acildi." << endl;
		}
		else { // Dosya açılırken bir hata oluşursa.
			cout << "Hata: Dosya acilamadi!\n" << endl;
		}
		cout << "Sinif Gir  :";
		string silsinif;
		cin >> silsinif;
		
		dosya >> sinifismi;
		dosya >> bireysayisi;
		if (silsinif != sinifismi) {
			yedek << sinifismi << endl;
			yedek << bireysayisi;
		}
		for (int i = 1; i <= bireysayisi; i++) {
			dosya >> isim >> soyisim >> numara;

			if (silsinif != sinifismi) {
				yedek<< endl << isim << " " << soyisim << " " << numara;
			}
		}
		
		while (!dosya.eof()) {
			dosya >> sinifismi;
			dosya >> bireysayisi;
			if (sinifismi != silsinif) {
				yedek<< endl << sinifismi;
				yedek << endl << bireysayisi;
			}
			for (int i = 1; i <= bireysayisi; i++) {
				dosya >> isim >> soyisim >> numara;
				if (silsinif != sinifismi) {
					yedek << endl << isim << " " << soyisim << " " << numara;
				}
			}
		}

		yedek.close();
		dosya.close();
		remove("kayitlar.txt");
		rename("yedek.txt", "kayitlar.txt");

	}
	void ogrenciekle(_ogrenci ogr) {																/*Eklenilmek istenen sinifi ister daha sonra o sınıfı yazdırırken bireysayisini
																									1 arttırır ve yedeğe yazar*/
		ofstream yedek("yedek.txt");
		fstream dosya("kayitlar.txt", ios::in || ios::out || ios::app);
		cout << "Sinif Gir  :";
		cin >> kayitsinif;
		while (!dosya.eof()) {
			dosya >> sinifismi;
			dosya >> bireysayisi;
			if (kayitsinif == sinifismi) {
				bireysayisi++;
			}
			
				yedek << sinifismi << endl;
				yedek << bireysayisi;
			for (int i = 1; i <= bireysayisi; i++)
			{
				if (!(kayitsinif == sinifismi) || bireysayisi != i) {
					dosya >> isim >> soyisim >> numara;
					yedek <<endl<< isim << " " << soyisim << " " << numara;
				}
				else if (kayitsinif == sinifismi && bireysayisi == i) {
					randomname();
					randomsurname();
					numara = 100 + rand() % 100;
					cout << "Isim  :" << isim << endl;
					cout << "Soyisim  :" << soyisim << endl;
					cout << "Numara  :" << numara << endl;
					system("pause");
					yedek << endl << isim << " " << soyisim << " " << numara;
					kayitsinif = "00";
				}
			}
			if (!dosya.eof()) {
				yedek << endl;
		}
}
		yedek.close();
		dosya.close();
		remove("kayitlar.txt");
		rename("yedek.txt", "kayitlar.txt");
	}
	/*randomname ve randomsurname fonksiyonları sayesinde rastgele isim ve soyisim
	belirler daha sonra değiştirmek istediğimiz öğrencinin isim ve soyismine atar*/
	void ogrencidegistir(_ogrenci ogr) {																
		int degisnumara;
		ofstream yedek("yedek.txt");
		fstream dosya("kayitlar.txt", ios::in || ios::out || ios::app);
		if (dosya.is_open()) { // Dosyanın açılıp açılmadığını kontrol et.
			cout << "Dosya basari ile acildi." << endl;
		}
		else { // Dosya açılırken bir hata oluşursa.
			cout << "Hata: Dosya acilamadi!\n" << endl;
		}
		cout << "Numara Gir  :";
		cin >> degisnumara;
		while (!dosya.eof()) {
			dosya >> sinifismi;
			dosya >> bireysayisi;
			yedek << sinifismi << endl;
			yedek << bireysayisi;
			for (int i = 1; i <= bireysayisi; i++)
			{
				dosya >> isim >> soyisim >> numara;
				if (!(degisnumara == numara)) {

					yedek << endl << isim << " " << soyisim << " " << numara;
				}
				else if (degisnumara == numara) {
					randomname();
					randomsurname();
					numara = 100 + rand() % 100;
					yedek << endl << isim << " " << soyisim << " " << numara;
				}
			}
			if (!dosya.eof()) {
			yedek << endl;
		}
			}

		yedek.close();
		dosya.close();
		remove("kayitlar.txt");
		rename("yedek.txt", "kayitlar.txt");
	}

	void ogrencisil(_ogrenci ogr) {																		/*İlk önce numarası verilen öğrenciyi yedek.tmp ye yazdırırken
																										değiştirilmek istenen öğrenciyi atlayarak yazar daha sonra dosya düzeninin
																										bozulmaması için bireysayisini yeniden düzenleyerek kayitlar.txt ye tekrar
																										yazdırır*/
		int degisenbireysayisi=0;
		int degerazalt = 0;
		string degisensinif;
		int silnumara;
		ofstream yedek("yedek.txt");
		fstream dosya("kayitlar.txt"/*, ios::in || ios::out || ios::app*/);
		if (yedek.is_open()) { // Dosyanın açılıp açılmadığını kontrol et.
			cout << "Dosya basari ile acildi." << endl;
		}
		else { // Dosya açılırken bir hata oluşursa.
			cout << "Hata: Dosya acilamadi!\n" << endl;
		}
		cout << "Numara Gir  :";
		cin >> silnumara;
		while (!dosya.eof()) {
			_ogrenci ogr;
			dosya >> sinifismi;
			dosya >> bireysayisi;
			yedek << sinifismi<<endl;
			yedek << bireysayisi;
			for (int i = 1; i <= bireysayisi; i++) {
				dosya >> isim >> soyisim >> numara;
				if(silnumara==numara){
					degerazalt++;
					degisenbireysayisi = bireysayisi;
					degisensinif = sinifismi;
				}
				else {
					yedek <<endl<< isim << " " << soyisim << " " <<numara;
				}
			}
			if (!dosya.eof()) {
				yedek << endl;
			}
		}		
		dosya.close();
		yedek.close();
		ifstream dosya2("yedek.txt");
		ofstream yedek2("kayitlar.txt");
		if (yedek2.is_open()) { // Dosyanın açılıp açılmadığını kontrol et.
			cout << "Dosya basari ile acildi." << endl;
		}
		else { // Dosya açılırken bir hata oluşursa.
			cout << "Hata: Dosya acilamadi!\n" << endl;
		}
		while (!dosya2.eof()) {
			dosya2 >> sinifismi;
			dosya2 >> bireysayisi;
			if (bireysayisi == degisenbireysayisi && sinifismi == degisensinif) {
				bireysayisi = degisenbireysayisi - degerazalt;
			}
			yedek2 << sinifismi << endl;
			yedek2 << bireysayisi;
			for (int i = 1; i <= bireysayisi; i++) {

				dosya2 >> isim >> soyisim >> numara;
				yedek2 <<endl<< isim <<" "<< soyisim <<" "<< numara;
			}
			if (!dosya2.eof()) {
				yedek2 << endl;
			}

		}
		yedek2.close();
		dosya2.close();
		remove("yedek.txt");
	}
};
class _okul : public _sinif {
public:
	char solUstKose = 201;
	char duz = 205;
	char sagUstKose = 187;
	char solAltKose = 200;
	char sagAltKose = 188;
	char dikey = 186;
	void ustYazdir(int elemanSayisi)
	{

		cout << solUstKose;
		for (int i = 0; i < elemanSayisi; i++)
		{
			cout << duz;
		}
		cout << sagUstKose;
	};

	void altYazdir(int elemanSayisi)
	{
		cout << solAltKose;
		for (int i = 0; i < elemanSayisi; i++)
		{
			cout << duz;
		}
		cout << sagAltKose;
	}
	int sinifx = 0;
	int sinify = 0;
	void ekranabastir() {   //ekrana bastırır
		ifstream ekranabas("kayitlar.txt");
		int x = 0;
		int ogrencix =0;
		while (!ekranabas.eof()) {
		
		int y = 0;

			ekranabas >> sinifismi;
			ekranabas >> bireysayisi;
			gotoxy(x, y);
			y++;
			ustYazdir(14); cout << endl;
			gotoxy(x, y);
			y++;
			cout << dikey << setw(7) << sinifismi << setw(8) << dikey;
			
			gotoxy(x, y);
			altYazdir(14); cout << endl;
			x += 16;
			int ogrenciy = 4;
			for (int i = 1; i <= bireysayisi; i++) {
			ekranabas >> isim;
			ekranabas >> soyisim;
			ekranabas >> numara;
			gotoxy(ogrencix, ogrenciy); ogrenciy++;
			cout << setw(3); ustYazdir(10); cout << endl;
			 gotoxy(ogrencix, ogrenciy); ogrenciy++;
			cout << setw(3) << dikey << setw(10) << isim << dikey<<setw(3) << endl;
			gotoxy(ogrencix, ogrenciy); ogrenciy++;
			cout << setw(3) << dikey << setw(10) << soyisim << dikey<<setw(3)<< endl;
			gotoxy(ogrencix, ogrenciy); ogrenciy++;
			cout << setw(3) << dikey << setw(10) << numara << dikey <<setw(3) <<endl;
			gotoxy(ogrencix, ogrenciy); ogrenciy++;
			cout << setw(3); altYazdir(10);
			}
			ogrencix += 16;
			}
	}
};

class _program :public _okul {
public:
	void menubastir() { //Menü bastırır
		gotoxy(0, 25);
		cout << "1.Ogrenci Ekle";
		gotoxy(0, 26);
		cout << "2.Sinif Ekle";
		gotoxy(0, 27);
		cout << "3.Ogrenci Degistir";
		gotoxy(0, 28);
		cout << "4.Ogrenci Sil";
		gotoxy(0, 29);
		cout << "5.Sinif Sil";
		gotoxy(0, 30);
		cout << "6.Cikis";
		gotoxy(0, 31);
		cout << "Islemi Seciniz  :";
		_ogrenci ogr;
		int secim;
		cin >> secim;
		switch (secim) {
		case 1:
			ogrenciekle(ogr);
			break;
		case 2:
			sinifekle();
			break;
		case 3:
			ogrencidegistir(ogr);
			break;
		case 4:
			ogrencisil(ogr);
			break;
		case 5:
			sinifsil();
			break;
		case 6:
			exit(0);
			break;
		}
	}
	void calistir() {
		_ogrenci ogr;
		while(true) {
			ekranabastir();
			menubastir();
			system("cls");
			
		};
		}
};
int main()
{
	_program prog;
	prog.calistir();
	cin.get();
	return 0;
}
