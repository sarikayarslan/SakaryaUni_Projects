#include <iostream>
#include<Windows.h>
using namespace std;
/****************************************************************************
**                                                                         **
**				ÖĞRENCİ ADI ...: ARSLANCAN SARIKAYA                        **
**				ÖĞRENCİ NUMARASI...: B181210052                            **
**				DERS GRUBU...: INTRODUCTION TO PROGRAMMING (D GRUBU)       **
****************************************************************************/

int main() {
	int satir, sutun;
	cout << "Satir Sayisini Giriniz: "; //Kullanıcıya gireceği değerle ilgili bilgi verir.
	cin >> satir;                // Kullanıcıdan satır sayısını alır.
	while (satir < 5 || 15 < satir) {                                      //Girilen değerin uygunluğunu kontrol eder.  
		cout << "Satir Sayisi Hatali... Lutfen Tekrar Giriniz..." << endl; //Uygun değilse içerideki işlemi uygular ve farklı bir değer ister.
		cout << "Satir Sayisini Giriniz: ";
		cin >> satir;
	}
	cout << endl;
	cout << "Sutun Sayisini Giriniz: ";    //Kullanıcıya gireceği değerle ilgili bilgi verir.
	cin >> sutun;						   // Kullanıcıdan satır sayısını alır.
	while (sutun < 5 || 40 < sutun) {										//Girilen değerin uygunluğunu kontrol eder.
		cout << "Sutun Sayisi Hatali... Lutfen Tekrar Giriniz..." << endl;  //Uygun Değilse içerideki işlemi uygular ve farklı bir değer ister.
		cout << "Sutun Sayisini Giriniz: ";
		cin >> sutun;
	}
	cout << endl;
	//Satır ve sütun arasındaki ilişkinin doğruluğunu kontrol eder. Uygun değilse içerideki işlemleri uygular ve farklı bir değer ister.
	while (2 * satir != sutun) {
		cout << "Sutun Sayisi Satir Sayisinin 2 Kati Olmalidir..." << endl;
		cout << "Satir Sayisini Giriniz: ";
		cin >> satir;
		//Girilen değerin uygunluğunu kontrol eder. 
		//Uygun Değilse içerideki işlemi uygular ve farklı bir değer ister.
		while (satir < 5 || 15 < satir) {
			cout << "Satir Sayisi Hatali...  5-15 Araliginda Bir Tam Sayi Giriniz..." << endl;
			cout << "Satir Sayisini Giriniz: ";
			cin >> satir;
		}
		cout << endl;
		cout << "Sutun Sayisini Giriniz: ";
		cin >> sutun;
		//Girilen değerin uygunluğunu kontrol eder.
		//Uygun Değilse içerideki işlemi uygular ve farklı bir değer ister.
		while (sutun < 5 || 40 < sutun) {
			cout << "Sutun Sayisi Hatali... 5-40 Araliginda Bir Tam Sayi Giriniz..." << endl;
			cout << "Sutun Sayisini Giriniz: ";
			cin >> sutun;
		}
		cout << endl;
	}
	for (int ustcizgi1 = 1; ustcizgi1 <= sutun; ustcizgi1++) {   //1. şeklin üstündeki çizgiyi bastırır.

		cout << "*";
	}
	cout << endl;
	for (int dikeyalan1 = 1; dikeyalan1 <= satir - 2; dikeyalan1++) { //2 çizgi arasındaki satir sayisini belirler.
		Sleep(100);
		cout << "*";// 1.şeklin solundaki dikey çizgisi bastırır.
		for (int solucgen1 = dikeyalan1; solucgen1 < satir - 2; solucgen1++) {//1. şeklin solundaki boşluğu bastırır.

			cout << " ";
		}
		cout << "*";    //1. ve 2. boşluk arasındaki çizgiyi bastırır.
		for (int ortaucgen1 = 1; ortaucgen1 <= dikeyalan1; ortaucgen1++) { //1. şeklin ortasındaki boşluğu bastırır.
			cout << "  ";
		}
		cout << "*";    //2. ve 3. boşluk arasındaki çizgiyi bastırır.
		for (int sagucgen1 = dikeyalan1; sagucgen1 < satir - 2; sagucgen1++) {    //1.şeklin sağındaki boşluğu bastırır.
			cout << " ";

		}
		cout << "*";    //2. şeklin en sağındaki dikey çizgiyi bastırır.
		cout << endl;
	}

	for (int altcizgi = 1; altcizgi <= sutun; altcizgi++) { //1. şeklin en altındaki çizgiyi bastırır.
		cout << "*";
	}
	cout << endl;
	cout << endl;
	//  Bu Satırdan Sonrası 2. Şekli Kapsar...
	for (int ustcizgi2 = 1; ustcizgi2 <= sutun; ustcizgi2++) { //2. şeklin üstündeki çizgiyi bastırır.
		cout << "*";
	}
	cout << endl;
	for (int dikeyalan2 = 1; dikeyalan2 <= satir - 2; dikeyalan2++) //2 çizgi arasındaki satir sayisini belirler.
	{
		Sleep(100);
		cout << "*";  // 2.şeklin solundaki dikey çizgisi bastırır.
		for (int solucgen2 = 2; solucgen2 <= dikeyalan2; solucgen2++) //2. şeklin solundaki boşluğu bastırır.
		{
			cout << " ";
		}
		cout << "*";    //1. ve 2. boşluk arasındaki çizgiyi bastırır.
		for (int ortaucgen2 = dikeyalan2; ortaucgen2 < satir - 1; ortaucgen2++) { //2. şeklin ortasındaki boşluğu bastırır.
			cout << "  ";
		}
		cout << "*"; //2. ve 3. boşluk arasındaki çizgiyi bastırır.
		for (int solucgen2 = 2; solucgen2 <= dikeyalan2; solucgen2++) {   //2.şeklin sağındaki boşluğu bastırır.
			cout << " ";
		}
		cout << "*";  //2. şeklin en sağındaki dikey çizgiyi bastırır.

		cout << endl;
	}
	for (int altcizgi2 = 1; altcizgi2 <= sutun; altcizgi2++) { //2. şeklin en altındaki çizgiyi bastırır.
		cout << "*";
	}
	return 0;
}
