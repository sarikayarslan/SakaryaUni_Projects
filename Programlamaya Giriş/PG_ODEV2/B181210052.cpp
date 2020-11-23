
/****************************************************************************
**
**				ÖĞRENCİ ADI.....................: ARSLANCAN SARIKAYA	
**				ÖĞRENCİ NUMARASI.............: B181210052	
**				DERS GRUBU…………………:D GRUBU
****************************************************************************/
#include <iostream>
#include<stdlib.h>
#include <time.h>
#include<iomanip>
#include<conio.h>
using namespace std;
int main()
{
	//Matris Boyutunun Şartlara Uygunluğunu Denetler.
	srand(time(0));
	int boyut;
	
	cout << "Matrisin Boyutunu Giriniz:  ";
	cin >> boyut;
	cout << endl;
	while (5 > boyut || 25 < boyut) {
		cout << "Matris Boyutu 25'ten Kucuk 5'ten Buyuk Olmalidir." << endl;
		cout << "Matrisin Boyutunu Tekrar Giriniz:  ";
		cin >> boyut;
		cout << endl;
	}
	//Matrise Rastgele Sayılar Atar.
	int matris[25][25];
	for (int satir = 0; satir < boyut; satir++) {
		for (int sutun = 0; sutun < boyut; sutun++) {
			matris[satir][sutun] = 1 + rand() % 9;
		}
	}
	//Matrisi Ekrana Bastırır.
	int sutun = 0;
	int satir = 0;
	int secsatir = 0;
	do {
		sutun = 0;
		satir = 0;
		secsatir = 0;
		cout << "   ";
		for (sutun = 0; sutun < boyut; sutun++)
		{
			cout << setw(5);
			cout << sutun + 1;
		}
		cout << endl;
		cout << "   ";
		for (sutun = 0; sutun < boyut; sutun++)
		{
			cout << "_____";
		}
		cout << endl;
		for (satir = 0; satir < boyut; satir++) {
			if (satir < 9) {
				cout << satir + 1;
				cout << " |";
			}
			else {
				cout << satir + 1;
				cout << "|";
			}
			for (sutun = 0; sutun < boyut; sutun++)
			{
				cout << setw(5);
				cout << matris[satir][sutun];
			}
			cout << endl;
		}
		//Yapılabilecek İşlemleri Bastırır.
		cout << "1. Sutun Satir Degistir: " << endl;
		cout << "2. Tekleri Basa Al(SAtir)" << endl;
		cout << "3. Ters Cevir(Sutun)" << endl;
		cout << "4. Toplamlari Yazdir" << endl;
		cout << "Bir Islem Seciniz[1-4]:  ";
		int islem;
		//Case içindeki Değişkenleri Tanımlar.
		int tersdondurme = boyut - 1;
		int transfer0 = 0;
		int ciftmatris[25];
		int tekmatris[25];
		int teksatir[25];
		int ciftsatir[25];
		int tsatirnumara = 0;
		int csatirnumara = 0;
		//Seçilen İşleme Göre İşlemi Gerçekleştirir.
		cin >> islem;
		switch (islem) {
		case 1://Seçilen Satır ve Sütunun Yerini Değiştirir.
			
			cout << "Degisecek Satir ve Sutun Numarasini Giriniz:  ";
			cin >> satir >> sutun;
			//Değişecek Satir ve Sutunu Yeni Satir ve Sutun matrislerine Yedekler.
			if (satir <= boyut & sutun <= boyut) {
				int yedeksatir[25];
				int yedeksutun[25];
				for (int yedekleme = 0; yedekleme < boyut; yedekleme++) {
					yedeksutun[yedekleme] = matris[yedekleme][sutun - 1];
					yedeksatir[yedekleme] = matris[satir - 1][yedekleme];
				}
				//Satır ve Sütun Elemanları Yer Değiştirir.
				for (int transfer1 = 0; transfer1 < boyut; transfer1++) {
					matris[satir - 1][transfer1] = matris[transfer1][sutun - 1];
					matris[transfer0][sutun - 1] = yedeksatir[transfer0];
					transfer0++;
				}
				matris[satir - 1][satir - 1] = yedeksutun[satir - 1];
				matris[satir - 1][sutun - 1] = yedeksatir[satir - 1] + yedeksutun[sutun - 1];
				//Matrisi Ekrana Basar.
				cout << "   ";
				for (sutun = 0; sutun < boyut; sutun++)
				{
					cout << setw(5);
					cout << sutun + 1;
				}
				cout << endl;
				cout << "   ";
				for (sutun = 0; sutun < boyut; sutun++)
				{
					cout << "_____";
				}
				cout << endl;
				for (satir = 0; satir < boyut; satir++) {
					if (satir < 9) {
						cout << satir + 1;
						cout << " |";
					}
					else {
						cout << satir + 1;
						cout << "|";
					}
					for (sutun = 0; sutun < boyut; sutun++)
					{
						cout << setw(5);
						cout << matris[satir][sutun];
					}
					cout << endl;
				}
			}
			else {
				cout << "Satir ve Sutun Boyuttan Buyuk Olamaz." << endl;
				cout << "Press any key to continue";
				_getch();
				cout << endl;
			}
			break;
		case 2://Seçilen Satırdaki Tek Sayıları Öne Alıp Yeni Bir Satır Oluşturur.
			cout << "Satir Sayisini Giriniz: ";
			cin >> secsatir;
			secsatir -= 1;
			//Satır Sayısının Uygunluğunu Denetler.
			if (secsatir <= boyut) {
				//Tek sayiları ayrı,Çift Sayıları Ayrı Matrise Atar.
				for (int y = 0; y < boyut; y++) {
					if (matris[secsatir][y] % 2 == 1) {
						teksatir[tsatirnumara] = matris[secsatir][y];
						tsatirnumara++;
					}
					else {
						ciftsatir[csatirnumara] = matris[secsatir][y];
						csatirnumara++;
					}
				}
					//Oluşturulan Yeni Matrislerdeki Elemanlarla Seçilen Satırı Yeniden Oluşturur.
						for (int sutun5 = 0; sutun5 < tsatirnumara; sutun5++) {
							matris[secsatir][sutun5] = teksatir[sutun5];
						}
						for (int sutun55 = 0; sutun55 < csatirnumara; sutun55++) {
							matris[secsatir][tsatirnumara] = ciftsatir[sutun55];
							tsatirnumara++;
						}
					//Matrisi Ekrana Basar.
				cout << "   ";
				for (sutun = 0; sutun < boyut; sutun++)
				{
					cout << setw(5);
					cout << sutun + 1;
				}
				cout << endl;
				cout << "   ";
				for (sutun = 0; sutun < boyut; sutun++)
				{
					cout << "_____";
				}
				cout << endl;
				for (satir = 0; satir < boyut; satir++) {
					if (satir < 9) {
						cout << satir + 1;
						cout << " |";
					}
					else {
						cout << satir + 1;
						cout << "|";
					}
					for (sutun = 0; sutun < boyut; sutun++)
					{
						cout << setw(5);
						cout << matris[satir][sutun];
					}
					cout << endl;
				}
			}
				
			else {
				cout << "Satir Degeri Boyuttan Buyuk Olamaz." << endl;
				cout << "Press any key to continue";
				_getch();
				cout << endl;
			}
					break;
		case 3://Seçilen Sütunun Yönünü Değiştirir.
			cout << "Sutun Degerini Giriniz:  ";
			cin >> sutun;
			//Sütun Değerinin Uygunluğunu Kontrol Eder.
			if (sutun <= boyut) {
				//Sütunun Yönünü Değiştirir.
				for (int sutundegisim = 0; sutundegisim < boyut / 2; sutundegisim++) {
					swap(matris[sutundegisim][sutun - 1], matris[tersdondurme][sutun - 1]);
					tersdondurme--;
				}
				//Matrisi Ekrana Basar.
				cout << "   ";
				for (sutun = 0; sutun < boyut; sutun++)
				{
					cout << setw(5);
					cout << sutun + 1;
				}
				cout << endl;
				cout << "   ";
				
				for (sutun = 0; sutun < boyut; sutun++)
				{
					cout << "_____";
				}
				cout << endl;
				for (satir = 0; satir < boyut; satir++) {
					if (satir < 9) {
						cout << satir + 1;
						cout << " |";
					}
					else {
						cout << satir + 1;
						cout << "|";
					}
					for (sutun = 0; sutun < boyut; sutun++)
					{
						cout << setw(5);
						cout << matris[satir][sutun];
					}
					cout << endl;
				}
			}
			else {
				cout << "Sutun Degeri Boyuttan Buyuk Olamaz." << endl;
				cout << "Press any key to continue";
				_getch();
				cout << endl;
			}
			break;
		case 4://Toplamdan 0'a Kadar Matris Oluşturur ve Basar.
			
			int toplam = 0;
			for (int satır7 = 0; satır7 < boyut; satır7++) {
				for (int sutun7 = 0; sutun7 < boyut; sutun7++)
				{
					toplam += matris[satır7][sutun7];
				}
			}
			int yedekmatris[25][25];
			for (int satir8 = 0; satir8 < boyut; satir8++) {
				for (int sutun8 = 0; sutun8 < boyut; sutun8++)
				{
					yedekmatris[satir8][sutun8] = matris[satir8][sutun8];
				}
			}
			for (int satir9 = 0; satir9 < boyut; satir9++) {
				for (int sutun9 = 0; sutun9 < boyut; sutun9++)
				{
					matris[satir9][sutun9] = toplam - yedekmatris[satir9][sutun9];
					toplam -= yedekmatris[satir9][sutun9];
				}
			}
			//Matrisi Ekrana Basar.
			cout << "   ";
			for (sutun = 0; sutun < boyut; sutun++)
			{
				cout << setw(5);
				cout << sutun + 1;
			}
			cout << endl;
			cout << "   ";
			for (sutun = 0; sutun < boyut; sutun++)
			{
				cout << "_____";
			}
			cout << endl;
			for (satir = 0; satir < boyut; satir++) {
				if (satir < 9) {
					cout << satir + 1;
					cout << " |";
				}
				else {
					cout << satir + 1;
					cout << "|";
				}
				for (sutun = 0; sutun < boyut; sutun++)
				{
					cout << setw(5);
					cout << matris[satir][sutun];
				}
				cout << endl;
				}
				break;
				}
			}while (satir > boyut || sutun > boyut||secsatir>boyut);
return 0;
}

