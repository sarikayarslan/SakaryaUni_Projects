/** 
* @file test.cpp 
* @description çift yönlü dairesel bağlı liste oluşturma, çaprazlama. 
* @course 1.ÖĞRETİM C GRUBU
* @assignment ÖDEV 1 
* @date 28.11.2020 
* @author ARSLANCAN SARIKAYA arslancan.sarikaya@ogr.sakarya.edu.tr 
*
**/



#include <iostream>
#include <sstream>
#include <fstream>
#include "Node.hpp"
#include "List.hpp"
#include "Func.hpp"
using namespace std;


int main() {
	*Sayi = 0;
	int elemanSayisi = 0;
	string line;
	string tmp;
	//Eleman sayısına göre dizi oluşturur ve oluşan diziye sayıları atar.
	fstream inFile;
	inFile.open("Sayilar.txt");
	while (!inFile.eof()) {
		getline(inFile, line);
		stringstream ss(line);
		stringstream ss2(line);
		while (ss >> tmp)
		{
			elemanSayisi++;
		}
		int* Sayilar = new int[elemanSayisi];
		int i = 0; 
		while (ss2 >> tmp)
		{

			int intNumber = stoi(tmp);
			Sayilar[i] = intNumber;
			i++;

		}

		dugumBagla(elemanSayisi, Sayilar);
		*Sayi = *Sayi + 1;
		elemanSayisi = 0;
		delete[] Sayilar;

	}
	delete Sayi;
	inFile.close();

	cout <<"En Buyuk Liste Orta Dugum Adresi..:" <<  kocaman(*nodeList) << endl;
	cout << "En Buyuk Liste Degerleri..:"<<endl;
	kBListYazdir(nodeList, buyukList);
	cout <<"En Kucuk Liste Orta Dugum Adresi..:"<< kucucuk(*nodeList) << endl;
	cout << "En Kucuk Liste Degerleri..:"<<endl;
	kBListYazdir(nodeList,kucukList);
	cout << endl;
	caprazla(kucukList, buyukList,nodeList);
	cout <<"Caprazlama Sonuclari..:"<<endl;
	cout << "En Buyuk List..:"<<endl;
	kBListYazdir(nodeList, buyukList);
	cout << "En Kucuk List..:"<<endl;
	kBListYazdir(nodeList, kucukList);
	gereksizNodeTemizle();
	delete[] nodeList;

	return 0;
}