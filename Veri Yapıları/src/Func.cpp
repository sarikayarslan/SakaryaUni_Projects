/** 
* @file Func.cpp
* @description çift yönlü dairesel bağlı liste oluşturma, çaprazlama. 
* @course 1.ÖĞRETİM C GRUBU
* @assignment ÖDEV 1 
* @date 28.11.2020 
* @author ARSLANCAN SARIKAYA arslancan.sarikaya@ogr.sakarya.edu.tr 
*
**/



#include"Func.hpp"

using namespace std;
// Satirları sayar ve ne kadarlık bir nodelist olması gerektiğini bildirir.
int satirSay() {

	int SatirSayisi = 0;
	fstream inCount;
	string counter;
	inCount.open("Sayilar.txt");
	while (!inCount.eof())
	{

		while (getline(inCount, counter)) {
			SatirSayisi++;
		}
	}
	inCount.close();
	return SatirSayisi;
}
//Global Değişkenler
List* nodeList = new List[satirSay()];
Node* buyukList = nullptr;
Node* kucukList = nullptr;
int* tekBilet = 0;
int* Sayi = new int();


// Düğümleri birbirine bağlayarak linked list oluşturur.
void dugumBagla(int elemanSayisi, int *Veriler ){	

	Node* solaEklenen = nullptr;
	Node* sagaEklenen = nullptr;
	Node* temp = nullptr;
	Node* ortaDugum = new Node(Veriler[0]);
	
	
	for (int j = 1; j <= elemanSayisi/2; j++)
	{

		 solaEklenen = new Node(Veriler[j]);
		
		temp = ortaDugum;
		
		while (temp->prev !=NULL)
		{
			temp = temp->prev;
		}
		
		temp->prev = solaEklenen;
		solaEklenen->next = temp;
	}

	for (int k = elemanSayisi/2+1; k < elemanSayisi; k++)
	{
		sagaEklenen = new Node(Veriler[k]);
		temp = ortaDugum;
		while (temp->next != NULL)
		{
			temp = temp->next;

		}

		temp->next = sagaEklenen;
		sagaEklenen->prev  = temp;
		
	
	}

	solaEklenen->prev = sagaEklenen;
	sagaEklenen->next = solaEklenen;

	nodeList[*Sayi].ortaDugum = ortaDugum;
	nodeList[*Sayi].listeboyutu = elemanSayisi;
}

// küçük listi bulur.
Node* kucucuk(List list) {
	if (tekBilet==0)
	{
		 kucukList = nodeList[0].ortaDugum;
	}
	for (int i = 0; i < satirSay(); i++)
	{
		if (nodeList[i].ortaDugum->data < kucukList->data)
		{
			kucukList = nodeList[i].ortaDugum;
		}

	}

	return kucukList;
}
//büyük listi bulur.
Node* kocaman(List list) {
	if (tekBilet == 0)
	{
		buyukList = nodeList[0].ortaDugum;
	}
	for (int i = 0; i < satirSay(); i++)
	{
		if (nodeList[i].ortaDugum->data > buyukList->data)
		{
			buyukList = nodeList[i].ortaDugum;
		}

	}

	tekBilet =0;
	return buyukList;
}
//listeleri yazdırır.
void kBListYazdir(List list[],Node* yazdirilacakListe) {
	Node* temp = nullptr;
	for (int i = 0; i < satirSay(); i++)
	{
		int boyut = list[i].listeboyutu;
		if (list[i].ortaDugum == yazdirilacakListe) {
			
			temp = list[i].ortaDugum;

			for (int i = 0; i < (boyut) / 2; i++)
			{
				temp = temp->prev;
			}

			for (int i = 0; i < boyut; i++)
			{
				cout << temp->data << " ";
				temp = temp->next;
			}



			cout << endl;
		}

	}
}
//Liste küçük listenin hangi indexte olduğunu bulur.
int kucukIndis(List list[]) {
	for (int i = 0; i < satirSay(); i++)
	{
		if (list[i].ortaDugum == kucukList)
		{
			return i;
		}
	}
return 0;
}
//Liste büyük listenin hangi indexte olduğunu bulur.
int buyukIndis(List list[]) {
	for (int i = 0; i < satirSay(); i++)
	{
		if (list[i].ortaDugum == buyukList)
		{
			return i;
		}
	}
	return 0;
}
//çaprazlama işlemini gerçekleştirir.
void caprazla(Node* kucukOrta, Node* buyukOrta,List list[]) {
	Node* buyukOrta2 = new Node(0);
	Node *temp =new Node();
	Node* tmp2 = new Node();

	int buyukI = buyukIndis(nodeList);
	int kucukI = kucukIndis(nodeList);
	
	temp = nodeList[buyukI].ortaDugum->next;
	for (int i = 0; i < (nodeList[buyukI].listeboyutu)-1; i++)
	{
		tmp2 = temp->next;
		temp->next = temp->prev;
		temp->prev = tmp2;
		temp = temp->prev;
	}

	temp = nodeList[kucukI].ortaDugum->next;
	for (int i = 0; i < (nodeList[kucukI].listeboyutu) - 1; i++)
	{
		tmp2 = temp->next;
		temp->next = temp->prev;
		temp->prev = tmp2;
		temp = temp->prev;
	}
	
	buyukOrta->prev->prev = kucukOrta;
	buyukOrta->next->next = kucukOrta;

	kucukOrta->prev->prev = buyukOrta;
	kucukOrta->next->next = buyukOrta;

	buyukOrta2->next = buyukOrta->next;
	buyukOrta2->prev = buyukOrta->prev;

	buyukOrta->next = kucukOrta->prev;
	buyukOrta->prev = kucukOrta->next;

	kucukOrta->prev = buyukOrta2->next;
	kucukOrta->next = buyukOrta2->prev;

	int buyukBoyut = list[buyukI].listeboyutu;
	list[buyukI].listeboyutu = list[kucukI].listeboyutu;
	list[kucukI].listeboyutu = buyukBoyut;


	delete buyukOrta2;
	delete temp;
	delete tmp2;
}
//Node listeyi temizler.
void gereksizNodeTemizle() {
int satirSayisi=satirSay();
Node* silinecekNode1= nullptr;
Node* silinecekNode2 = nullptr;

for (int i = 0; i < satirSayisi; i++)
{
	int boyut = nodeList[i].listeboyutu;
		silinecekNode1 = nodeList[i].ortaDugum;
		for (int i = 0; i < (boyut/2)+1; i++)
		{
			if (i == (boyut / 2))
			{
				delete silinecekNode1;
				break;
			}
			else if (silinecekNode1->next->data !=0)
			{
				silinecekNode2 = silinecekNode1->next;
				delete silinecekNode1;
			}

			silinecekNode1 = silinecekNode2->next;
			delete silinecekNode2;
		}
}
}

















