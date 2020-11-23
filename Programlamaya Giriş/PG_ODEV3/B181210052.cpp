/****************************************************************************
**
**				ÖĞRENCİ ADI..................:ARSLANCAN SARIKAYA	
**				ÖĞRENCİ NUMARASI........:B181210052
**				DERS GRUBU……………:D GRUBU
****************************************************************************/

#include <iostream>
#include<Windows.h>
#include <time.h>

using namespace std;

void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;
	coord.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

//Sahne için bir yapı oluşturur. 

struct Sahne {
	int yukseklik;
	int genislik;
	int matrissecim;	
};
//sahne içindeki elemanlara değer atar.
Sahne sahneolustur() {
	srand(time(0));
	Sahne sahne;
	sahne.matrissecim = rand() % 5;
	sahne.yukseklik = 20+rand()%11;
	sahne.genislik = 10 * (3 + rand() % 3);
	return sahne;
}
//Sahneyi ekrana bastırır.
void SahneCiz(Sahne sahne) {
	char sahneeleman[5] = { '*','#','$','+','@' };
	//Üst Yatay Genişliği Bastırır.
	for (int i = 0; i < sahne.genislik; i++) {
		cout << sahneeleman[sahne.matrissecim];
	}
	//Sağ Yüksekliği Bastırır.
	for (int i = 0; i < sahne.yukseklik; i++)
	{
		gotoxy(sahne.genislik - 1, i);
		cout << sahneeleman[sahne.matrissecim];
	}
	//Alt Yatay Genisliği bastırır.
	for (int i = 0; i < sahne.genislik; i++)
	{
		gotoxy(sahne.genislik - 1 - i, sahne.yukseklik - 1);
		cout << sahneeleman[sahne.matrissecim];
	}
	//Sol Yüksekliği Bastirir.
	for (int i = 0; i < sahne.yukseklik; i++)
	{
		gotoxy(0, sahne.yukseklik - 1 - i);
		cout << sahneeleman[sahne.matrissecim];
	}
	
}
// Lsekli için bir yapı oluşturur
struct LSekli {
	int x;
	int y;
	int boyut;
	int ldegisken;
};
//sekil içindeki elemanlara değer atar
LSekli lSekliOlustur() {
	srand(time(0));
	LSekli sekil;
	sekil.x = 6 + rand() % 20;
	sekil.y = 3;
	sekil.boyut = 2 + rand() % 6;
	sekil.ldegisken = rand() % 5;
	return sekil;
}
//Lseklinin ekrana bastırır
void lSekliCiz(LSekli sekil) {
	char sekileleman[5] = { '*','#','$','+','@' };
	for (int i = 0; i < sekil.boyut; i++) {
		gotoxy(sekil.x + i, sekil.y);
		cout << sekileleman[sekil.ldegisken];
	}
	for (int i = 0; i < sekil.boyut; i++) {
		gotoxy(sekil.x + sekil.boyut - 1, sekil.y + i);
		cout << sekileleman[sekil.ldegisken];
	}
	for (int i = 0; i < sekil.boyut; i++) {
		gotoxy(sekil.x + sekil.boyut - 1 + i, sekil.y + sekil.boyut);
		cout << sekileleman[sekil.ldegisken];
	}
	for (int i = 0; i < sekil.boyut; i++) {
		gotoxy(sekil.x + 2 * sekil.boyut - 1, sekil.y + sekil.boyut + i);
		cout << sekileleman[sekil.ldegisken];
	}
	for (int i = 0; i < 2 * sekil.boyut; i++) {
		gotoxy(sekil.x + 2 * sekil.boyut - 1 - i, sekil.y + 2 * sekil.boyut);
		cout << sekileleman[sekil.ldegisken];
	}
	for (int i = 0; i < 2 * sekil.boyut; i++) {
		gotoxy(sekil.x + 0, sekil.y + 2 * sekil.boyut - i);
		cout << sekileleman[sekil.ldegisken];
	}
}
//Aşağı götür efektini oluşturur.
LSekli lSekliAsagiGotur(LSekli sekil,Sahne sahne) {
		sekil.y += 1;	
	return sekil;
}
int main()
{
	LSekli sekil=lSekliOlustur();
	Sahne sahne=sahneolustur();
	while (true) {
		system("cls");
		SahneCiz(sahne);
		lSekliCiz(sekil);
		sekil= lSekliAsagiGotur(sekil,sahne);
		//eğer şeklin alt kısmı sahneye teğe olursa yeni bir şekil oluşturur
		if (sekil.y+(2*sekil.boyut)+1 >= sahne.yukseklik) {
		sekil = lSekliOlustur();
		}
		Sleep(100);
	}
	return 0;
}

