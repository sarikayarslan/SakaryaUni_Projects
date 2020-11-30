/** 
* @file Func.hpp 
* @description çift yönlü dairesel bağlı liste oluşturma, çaprazlama. 
* @course 1.ÖĞRETİM C GRUBU
* @assignment ÖDEV 1 
* @date 28.11.2020 
* @author ARSLANCAN SARIKAYA arslancan.sarikaya@ogr.sakarya.edu.tr 
*
**/





#ifndef FUNC_HPP
#define FUNC_HPP
#include <iostream>
#include <sstream>
#include <fstream>
#include "Node.hpp"
#include "List.hpp"
using namespace std;

int satirSay(); // Satir Sayisini Sayar

extern List* nodeList; 
extern Node* buyukList;
extern Node* kucukList;
extern int* tekBilet;
extern int* Sayi;
//Küçük ve Büyük listeleri belirlerler.
Node* kucucuk(List list);
Node* kocaman(List list);

//Düğümleri circular doubly linked list haline getirir.
void dugumBagla(int elemanSayisi, int *Veriler );
//Liste Yazdırır.
void kBListYazdir(List list[],Node* yazdirilacakListe);
//Bağlı listelerin bulunduğu nodelarda küçük ve büyük listelerin indexlerini bulur.
int kucukIndis(List list[]);
int buyukIndis(List list[]);
//Çaprazlama işlemini gerçekleştirir.
void caprazla(Node* kucukOrta, Node* buyukOrta,List list[]);

//Nodeları siler ve Heap temizler.
void gereksizNodeTemizle();
#endif


















